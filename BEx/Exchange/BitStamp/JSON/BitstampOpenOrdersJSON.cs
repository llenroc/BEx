﻿using Newtonsoft.Json;
using System;

namespace BEx.BitStampSupport
{
    public class BitStampOpenOrdersJSON : ExchangeResponse<Order>
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        public override Order ConvertToStandard(CurrencyTradingPair pair)
        {
            Order res = new Order(Convert.ToDateTime(Datetime), ExchangeType.BitStamp);

            res.Amount = Convert.ToDecimal(Amount);
            res.Price = Convert.ToDecimal(Price);

            if (Type == 0)
                res.TradeType = OrderType.Buy;
            else
                res.TradeType = OrderType.Sell;

            res.ID = Id;
            res.ExchangeTimeStamp = Convert.ToDateTime(Datetime);

            res.Pair = pair;

            return res;
        }
    }
}