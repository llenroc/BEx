﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using System.Collections.Generic;
using RestSharp;
using BEx;

namespace BEx.ExchangeEngine
{
    internal class ExecutionEngine
    {
        private readonly RequestDispatcher dispatcher;

        private readonly ResultTranslation translator;

        // private ErrorHandler errorHandler;

        internal ExecutionEngine(Exchange targetExchange)
        {
            dispatcher = new RequestDispatcher(targetExchange);

            translator = new ResultTranslation(targetExchange);

            // errorHandler = new ErrorHandler(_sourceExchange.ExchangeSourceType);
        }

        public ApiResult ExecuteCommand(ExchangeCommand toExecute, CurrencyTradingPair pair, Dictionary<StandardParameter, string> paramCollection = null)
        {
            return ExecutionPipeline(toExecute, pair, paramCollection);
        }

        private ApiResult ExecutionPipeline(
                                        ExchangeCommand toExecute,
                                        CurrencyTradingPair pair,
                                        Dictionary<StandardParameter, string> paramCollection = null)
        {
            IRestRequest request = RequestFactory.GetRequest(toExecute, pair, paramCollection);

            IRestResponse result = dispatcher.Dispatch(request, toExecute);

            ApiResult res = translator.Translate(
                                    result.Content,
                                    toExecute,
                                    pair);

            // Error Handling!

            return res;
        }
    }
}