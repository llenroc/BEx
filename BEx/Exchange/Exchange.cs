﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Security.Cryptography;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using RestSharp;
using BEx.BitFinexSupport;

namespace BEx
{

    public delegate string GetSignature();

    public abstract class Exchange : IDisposable
    {
        #region Vars
        /// <summary>
        /// Collection of currency pairs supported by the current exchange indexed by the base currency
        /// </summary>
        public Dictionary<Currency, HashSet<Currency>> SupportedPairs;

        protected RequestFactory apiRequestFactory
        {
            get;
            set;
        }

        internal RequestDispatcher dispatcher
        {
            get;
            set;
        }

        public Uri BaseURI
        {

            get;
            set;
        }

        public Uri AuthenticatedURI
        {
            get;
            set;
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

        public string ClientID
        {
            get;
            set;
        }

        protected Dictionary<string, APICommand> APICommandCollection
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
        #endregion

        protected Exchange(string configFile)
        {
            LoadConfigFromXML(configFile);

            string apiClient = null;
            string authenticatedClient = null;

            apiClient = BaseURI.ToString();

            if (AuthenticatedURI != null)
                authenticatedClient = AuthenticatedURI.ToString();
            else
                authenticatedClient = null;

            dispatcher = new RequestDispatcher(apiClient, authenticatedClient);

            apiRequestFactory = new RequestFactory();
            apiRequestFactory.GetSignature += CreateSignature;
        }

        #region Command abstracts

        

        #endregion

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

        /*
        protected void VerifyCurrencySupport(APICommand toCheck)
        {
            if (toCheck.BaseCurrency != null && toCheck.CounterCurrency != null)
            {
                if (!IsCurrencyPairSupported((Currency)toCheck.BaseCurrency, (Currency)toCheck.CounterCurrency))
                {
                    throw new NotImplementedException(string.Format(ErrorMessages.UnsupportedCurrencyPair, toCheck.BaseCurrency.ToString(), toCheck.CounterCurrency.ToString(), this.GetType().ToString()));
                }
            }
        }*/

        #endregion

        #region API Commands

        #region GetOrderBook

        protected abstract OrderBook ExecuteOrderBookCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public OrderBook GetOrderBook()
        {
            return GetOrderBook(Currency.BTC, Currency.USD);
        }

        public OrderBook GetOrderBook(Currency baseCurrency, Currency counterCurrency)
        {
            OrderBook res = null;

            res = ExecuteOrderBookCommand(APICommandCollection["OrderBook"], baseCurrency, counterCurrency);
            //res = (OrderBook)SendCommandToDispatcher<J>(APICommandCollection["OrderBook"], baseCurrency, counterCurrency);

            return res;
        }


        #endregion

        #region GetTick

        protected abstract Tick ExecuteTickCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public Tick GetTick()
        {

            return GetTick(Currency.BTC, Currency.USD);
        }

        public Tick GetTick(Currency baseCurrency, Currency counterCurrency)
        {
            Tick res = null;

            res = ExecuteTickCommand(APICommandCollection["Tick"], baseCurrency, counterCurrency);

            return res;
        }

        #endregion

        #region GetTransactions

        protected abstract Transactions ExecuteTransactionsCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public Transactions GetTransactions()
        {
            return GetTransactions(Currency.BTC, Currency.USD);
        }
        
        public Transactions GetTransactions(Currency baseCurrency, Currency counterCurrency)
        {
            Transactions res = new Transactions();

            res = ExecuteTransactionsCommand(APICommandCollection["Transactions"], baseCurrency, counterCurrency);
            //res = (Transactions)SendCommandToDispatcher<List<J>>(APICommandCollection["Transactions"], baseCurrency, counterCurrency);

            return res;
        }

        #endregion

        #region Account Balance

        protected abstract AccountBalance ExecuteAccountBalanceCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public AccountBalance GetAccountBalance()
        {
            return GetAccountBalance(Currency.BTC, Currency.USD);
        }

        public AccountBalance GetAccountBalance(Currency baseCurrency, Currency counterCurrency)
        {
            AccountBalance res;

            res = ExecuteAccountBalanceCommand(APICommandCollection["AccountBalance"], baseCurrency, counterCurrency);

            return res;
        }

        #endregion

        #region Buy Limit Order

        protected abstract Order ExecuteOrderCommand(APICommand command, Currency baseCurrency, Currency counterCurrency, decimal amount, decimal price);

        public Order CreateBuyOrder(decimal amount, decimal price)
        {
            return CreateBuyOrder(Currency.BTC, Currency.USD, amount, price);
        }

        public Order CreateBuyOrder(Currency baseCurrency, Currency counterCurrency, decimal amount, decimal price)
        {
            Order res;

            res = ExecuteOrderCommand(APICommandCollection["BuyOrder"], baseCurrency, counterCurrency, amount, price);
            //res = (Order)SendCommandToDispatcher<B>(APICommandCollection["BuyOrder"], Currency.BTC, Currency.USD);

            return res;
        }

        #endregion

        #region Sell Limit Order

        public Order CreateSellOrder(decimal amount, decimal price)
        {
            return CreateSellOrder(Currency.BTC, Currency.USD, amount, price);
        }

        public Order CreateSellOrder(Currency baseCurrency, Currency counterCurrency, decimal amount, decimal price)
        {
            Order res;

            res = ExecuteOrderCommand(APICommandCollection["SellOrder"], baseCurrency, counterCurrency, amount, price);

            return res;
        }

        #endregion

        #region Open Orders

        protected abstract OpenOrders ExecuteGetOpenOrdersCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public OpenOrders GetOpenOrders()
        {
            return GetOpenOrders(Currency.BTC, Currency.USD);
        }

        protected OpenOrders GetOpenOrders(Currency baseCurrency, Currency counterCurrency)
        {
            OpenOrders res;

            res = ExecuteGetOpenOrdersCommand(APICommandCollection["OpenOrders"], baseCurrency, counterCurrency);
            //res = (OpenOrders)SendCommandToDispatcher<List<B>>(APICommandCollection["OpenOrders"], baseCurrency, counterCurrency);

            return res;

        }
        #endregion

        #region User Transactions

        protected abstract UserTransactions ExecuteGetUserTransactionsCommand(APICommand command, Currency baseCurrency, Currency counterCurrency);

        public UserTransactions GetUserTransactions()
        {
            return GetUserTransactions(Currency.BTC, Currency.USD);
        }

        public UserTransactions GetUserTransactions(Currency baseCurrency, Currency counterCurrency)
        {
            UserTransactions res;

            res = ExecuteGetUserTransactionsCommand(APICommandCollection["UserTransactions"], baseCurrency, counterCurrency);

            return res;
        }

        #endregion

        #region Cancel Order

        protected abstract bool ExecuteCancelOrderCommand(APICommand command, int id);
        
        public  bool CancelOrder(Order toCancel)
        {
            return CancelOrder(toCancel.ID);
        }

        public bool CancelOrder(int id)
        {
            bool res;

            res = ExecuteCancelOrderCommand(APICommandCollection["CancelOrder"], id);
            //res = (bool)SendCommandToDispatcher<B>(APICommandCollection["CancelOrder"], Currency.BTC, Currency.USD);

            return res;
        }

        #endregion

        #region Deposit Address

        protected abstract string ExecuteGetDepositAddressCommand(APICommand command, Currency toDeposit);

        public string GetDepositAddress()
        {
            return GetDepositAddress(Currency.BTC);
        }

        protected string GetDepositAddress(Currency toDeposit)
        {
            string res;

            res = ExecuteGetDepositAddressCommand(APICommandCollection["DepositAddress"], toDeposit);

            return res;
        }

        #endregion

        #region Withdraw

        protected abstract object ExecuteWithdrawCommand(APICommand command, Currency toWithdraw, string address, decimal amount);

        public object Withdraw(Currency toWithdraw, string address, decimal amount)
        {
            object res;

            res = ExecuteWithdrawCommand(APICommandCollection["Withdraw"], toWithdraw, address, amount);

            return res;
        }

        #endregion

        #region Pending Deposits
        
        protected abstract object ExecutePendingDepositsCommand(APICommand command);

        public object GetPendingDeposits()
        {
            object res = null;

            ExecutePendingDepositsCommand(APICommandCollection["PendingDeposits"]);
            //res = SendCommandToDispatcher<object>(APICommandCollection["PendingDeposits"], Currency.None, Currency.None);

            return res;
        }

        #endregion

        #region Pending Withdrawals

        protected abstract object ExecutePendingWithdrawalsCommand(APICommand command);

        protected object PendingWithdrawals()
        {
            object res = null;

            res = ExecutePendingWithdrawalsCommand(APICommandCollection["PendingWithdrawals"]);

            return res;
        }

        #endregion

        #endregion

        protected object SendCommandToDispatcher<J>(APICommand toExecute, Currency baseCurrency, Currency counterCurrency, Dictionary<string, string> parameters = null)
        {

            RestRequest request = apiRequestFactory.GetRequest(toExecute, baseCurrency, counterCurrency, parameters);

            return dispatcher.ExecuteCommand<J>(request, toExecute, baseCurrency, counterCurrency);
        }

        protected abstract void CreateSignature(RestRequest request, APICommand command, Currency baseCurrency, Currency counterCurrency, Dictionary<string, string> parameters = null);

        #region Dispose
        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

                //
            }
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

            if (configFile.Element("AuthenticatedURL") != null)
                AuthenticatedURI = new Uri(configFile.Element("AuthenticatedURL").Value);

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
    }
}
