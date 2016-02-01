﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEx.ExchangeEngine;
using BEx.ExchangeEngine.Coinbase;

namespace BEx
{
    public sealed class Coinbase : Exchange
    {
        public Coinbase()
                : base(Configuration.Singleton,
                      CommandFactory.Singleton)
        {
        }

        public Coinbase(string apiKey)
                : base(Configuration.Singleton, CommandFactory.Singleton, null)
        {
        }
    }
}
