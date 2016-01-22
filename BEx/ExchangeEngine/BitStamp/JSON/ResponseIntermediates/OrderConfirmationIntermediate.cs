﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BEx.ExchangeEngine.Utilities;
using Newtonsoft.Json;

namespace BEx.ExchangeEngine.BitStamp.JSON.ResponseIntermediates
{
    internal class OrderConfirmationIntermediate : IExchangeResponse<Order>
    {
        [JsonProperty("amount", Required = Required.Always)]
        public string Amount { get; set; }

        [JsonProperty("datetime", Required = Required.Always)]
        public string Datetime { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty("price", Required = Required.Always)]
        public string Price { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public int Type { get; set; }

        public Order Convert(TradingPair pair)
        {
            return new Order(Conversion.ToDateTimeInvariant(Datetime), ExchangeType.BitStamp)
            {
                Amount = Conversion.ToDecimalInvariant(Amount),
                Price = Conversion.ToDecimalInvariant(Price),
                TradeType = Type == 0 ? OrderType.Buy : OrderType.Sell,
                Id = Id,
                Pair = pair
            };
        }
    }
}