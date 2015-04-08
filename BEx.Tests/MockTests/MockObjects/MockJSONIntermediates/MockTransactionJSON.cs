﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Newtonsoft.Json;
using BEx.ExchangeEngine.Utilities;
using BEx.ExchangeEngine;

namespace BEx.UnitTests.MockTests.MockObjects.MockJSONIntermediates
{
    internal class MockTransactionJSON : IExchangeResponse
    {
        [JsonProperty("timestamp")]
        public long timestamp { get; set; }

        [JsonProperty("tid")]
        public int tid { get; set; }

        [JsonProperty("price")]
        public string price { get; set; }

        [JsonProperty("amount")]
        public string amount { get; set; }

        [JsonProperty("exchange")]
        public string exchange { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        public BExResult ConvertToStandard(CurrencyTradingPair pair, Exchange sourcExchange)
        {
            return new Transaction(DateTime.UtcNow, sourcExchange)
            {
                Amount = Conversion.ToDecimalInvariant(amount),
                Price = Conversion.ToDecimalInvariant(price),
                TransactionId = tid,
                CompletedTime = Convert.ToDouble(timestamp).ToDateTimeUTC(),
                Pair = pair,
            };
        }
    }
}