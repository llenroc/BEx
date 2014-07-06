﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using BEx;

namespace NUnitTests
{
    public class VerifyExchangeBase
    {

        protected void VerifyTick(Tick toVerify, Currency baseC, Currency counterC)
        {
            Assert.IsNotNull(toVerify);

            Assert.IsTrue(toVerify.BaseCurrency == baseC);
            Assert.IsTrue(toVerify.CounterCurrency == counterC);
            Assert.IsTrue(toVerify.Ask > 0);
            Assert.IsTrue(toVerify.Bid > 0);
            Assert.IsTrue(toVerify.High > 0);
            Assert.IsTrue(toVerify.Last > 0);
            Assert.IsTrue(toVerify.Low > 0);
            Assert.IsTrue(toVerify.Volume > 0);
            //Assert.IsTrue(toVerify.VWAP > 0);
        }

        protected void VerifyOrderBook(OrderBook toVerify)
        {

            Assert.IsNotNull(toVerify);

            Assert.IsTrue(toVerify.BidsByPrice.Keys.Count > 0);
            Assert.IsTrue(toVerify.AsksByPrice.Keys.Count > 0);
        }


        protected void VerifyTransactions(List<Transaction> toVerify)
        {
            Assert.IsNotNull(toVerify);
            Assert.IsTrue(toVerify.Count > 0);
        }


    }
}