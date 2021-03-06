﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

using BEx.ExchangeEngine.API;
using BEx.ExchangeEngine.API.Commands;
using BEx.Exchanges.BitStamp.API.Models;
using RestSharp;

namespace BEx.Exchanges.BitStamp.API
{
    internal class CommandFactory : IExchangeCommandFactory
    {
        private static readonly CommandFactory Instance = new CommandFactory();

        private CommandFactory()
        {
            BuildCommands();
        }

        public static IExchangeCommandFactory Singleton => Instance;

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.GetAccountBalance()
        /// </summary>
        /// <returns></returns>
        public AccountBalanceCommand AccountBalance { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.CreateBuyOrder()
        /// </summary>
        /// <returns></returns>
        public LimitOrderCommand BuyOrder { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.CancelOrder()
        /// </summary>
        /// <returns></returns>
        public CancelOrderCommand CancelOrder { get; private set; }

        public OrderStatusCommand OrderStatus { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.GetOpenOrders()
        /// </summary>
        /// <returns></returns>
        public OpenOrdersCommand OpenOrders { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IUnauthenticatedCommands.GetOrderBook()
        /// </summary>
        /// <returns></returns>
        public OrderBookCommand OrderBook { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.CreateSellOrder()
        /// </summary>
        /// <returns></returns>
        public LimitOrderCommand SellOrder { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IUnauthenticatedCommands.GetTick()
        /// </summary>
        /// <returns></returns>
        public TickCommand Tick { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IUnauthenticatedCommands.GetTransactions()
        /// </summary>
        /// <returns></returns>
        public TransactionsCommand Transactions { get; private set; }

        /// <summary>
        ///     ExchangeCommand associated with IAuthenticatedCommands.GetUserTransactions()
        /// </summary>
        /// <returns></returns>
        public UserTransactionsCommand UserTransactions { get; private set; }

        public AccountBalanceCommand BuildAccountBalanceCommand()
        {
            return new AccountBalanceCommand(
                Method.POST,
                new Uri("balance/", UriKind.Relative),
                true,
                typeof(AccountBalanceModel));
        }

        public LimitOrderCommand BuildBuyOrderCommand()
        {
            var param = new List<ExchangeParameter>
            {
                new ExchangeParameter(ParameterMethod.Post, "amount", StandardParameter.Amount),
                new ExchangeParameter(ParameterMethod.Post, "price", StandardParameter.Price)
            };

            return new LimitOrderCommand(
                Method.POST,
                new Uri("buy/", UriKind.Relative),
                true,
                typeof(OrderConfirmationModel),
                param);
        }

        public CancelOrderCommand BuildCancelOrderCommand()
        {
            var param = new List<ExchangeParameter>
            {
                new ExchangeParameter(ParameterMethod.Post, "id", StandardParameter.Id)
            };

            return new CancelOrderCommand(
                Method.POST,
                new Uri("cancel_order/", UriKind.Relative),
                true,
                typeof(Confirmation),
                param);
        }

        public void BuildCommands()
        {
            AccountBalance = BuildAccountBalanceCommand();
            BuyOrder = BuildBuyOrderCommand();
            CancelOrder = BuildCancelOrderCommand();
            OpenOrders = BuildOpenOrdersCommand();
            OrderBook = BuildOrderBookCommand();
            SellOrder = BuildSellOrderCommand();
            Tick = BuildTickCommand();
            Transactions = BuildTransactionsCommand();
            UserTransactions = BuildUserTransactionsCommand();
            
        }

        public OpenOrdersCommand BuildOpenOrdersCommand()
        {
            return new OpenOrdersCommand(
                Method.POST,
                new Uri("open_orders/", UriKind.Relative),
                true,
                typeof(List<OpenOrdersModel>));
        }

        public OrderBookCommand BuildOrderBookCommand()
        {
            return new OrderBookCommand(
                Method.GET,
                new Uri("order_book/", UriKind.Relative),
                false,
                typeof(OrderBookModel));
        }

        public LimitOrderCommand BuildSellOrderCommand()
        {
            var param = new List<ExchangeParameter>
            {
                new ExchangeParameter(ParameterMethod.Post, "amount", StandardParameter.Amount),
                new ExchangeParameter(ParameterMethod.Post, "price", StandardParameter.Price)
            };

            return new LimitOrderCommand(
                Method.POST,
                new Uri("sell/", UriKind.Relative),
                true,
                typeof(OrderConfirmationModel),
                param);
        }
        

        public TickCommand BuildTickCommand()
        {
            return new TickCommand(
                Method.GET,
                new Uri("ticker/", UriKind.Relative),
                false,
                typeof(TickModel));
        }

        public TransactionsCommand BuildTransactionsCommand()
        {
            var param = new List<ExchangeParameter>
            {
                new ExchangeParameter(ParameterMethod.Post, "time", StandardParameter.None, "hour")
            };

            return new TransactionsCommand(
                Method.GET,
                new Uri("transactions/", UriKind.Relative),
                false,
                typeof(List<TransactionModel>),
                param);
        }

        public UserTransactionsCommand BuildUserTransactionsCommand()
        {
            return new UserTransactionsCommand(
                Method.POST,
                new Uri("user_transactions/", UriKind.Relative),
                true,
                typeof(List<UserTransactionModel>)
                );
        }
    }
}