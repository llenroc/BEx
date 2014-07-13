﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using RestSharp;
using BEx.BitFinexSupport;

namespace BEx
{
    public abstract class Exchange
    {

        #region Vars
        /// <summary>
        /// Collection of currency pairs supported by the current exchange indexed by the base currency
        /// </summary>
        public Dictionary<Currency, HashSet<Currency>> SupportedPairs;

        

        
        protected RestClient apiClient
        {
            get;
            set;
        }

        protected RequestFactory apiRequestFactory
        {
            get;
            set;
        }

        public Uri BaseURI
        {

            get;
            set;
        }

        /// <summary>
        /// Consecutively increasing action counter
        /// </summary>
        /// <value>0</value>
        public long Nonce
        {
            get
            {
                return DateTime.Now.Ticks;
            }
        }

        public string APIKey
        {
            get;
            set;
        }

        public string SecretKey
        {
            get;
            set;
        }

        public int Signature
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        protected Dictionary<string, APICommand> APICommandCollection
        {
            get;
            set;
        }

        #endregion

        protected Exchange(string configFile)
        {
            LoadConfigFromXML(configFile);
            
            apiClient = new RestClient(BaseURI.ToString());
            apiRequestFactory = new RequestFactory(BaseURI);
        }

        #region Command Execution
        /// <summary>
        /// Verify that a currency pair (e.g. BTC/USD) is supported by this exchange.
        /// </summary>
        /// <param name="baseCurrency">Base Currency</param>
        /// <param name="counterCurrency">Counter Currency</param>
        /// <returns>True if supported, otherwise false.</returns>
        public bool IsCurrencyPairSupported(Currency baseCurrency, Currency counterCurrency)
        {
            bool res = false;

            if (SupportedPairs.ContainsKey(baseCurrency))
            {
                if (SupportedPairs[baseCurrency].Contains(counterCurrency))
                {
                    res = true;
                }
            }

            return res;
        }

        protected void VerifyCurrencySupport(APICommand toCheck)
        {
            if (toCheck.BaseCurrency != null && toCheck.CounterCurrency != null)
            {
                if (!IsCurrencyPairSupported((Currency)toCheck.BaseCurrency, (Currency)toCheck.CounterCurrency))
                {
                    throw new NotImplementedException(string.Format(ErrorMessages.UnsupportedCurrencyPair, toCheck.BaseCurrency.ToString(), toCheck.CounterCurrency.ToString(), this.GetType().ToString()));
                }
            }
        }


        protected string ExecuteCommand(APICommand toExecute)
        {
            VerifyCurrencySupport(toExecute);

            RestRequest request = apiRequestFactory.GetRequest(toExecute);

            IRestResponse response = apiClient.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response.Content;
            else
                return HandleResponseError(response);
        }


        protected string HandleResponseError(IRestResponse response)
        {
            // To Do

            WebException toThrow;


            if (response.ErrorException != null)
                toThrow = new WebException(response.StatusCode.ToString(), response.ErrorException);
            else
                toThrow = new WebException(response.StatusCode.ToString());


            throw toThrow;

            return "";
        }

        #endregion

        #region Load Exchange from XML

        protected void LoadCommands(XElement configFile)
        {
            XElement commands = configFile.Element("Commands");

            foreach (XElement command in commands.Elements())
            {
                APICommand commandToLoad = new APICommand(command);

                APICommandCollection.Add(commandToLoad.ID, commandToLoad);

            }
        }

        protected void LoadConfigFromXML(string file)
        {
            APICommandCollection = new Dictionary<string, APICommand>();

            XElement configFile = XElement.Load(file);

            string baseUrl = configFile.Element("BaseURL").Value;

            BaseURI = new Uri(baseUrl);

            LoadSupportedPairs(configFile);

            LoadCommands(configFile);



        }

        private void LoadSupportedPairs(XElement configFile)
        {
            XElement supportedPairs = configFile.Element("SupportedPairs");

            SupportedPairs = new Dictionary<Currency, HashSet<Currency>>();

            foreach (XElement pairs in supportedPairs.Elements())
            {
                XElement b = pairs.Element("Base");

                XElement c = pairs.Element("Counter");

                Currency bs;
                Currency cs;

                if (Enum.TryParse<Currency>(b.Value, out bs)
                    &&
                Enum.TryParse<Currency>(c.Value, out cs))
                {
                    if (!SupportedPairs.ContainsKey(bs))
                    {
                        SupportedPairs.Add(bs, new HashSet<Currency>());
                    }

                    if (!SupportedPairs[bs].Contains(cs))
                    {
                        SupportedPairs[bs].Add(cs);
                    }
                }

            }
        }
        #endregion

        #region GetOrderBook

        public abstract OrderBook GetOrderBook();

        public abstract OrderBook GetOrderBook(Currency baseCurrency, Currency counterCurrency);


        protected OrderBook GetOrderBook<J>(Currency baseCurrency, Currency counterCurrency)
        {
            OrderBook res = null;

            res = (OrderBook)SendCommandToDispatcher<J, OrderBook>(APICommandCollection["OrderBook"], baseCurrency, counterCurrency);

            return res;
        }


        #endregion

        #region GetTick

        public abstract Tick GetTick();

        public abstract Tick GetTick(Currency baseCurrency, Currency counterCurrency);

        protected Tick GetTick<J>(Currency baseCurrency, Currency counterCurrency)
        {
            Tick res = null;

            res = (Tick)SendCommandToDispatcher<J, Tick>(APICommandCollection["Tick"], baseCurrency, counterCurrency);

            return res;
        }


        #endregion

        #region GetTransactions

        public abstract List<Transaction> GetTransactions();

        /// <summary>
        /// Return transactions that have occurred since the provided DateTime
        /// </summary>
        /// <param name="sinceThisDate"></param>
        /// <returns></returns>
        public abstract List<Transaction> GetTransactions(Currency baseCurrency, Currency counterCurrency);

        protected List<Transaction> GetTransactions<J>(Currency baseCurrency, Currency counterCurrency)
        {
            List<Transaction> res = new List<Transaction>();

            res = (List<Transaction>)SendCommandToDispatcher<List<J>, List<Transaction>>(APICommandCollection["Transactions"], baseCurrency, counterCurrency);

            return res;
        }

        #endregion

        internal abstract void SetParameters(APICommand command);

        private object SendCommandToDispatcher<J, R>(APICommand toExecute, Currency baseCurrency, Currency counterCurrency)
        {
            toExecute.BaseCurrency = baseCurrency;
            toExecute.CounterCurrency = counterCurrency;

            VerifyCurrencySupport(toExecute);

            RequestDispatcher<J, R> disp = new RequestDispatcher<J, R>(BaseURI, apiClient, apiRequestFactory);

            return disp.ExecuteCommand(toExecute);
        }
    }
}
