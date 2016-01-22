﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using BEx.ExchangeEngine.Utilities;
using Newtonsoft.Json;

namespace BEx.ExchangeEngine.BitStamp.JSON.ResponseIntermediates
{
    internal class OrderBookIntermediate : IExchangeResponse<OrderBook>
    {
        [JsonProperty("timestamp", Required = Required.Always)]
        public string Timestamp { get; set; }

        [JsonProperty("bids", Required = Required.Always)]
        public string[][] Bids { get; set; }

        [JsonProperty("asks", Required = Required.Always)]
        public string[][] Asks { get; set; }

        public OrderBook Convert(TradingPair pair)
        {
            IList<OrderBookEntry> convertedBids = Bids
                .Select(
                    x =>
                        new OrderBookEntry(Conversion.ToDecimalInvariant(x[1]), Conversion.ToDecimalInvariant(x[0])))
                .ToList();

            IList<OrderBookEntry> convertedAsks = Asks
                .Select(
                    x =>
                        new OrderBookEntry(Conversion.ToDecimalInvariant(x[1]), Conversion.ToDecimalInvariant(x[0])))
                .ToList();

            return new OrderBook(
                convertedBids,
                convertedAsks,
                Timestamp.ToDateTimeUTC(),
                ExchangeType.BitStamp)
            {
                Pair = pair
            };
        }
    }
}