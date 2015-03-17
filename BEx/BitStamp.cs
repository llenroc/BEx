﻿using BEx.ExchangeSupport.BitStampSupport;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BEx
{
    public sealed class BitStamp : Exchange
    {
        private Regex errorId;

        public BitStamp()
            : base(new BitStampConfiguration(), new BitStampCommandFactory(), ExchangeType.BitStamp)
        {
            Authenticator = new BitStampAuthenticator(Configuration);
        }

        public BitStamp(BitStampConfiguration configuration)
            : base(configuration, new BitStampCommandFactory(), ExchangeType.BitStamp)
        {
            Authenticator = new BitStampAuthenticator(Configuration);
        }

        public BitStamp(string apiKey, string secretKey, string clientId)
            : base(new BitStampConfiguration(apiKey, clientId, secretKey), new BitStampCommandFactory(), ExchangeType.BitStamp)
        {
            VerifyCredentials(apiKey, secretKey, clientId);
            Authenticator = new BitStampAuthenticator(Configuration);

            errorId = new Regex("^{\"error\":");// \"API key not found\"}");
        }

        protected internal override APIError DetermineErrorCondition(string message)
        {
            if (IsError(message))
            {
                APIError error = null;

                string errorMessage = ExtractMessage(message);

                string loweredMessage = errorMessage.ToLower();
                if (loweredMessage.Contains("check your account balance for details"))
                {
                    error = new APIError(errorMessage, BExErrorCode.InsufficientFunds, ExchangeType.BitStamp);
                }
                else if (loweredMessage.Contains("api key not found") || loweredMessage.Contains("invalid signature"))
                {
                    error = new APIError(errorMessage, BExErrorCode.Authorization, ExchangeType.BitStamp);
                }

                if (error == null)
                {
                    error = new APIError(message, BExErrorCode.Unknown, ExchangeType.BitStamp);
                }

                return error;
            }
            else return null;
        }

        internal string ExtractMessage(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                StringBuilder res = new StringBuilder();
                // this works for auth errors
                JObject error = JObject.Parse(content);

                // for other errors

                try
                {
                    if (error["error"] is JValue)
                    {
                        JValue v = (JValue)error["error"];

                        res.Append(v.Value.ToString());
                    }
                    else
                    {
                        IDictionary<string, JToken> errors = (JObject)error["error"];

                        foreach (KeyValuePair<string, JToken> er in errors)
                        {
                            foreach (JToken token in er.Value.Values())
                            {
                                res.Append(((JValue)token).Value.ToString());
                            }

                            //res.Append(er.Value.ToString().Replace("{\"error\":", "").Replace("{\"__all__\": [\"", "").Replace("\"]}}", "").Replace("[", "").Replace("]", "").Replace("\"", "").Trim());
                        }
                    }
                }
                catch (Exception)
                {
                    res.Append(error.ToString());
                }

                return res.ToString();//Regex.Replace(res.ToString(), @"\t|\n|\r", "");
            }
            else
                return "The Error response was empty";
        }

        protected internal override bool IsError(string content)
        {
            bool res = false;

            if (errorId.IsMatch(content))
            {
                res = true;
            }

            return res;
        }

        private void VerifyCredentials(string apiKey, string secretKey, string clientId)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new ExchangeAuthorizationException("Invalid APIKey specified.");

            if (string.IsNullOrEmpty(secretKey))
                throw new ExchangeAuthorizationException("Invalid SecretKey specified.");

            if (string.IsNullOrEmpty(clientId))
                throw new ExchangeAuthorizationException("Invalid ClientId specified.");
        }
    }
}