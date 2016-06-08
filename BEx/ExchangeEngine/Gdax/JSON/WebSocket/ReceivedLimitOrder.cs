﻿using System;

namespace BEx.ExchangeEngine.Gdax.JSON.WebSocket
{
    public class ReceivedLimitOrder
    {
        public string order_id { get; set; }
        public string order_type { get; set; }
        public string price { get; set; }
        public string product_id { get; set; }
        public int sequence { get; set; }
        public string side { get; set; }
        public string size { get; set; }
        public DateTime time { get; set; }
        public string type { get; set; }
    }
}