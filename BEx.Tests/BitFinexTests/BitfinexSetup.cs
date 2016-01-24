﻿using NUnit.Framework;

namespace BEx.Tests.BitfinexTests
{
    [TestFixture]
    [Category("BitFinex.Setup")]
    public class BitfinexSetup : ExchangeVerificationBase
    {
        public BitfinexSetup() : base(ExchangeFactory.GetAuthenticatedExchange(ExchangeType.Bitfinex))
        {
        }

        [Test]
        public void Bitfinex_SupportedCurrencies_Complete()
        {
            Assert.That(TestCandidate.SupportedCurrencies.Count == 3);
            Assert.That(TestCandidate.SupportedCurrencies.Contains(Currency.BTC));
            Assert.That(TestCandidate.SupportedCurrencies.Contains(Currency.LTC));
            Assert.That(TestCandidate.SupportedCurrencies.Contains(Currency.USD));
        }

        [Test]
        public void Bitfinex_SupportedPairs_Complete()
        {
            Assert.That(TestCandidate.SupportedTradingPairs.Count == 3);

            Assert.That(TestCandidate.IsTradingPairSupported(new TradingPair(Currency.BTC, Currency.USD)));
            Assert.That(TestCandidate.IsTradingPairSupported(new TradingPair(Currency.LTC, Currency.USD)));
            Assert.That(TestCandidate.IsTradingPairSupported(new TradingPair(Currency.LTC, Currency.BTC)));
            Assert.That(TestCandidate.DefaultPair == new TradingPair(Currency.BTC, Currency.USD));
        }
    }
}