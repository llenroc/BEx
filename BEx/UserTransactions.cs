﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using BEx.ExchangeEngine;

using BEx.ExchangeEngine.API;

namespace BEx
{
    public sealed class UserTransactions : BExResult
    {
        internal UserTransactions(
            IEnumerable<IExchangeResponseIntermediate<UserTransaction>> transactions,
            TradingPair pair,
            IExchangeConfiguration configuration)
            : base(DateTime.UtcNow, configuration.ExchangeSourceType)
        {
            Pair = pair;

            TransactionsCollection =
                transactions
                    .Select(x => x.Convert(pair))
                    .Where(x => x != default(UserTransaction))
                    .ToList()
                    .AsReadOnly();
        }

        public TradingPair Pair { get; }

        public IReadOnlyList<UserTransaction> TransactionsCollection { get; }

        public override string ToString()
            => $"{SourceExchange} {Pair} - Count: {TransactionsCollection.Count}";
    }
}