﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BEx
{
    public class Transactions : APIResult
    {
        internal Transactions(DateTime exchangeTimeStamp, ExchangeType sourceExchange)
            : base(exchangeTimeStamp, sourceExchange)
        {
        }

        internal Transactions(List<Transaction> transactions, Currency baseCurrency, Currency counterCurrency, ExchangeType sourceExchange)
            : base(DateTime.Now, sourceExchange)
        {
            BaseCurrency = baseCurrency;
            CounterCurrency = counterCurrency;
            TransactionsCollection = transactions;
        }

        public Currency BaseCurrency
        {
            get;
            internal set;
        }

        public Currency CounterCurrency
        {
            get;
            internal set;
        }

        public List<Transaction> TransactionsCollection
        {
            get;
            internal set;
        }

        public override string ToString()
        {
            string output = "{0}/{1} - Transactions: {2} - Oldest: {3} - Newest: {4}";

            if (TransactionsCollection.Count > 0)
            {
                DateTime oldest = TransactionsCollection.Min(x => x.CompletedTime);
                DateTime newest = TransactionsCollection.Max(x => x.CompletedTime);

                return string.Format(output, BaseCurrency, CounterCurrency, TransactionsCollection.Count, oldest.ToString(), newest.ToString());
            }
            else
                return "No Transactions in Collection";
        }
    }
}