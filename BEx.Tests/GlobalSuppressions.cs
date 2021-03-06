// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Code Analysis results, point to "Suppress Message", and click
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Finex",
        Scope = "type", Target = "NUnitTests.BitFinex_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "NUnitTests.BitfinexExceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Bitfinex",
        Scope = "type", Target = "NUnitTests.BitfinexExceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetOpenOrders_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "NUnitTests.BitFinex_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetAccountBalance_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_LTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_DRK_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#Constructor_MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "NUnitTests.BitfinexExceptions.#AuthenticatedCommand_IncorrectSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#CreateSellOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#CreateBuyOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "NUnitTests.BitStamp_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetAccountBalance_All_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetOpenOrders_BTCUSD_SUccess()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "NUnitTests.BitStamp_Exceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#Constructor_MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "NUnitTests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#Constructor_MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "NUnitTests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#CreateSellOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#CreateBuyOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#IncorrectSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#CreateSellOrder_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#CreateBuyOrder_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
        Target = "NUnitTests.ExchangeCommandVerification.#VerifyAPIResult(BEx.ApiResult)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
        Target = "NUnitTests.ExchangeVerificationBase.#.ctor(BEx.Exchange)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Finex",
        Scope = "type", Target = "NUnitTests.BitFinex_Unauthenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetOpenOrders_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTC", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTC", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_LTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRK", Scope = "member",
        Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetDepositAddress_DRK_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.BitfinexExceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTick_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "NUnitTests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetOpenOrders_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTC", Scope = "member",
        Target = "NUnitTests.BitStamp_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "NUnitTests.BitStamp_Exceptions.#Constructor_MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target =
            "NUnitTests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "NUnitTests.BitStampUnauthenticatedCommands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.ExchangeCommandVerification.#VerifyAPIResult(BEx.ApiResult)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "test", Scope = "member",
        Target = "NUnitTests.ExchangeVerificationBase.#TestCandidate")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "test", Scope = "member",
        Target = "NUnitTests.ExchangeVerificationBase.#testCandidateType")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "NUnitTests.ExchangeVerificationBase.#APIKey")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "NUnitTests.ExchangeVerificationBase.#ClientID")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "failure", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "failure", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "failure", Scope = "member",
        Target = "NUnitTests.ExchangeExceptionVerification.#MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTC", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTC", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_LTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRK", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_DRK_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKBTC_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKUSD_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCBTC_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCUSD_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "BEx.Tests.BitfinexExceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target =
            "BEx.Tests.BitfinexExceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DRKUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCBTC",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LTCUSD",
        Scope = "member", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetOpenOrders_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTC", Scope = "member",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target =
            "BEx.Tests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#Constructor_MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target =
            "BEx.Tests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectClientID_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BTCUSD",
        Scope = "member", Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "BEx.Tests.ExchangeCommandVerification.#VerifyAPIResult(BEx.ApiResult)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "API", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "test", Scope = "member",
        Target = "BEx.Tests.ExchangeVerificationBase.#TestCandidate")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "test", Scope = "member",
        Target = "BEx.Tests.ExchangeVerificationBase.#testCandidateType")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetAccountBalance_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_LTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetDepositAddress_DRK_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetUserTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Authenticated_Commands.#GetOpenOrders_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "BEx.Tests.BitfinexExceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitfinexExceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "BEx.Tests.BitfinexExceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitfinexExceptions.#Constructor_MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "BEx.Tests.BitfinexExceptions.#AuthenticatedCommand_IncorrectSecretKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitfinexExceptions.#CreateSellOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitfinexExceptions.#CreateBuyOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTick_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetOrderBook_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_DRKUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCBTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitFinex_Unauthenticated_Commands.#GetTransactions_LTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetAccountBalance_All_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetOpenOrders_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetUserTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Authenticated_Commands.#GetDepositAddress_BTC_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "type",
        Target = "BEx.Tests.BitStamp_Exceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#Constructor_MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "BEx.Tests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#Constructor_MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "BEx.Tests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectSecretKey_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#Constructor_MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target =
            "BEx.Tests.BitStamp_Exceptions.#AuthenticatedCommand_IncorrectClientID_ExchangeAuthorizationException()"
        )]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#CreateSellOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStamp_Exceptions.#CreateBuyOrder_InsufficientFunds_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetTick_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetOrderBook_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.BitStampUnauthenticatedCommands.#GetTransactions_BTCUSD_Success()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#MissingAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#IncorrectAPIKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#MissingSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#IncorrectSecretKey_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#MissingClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#IncorrectClientID_ExchangeAuthorizationException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#CreateSellOrder_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member",
        Target = "BEx.Tests.ExchangeExceptionVerification.#CreateBuyOrder_InsufficientFundsException()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Finex",
        Scope = "type", Target = "BEx.Tests.BitFinex_Authenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Bitfinex",
        Scope = "type", Target = "BEx.Tests.BitfinexExceptions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Finex",
        Scope = "type", Target = "BEx.Tests.BitFinex_Unauthenticated_Commands")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api",
        Scope = "member", Target = "BEx.Tests.ExchangeVerificationBase.#ApiKey")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
        Target = "BEx.Tests.ExchangeCommandVerification.#VerifyAPIResult(BEx.ApiResult)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
        Target = "BEx.Tests.ExchangeVerificationBase.#.ctor(BEx.Exchange)")]