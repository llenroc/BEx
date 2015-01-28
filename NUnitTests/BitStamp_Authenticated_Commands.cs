﻿using BEx;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    [Category("BitStamp.Authenticated")]
    public class BitStamp_Authenticated_Commands : VerifyExchangeBase
    {
        public BitStamp_Authenticated_Commands()
            : base(typeof(BEx.BitStamp))
        {
            toTest = new BitStamp(base.APIKey, base.Secret, base.ClientID);
        }

        [Test]
        public void BitStamp_GetAccountBalance()
        {
            AccountBalances res = toTest.GetAccountBalance();

            VerifyAccountBalance(res);
        }

        [Test]
        public void BitStamp_CreateBuyOrder()
        {
            VerifyBuyOrder();
        }

        [Test]
        public void BitStamp_CreateSellOrder()
        {
            VerifySellOrder();
        }

        [Test]
        public void BitStamp_GetOpenOrders()
        {
            OpenOrders res = toTest.GetOpenOrders();

            VerifyOpenOrders(res);
        }

        [Test]
        public void BitStamp_GetUserTransactions()
        {
            UserTransactions res = toTest.GetUserTransactions();

            VerifyUserTransactions(res);
        }


        [Test]
        public void BitStamp_GetDepositAddress()
        {
            DepositAddress address = toTest.GetDepositAddress();

            VerifyDepositAddress(address);
        }

        [Test]
        public void BitStamp_GetPendingDeposits()
        {
            PendingDeposits d = toTest.GetPendingDeposits();

            Assert.IsNotNull(d);
        }

        [Test]
        public void BitStamp_GetPendingWithdrawals()
        {
            PendingWithdrawals w = toTest.GetPendingWithdrawals();

            Assert.IsNotNull(w);
        }
    }
}