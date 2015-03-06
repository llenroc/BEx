﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BEx
{
    internal delegate APIError DetermineErrorConditionDelegate(string content);

    internal delegate bool IsErrorDelegate(string content);

    internal class RequestDispatcher
    {
        internal DetermineErrorConditionDelegate DetermineErrorCondition;
        internal IsErrorDelegate IsError;
        private Regex ErrorMessageRegex;
        private ExchangeType SourceExchangeType;

        internal RequestDispatcher(Exchange sourceExchange)
        {
            apiClient = new RestClient(sourceExchange.BaseURI.ToString());
            SourceExchangeType = sourceExchange.ExchangeSourceType;
            ErrorMessageRegex = new Regex("\"error\"");
        }

        private RestClient apiClient
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="J">Intermediate type</typeparam>
        /// <typeparam name="E">Expected return type</typeparam>
        /// <param name="request"></param>
        /// <param name="commandReference"></param>
        /// <param name="baseCurrency"></param>
        /// <param name="counterCurrency"></param>
        /// <returns></returns>
        internal object ExecuteCommand<J, E>(RestRequest request, APICommand commandReference, CurrencyTradingPair pair)
        {
            IRestResponse response;
            object result = null;

            response = apiClient.Execute(request);

            bool responseIsError = false;
            if (IsError != null)
            {
                responseIsError = IsError(response.Content);
            }

            if (response.ErrorException != null || response.StatusCode != HttpStatusCode.OK || responseIsError)
            {
                return HandlerErrorResponse(response, request, commandReference, response.ErrorException);
            }
            else
            {
                try
                {
                    if (!commandReference.ReturnsValueType)
                    {
                        result = (APIResult)DeserializeObject<J, E>(response.Content, commandReference, pair);
                    }
                    else
                        result = GetValueType<J, E>(response.Content);
                }
                catch (Exception ex)
                {
                    HandlerErrorResponse(response, request, commandReference, ex);
                }
            }

            return result;
        }

        private APIResult DeserializeObject<J, E>(string content, APICommand commandReference, CurrencyTradingPair pair)
        {
            APIResult res = default(APIResult);

            dynamic deserialized = JsonConvert.DeserializeObject<J>(content);

            MethodInfo conversionMethod = deserialized.GetType().GetMethod("ConvertToStandard");

            if (conversionMethod == null)
            {
                // Json Type
                Type baseT = ListOfWhat(deserialized);

                // Get Method from ExchangeResponse
                conversionMethod = baseT.BaseType.GetMethod("ConvertListToStandard");

                MethodInfo singleConversionMethod = baseT.GetMethod("ConvertToStandard");

                Type entryType = singleConversionMethod.ReturnType;

                MethodInfo generic = conversionMethod.MakeGenericMethod(baseT, entryType);

                dynamic collection = generic.Invoke(this, new object[] { deserialized, pair });

                res = (APIResult)Activator.CreateInstance(typeof(E),
                                                            BindingFlags.NonPublic | BindingFlags.Instance,
                                                            null,
                                                            new object[] { collection, pair, SourceExchangeType },
                                                            null); // Culture?
            }
            else
                res = (APIResult)conversionMethod.Invoke(deserialized, new object[] { pair });

            return res;
        }

        private object GetValueType<J, E>(string content)
        {
            object deserialized = JsonConvert.DeserializeObject<J>(content);

            if (deserialized.GetType() != typeof(E))
            {
                E result = (E)Activator.CreateInstance(typeof(E),
                                              BindingFlags.NonPublic | BindingFlags.Instance,
                                              null,
                                              new object[] { deserialized, SourceExchangeType },
                                              null); // Culture?

                return result;
            }
            else
            {
                return deserialized;
            }
        }

        private APIError HandlerErrorResponse(IRestResponse response, RestRequest request, APICommand executedCommand, Exception inner = null)
        {
            APIError error = null;
            if (DetermineErrorCondition != null)
            {
                error = DetermineErrorCondition(response.Content);
            }

            if (error == null)
            {
                error = new APIError(SourceExchangeType);
                error.Message = response.Content;
            }

            error.HttpStatus = (HttpResponseCode)(int)response.StatusCode;

            if (error.ErrorCode == BExErrorCode.InsufficientFunds)
                ThrowException<InsufficientFundsException>(error);
            else if (error.ErrorCode == BExErrorCode.Authorization)
                ThrowException<ExchangeAuthorizationException>(error);

            return error;
        }

        private Type ListOfWhat(Object list)
        {
            return ListOfWhat2((dynamic)list);
        }

        private Type ListOfWhat2<T>(IList<T> list)
        {
            return typeof(T);
        }

        private void ThrowException<E>(APIError source) where E : Exception
        {
            E exception = (E)Activator.CreateInstance(typeof(E),
                                                    BindingFlags.Public | BindingFlags.Instance,
                                                    null,
                                                    new object[] { source.Message },
                                                    null);

            ((Exception)exception).Data.Add("BExError", source);

            throw exception;
        }
    }
}