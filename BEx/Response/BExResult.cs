﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace BEx
{
    /// <summary>
    /// Exchange Result Base Class
    /// </summary>
    [DebuggerDisplay("{DebugDisplay,nq}")]
    public abstract class BExResult : IExchangeResult
    {
        internal BExResult(DateTime exchangeTimeStamp, ExchangeType sourceExchange)
        {
            this.ExchangeTimeStampUTC = exchangeTimeStamp;
            this.LocalTimeStampUTC = DateTime.UtcNow;
            this.SourceExchange = sourceExchange;
        }

        /// <summary>
        /// Exchange reported TimeStamp of the action.  When the Exchange does not provide
        /// a TimeStamp, this value will be equal to LocalTimeStamp.
        /// </summary>
        public DateTime ExchangeTimeStampUTC
        {
            get;
            private set;
        }

        /// <summary>
        /// Local Machine TimeStamp marking the time at which an Exchange Command has successfully executed.
        /// </summary>
        public DateTime LocalTimeStampUTC
        {
            get;
            private set;
        }

        /// <summary>
        /// Exchange from which this result was received
        /// </summary>
        public ExchangeType SourceExchange
        {
            get;
            private set;
        }

        protected virtual string DebugDisplay
        {
            get { return string.Format("{0} {1}", SourceExchange, ExchangeTimeStampUTC); }
        }
    }
}