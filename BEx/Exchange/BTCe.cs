﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BEx.BTCeSupport;

namespace BEx
{
    public class BTCe : Exchange
    {
        

        public BTCe() : base("BTCe.xml")
        {
            foreach (APICommand command in APICommandCollection.Values)
            {
                command.CurrencyFormatter += FormatCurrency;
            }
        }

        private string FormatCurrency(string currency)
        {
            return currency.ToLower();
        }

        public override Tick GetTick()
        {
            return base.GetTick<BTCeTickJSON>(Currency.BTC, Currency.USD);
        }

        public override Tick GetTick(Currency baseCurrency, Currency counterCurrency)
        {
            return base.GetTick<BTCeTickJSON>(baseCurrency, counterCurrency);
        }

        public override OrderBook GetOrderBook()
        {

            return base.GetOrderBook<BTCeOrderBookJSON>(Currency.BTC, Currency.USD);
        }

        public override OrderBook GetOrderBook(Currency baseCurrency, Currency counterCurrency)
        {
            return base.GetOrderBook<BTCeOrderBookJSON>(baseCurrency, counterCurrency);
        }

        public override List<Transaction> GetTransactions()
        {
            
            return base.GetTransactions<BTCeTransactionsJSON>(Currency.BTC, Currency.USD);
        }

        public override List<Transaction> GetTransactions(Currency baseCurrency, Currency counterCurrency)
        {
            return base.GetTransactions<BTCeTransactionsJSON>(baseCurrency, counterCurrency);
        }


        public override object GetAccountBalance()
        {
            return base.GetAccountBalance(Currency.BTC, Currency.USD);
        }


        internal override void SetParameters(APICommand command)
        {
            
        }

        protected override Tuple<string, string, string> CreateSignature()
        {
            Tuple<string, string, string> res = new Tuple<string, string, string>("", "", "");

            return res;
        }

    }
}
