﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Newtonsoft.Json;
using BEx.ExchangeEngine.Utilities;


namespace BEx.ExchangeEngine.BitStamp.JSON
{
    internal class TransactionIntermediate : IExchangeResponse
    {
        [JsonProperty("date", Required = Required.Always)]
        public string date { get; set; }

        [JsonProperty("tid", Required = Required.Always)]
        public int tid { get; set; }

        [JsonProperty("price", Required = Required.Always)]
        public string price { get; set; }

        [JsonProperty("amount", Required = Required.Always)]
        public string amount { get; set; }

        public BExResult ConvertToStandard(CurrencyTradingPair pair, Exchange sourceExchange)
        {
            return new Transaction(DateTime.UtcNow, sourceExchange)
            {
                Amount = Conversion.ToDecimalInvariant(amount),
                Price = Conversion.ToDecimalInvariant(price),
                TransactionId = tid,
                Pair = pair,
                CompletedTime = date.ToDateTimeUTC()
            };
        }
    }
}