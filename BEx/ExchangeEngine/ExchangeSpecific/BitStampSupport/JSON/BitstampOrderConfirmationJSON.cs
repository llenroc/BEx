﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using BEx.ExchangeEngine.Utilities;

namespace BEx.ExchangeEngine.BitStampSupport
{
    internal class BitStampOrderConfirmationJSON : IExchangeResponse
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        public ApiResult ConvertToStandard(CurrencyTradingPair pair)
        {
            return new Order(Conversion.ToDateTimeInvariant(Datetime), ExchangeType.BitStamp)
            {
                Amount = Conversion.ToDecimalInvariant(Amount),
                Price = Conversion.ToDecimalInvariant(Price),
                TradeType = Type == 0 ? OrderType.Buy : OrderType.Sell,
                Id = Id,
                ExchangeTimestamp = Conversion.ToDateTimeInvariant(Datetime),
                Pair = pair
            };
        }
    }
}