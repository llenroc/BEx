﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BEx.BitFinexSupport;
using BEx.Common;

namespace BEx
{
    public class Bitfinex : Exchange
    {

        public Bitfinex() : base("BitFinex.xml")
        {

        }

        public Tick GetTick()
        {
            Tick res;

            APICommand toExecute = APICommandCollection["Tick"];

            toExecute.BaseCurrency = Currency.BTC;
            toExecute.CounterCurrency = Currency.USD;

            res = ExecuteCommand<BitfinexTickJSON>(toExecute).ToTick(Currency.BTC, Currency.USD);

            return res;
        }

        public override Tick GetTick(Currency baseCurrency, Currency counterCurrency)
        {
            Tick res;

            APICommand toExecute = APICommandCollection["Tick"];

            toExecute.BaseCurrency = baseCurrency;
            toExecute.CounterCurrency = counterCurrency;

            res = ExecuteCommand<BitfinexTickJSON>(toExecute).ToTick(baseCurrency, counterCurrency);

            return res;

        }

        public OrderBook GetOrderBook()
        {
            OrderBook res;

            APICommand toExecute = APICommandCollection["OrderBook"];

            toExecute.BaseCurrency = Currency.BTC;
            toExecute.CounterCurrency = Currency.USD;

            res = ExecuteCommand<BitFinexOrderBookJSON>(toExecute).ToOrderBook(Currency.BTC, Currency.USD);

            return res;
        }

        public override OrderBook GetOrderBook(Currency baseCurrency, Currency counterCurrency)
        {
            OrderBook res;

            APICommand toExecute = APICommandCollection["OrderBook"];

            toExecute.BaseCurrency = baseCurrency;
            toExecute.CounterCurrency = counterCurrency;

            res = ExecuteCommand<BitFinexOrderBookJSON>(toExecute).ToOrderBook(baseCurrency, counterCurrency);

            return res;
        }

        public List<Transaction> GetTransactions()
        {
            List<Transaction> res = new List<Transaction>();

            APICommand toExecute = APICommandCollection["Transactions"];

            toExecute.BaseCurrency = Currency.BTC;
            toExecute.CounterCurrency = Currency.USD;

            List<BitFinexTransactionJSON> r = ExecuteCommand<List<BitFinexTransactionJSON>>(APICommandCollection["Transactions"]);

            
            //return Transaction.ConvertBitFinexTransactionList(r);

            return BitFinexTransactionJSON.ConvertBitFinexTransactionList(r, (Currency)toExecute.BaseCurrency, (Currency)toExecute.CounterCurrency);
            

        }

        /// <summary>
        /// Return transactions that have occurred since the provided DateTime
        /// </summary>
        /// <param name="sinceThisDate"></param>
        /// <returns></returns>
        public List<Transaction> GetTransactions(DateTime sinceThisDate, Currency baseCurrency, Currency counterCurrency)
        {
            List<Transaction> res = new List<Transaction>();

            APICommand toExecute = APICommandCollection["Transactions"];

            toExecute.BaseCurrency = baseCurrency;
            toExecute.CounterCurrency = counterCurrency;

            toExecute.Parameters["timestamp"] = UnixTime.DateTimeToUnixTimestamp(sinceThisDate).ToString();

            List<BitFinexTransactionJSON> r = ExecuteCommand<List<BitFinexTransactionJSON>>(APICommandCollection["Transactions"]);

            return BitFinexTransactionJSON.ConvertBitFinexTransactionList(r, (Currency)toExecute.BaseCurrency, (Currency)toExecute.CounterCurrency);


        }

        public override List<Transaction> GetTransactions(Currency baseC, Currency counterC)
        {
            List<Transaction> res = new List<Transaction>();

            APICommand toExecute = APICommandCollection["Transactions"];

            toExecute.BaseCurrency = baseC;
            toExecute.CounterCurrency = counterC;

            List<BitFinexTransactionJSON> r = ExecuteCommand<List<BitFinexTransactionJSON>>(APICommandCollection["Transactions"]);
            

            return BitFinexTransactionJSON.ConvertBitFinexTransactionList(r, baseC, counterC);
        }
    }
}