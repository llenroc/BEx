﻿using RestSharp;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BEx.ExchangeSupport.BitStampSupport
{
    internal class BitStampAuthenticator : IAuthenticator
    {
        public static HMACSHA256 Hasher;

        private IExchangeConfiguration Configuration;

        public BitStampAuthenticator(IExchangeConfiguration configuration)
        {
            Configuration = configuration;
            Validate();
            Hasher = new HMACSHA256(Encoding.ASCII.GetBytes(Configuration.SecretKey));
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(Configuration.ApiKey))
                throw new ExchangeAuthorizationException("Invalid APIKey specified.");

            if (string.IsNullOrEmpty(Configuration.SecretKey))
                throw new ExchangeAuthorizationException("Invalid SecretKey specified.");

            if (string.IsNullOrEmpty(Configuration.ClientId))
                throw new ExchangeAuthorizationException("Invalid ClientId specified.");
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            long currentNonce = Configuration.Nonce;

            string message = string.Format("{0}{1}{2}", currentNonce, Configuration.ClientId, Configuration.ApiKey);

            byte[] dta = Encoding.ASCII.GetBytes(message);
            string signature = BitConverter.ToString(Hasher.ComputeHash(dta)).Replace("-", "").ToUpper();

            request.AddParameter("key", Uri.EscapeUriString(Configuration.ApiKey));
            request.AddParameter("signature", Uri.EscapeUriString(signature));
            request.AddParameter("nonce", Uri.EscapeUriString(currentNonce.ToString()));
        }
    }
}