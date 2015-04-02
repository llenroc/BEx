﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Threading;

namespace BEx.ExchangeEngine.BitStampSupport
{
    public class BitStampConfiguration : IExchangeConfiguration
    {
        private long _nonce = DateTime.UtcNow.Ticks;

        public BitStampConfiguration(string apiKey, string clientId, string secretKey)
        {
            ApiKey = apiKey;
            ClientId = clientId;
            SecretKey = secretKey;

            Initialize(null);
        }

        public BitStampConfiguration(string apiKey, string clientId, string secretKey, Uri baseUri)
        {
            ApiKey = apiKey;
            ClientId = clientId;
            SecretKey = secretKey;

            Initialize(baseUri);
        }

        internal BitStampConfiguration()
        {
            Initialize(null);
        }

        public string ApiKey
        {
            get;
            private set;
        }

        public string ClientId
        {
            get;
            private set;
        }

        public CurrencyTradingPair DefaultPair
        {
            get;
            private set;
        }

        public string SecretKey
        {
            get;
            set;
        }

        public IList<CurrencyTradingPair> SupportedPairs
        {
            get;
            private set;
        }

        public HashSet<Currency> SupportedCurrencies
        {
            get;
            private set;
        }

        public Uri BaseUri
        {
            get;
            private set;
        }

        public ExchangeType ExchangeSourceType
        {
            get;
            private set;
        }

        /// <summary>
        /// Consecutively increasing action counter
        /// </summary>
        /// <value>0</value>
        public long Nonce
        {
            get
            {
                return Interlocked.Increment(ref _nonce);
            }
        }

        public Type ErrorJsonType
        {
            get;
            private set;
        }

        private void Initialize(Uri baseUri)
        {
            ErrorJsonType = typeof(BitStampErrorJSON);
            DefaultPair = new CurrencyTradingPair(Currency.BTC, Currency.USD);
            ExchangeSourceType = ExchangeType.BitStamp;
            SupportedPairs = new List<CurrencyTradingPair>() { DefaultPair };

            SupportedCurrencies = new HashSet<Currency>()
            {
                DefaultPair.BaseCurrency,
                DefaultPair.CounterCurrency
            };

            BaseUri = baseUri ?? new Uri("https://www.bitstamp.net/api");
        }
    }
}