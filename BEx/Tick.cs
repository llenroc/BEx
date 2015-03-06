﻿using System;

namespace BEx
{
    /// <summary>
    /// Exchange Tick
    /// </summary>
    public class Tick : APIResult
    {
        internal Tick(DateTime exchangeTimeStamp, ExchangeType sourceExchange)
            : base(exchangeTimeStamp, sourceExchange)
        { }

        /// <summary>
        /// Lowest Sell Price
        /// </summary>
        public Decimal Ask
        {
            get;
            internal set;
        }

        /// <summary>
        /// Highest Buy Price
        /// </summary>
        public Decimal Bid
        {
            get;
            internal set;
        }

        /// <summary>
        /// Trading Pair
        /// </summary>
        public CurrencyTradingPair Pair
        {
            get;
            internal set;
        }

        /// <summary>
        /// Highest trade price of the last 24 hours
        /// </summary>
        public Decimal High
        {
            get;
            internal set;
        }

        /// <summary>
        /// Price at which the last order executed
        /// </summary>
        public Decimal Last
        {
            get;
            internal set;
        }

        /// <summary>
        /// Lowest trade price of the last 24 hours
        /// </summary>
        public Decimal Low
        {
            get;
            internal set;
        }

        /// <summary>
        /// Trade volume of the last 24 hours
        /// </summary>
        public Decimal Volume
        {
            get;
            internal set;
        }

        public override string ToString()
        {
            string output = "{0} - Bid: {1} - Ask: {2} - High: {3} - Low: {4} - Volume: {5} - Time: {6}";

            return string.Format(output, Pair, Bid, Ask, High, Low, Volume, ExchangeTimeStamp.ToString());
        }
    }
}