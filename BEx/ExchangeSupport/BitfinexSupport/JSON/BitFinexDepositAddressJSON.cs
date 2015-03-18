﻿using Newtonsoft.Json;
using System;

namespace BEx.ExchangeSupport.BitfinexSupport
{
    internal class BitFinexDepositAddressJSON : IExchangeResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        public APIResult ConvertToStandard(CurrencyTradingPair pair)
        {
            return new DepositAddress(Address, DateTime.Now, pair.BaseCurrency, ExchangeType.BitFinex);
        }
    }
}