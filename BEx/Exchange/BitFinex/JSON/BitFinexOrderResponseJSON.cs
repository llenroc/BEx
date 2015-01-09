﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace BEx.BitFinexSupport
{
    public class BitFinexOrderResponseJSON : ExchangeResponse
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("avg_execution_price")]
        public string AvgExecutionPrice { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("is_live")]
        public bool IsLive { get; set; }

        [JsonProperty("is_cancelled")]
        public bool IsCancelled { get; set; }

        [JsonProperty("was_forced")]
        public bool WasForced { get; set; }

        [JsonProperty("original_amount")]
        public string OriginalAmount { get; set; }

        [JsonProperty("remaining_amount")]
        public string RemainingAmount { get; set; }

        [JsonProperty("executed_amount")]
        public string ExecutedAmount { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }


        public override APIResult ConvertToStandard(Currency baseCurrency, Currency counterCurrency)
        {
            Order res = new Order();

            res.Amount = Convert.ToDecimal(OriginalAmount);
            res.BaseCurrency = baseCurrency;
            res.CounterCurrency = counterCurrency;
            res.ID = Id;
            res.Price = Convert.ToDecimal(Price);

            if (IsLive)
                res.Status = ExecutionStatus.Pending;
            else
                res.Status = ExecutionStatus.Failed;

            return res;
        }

  }
}
