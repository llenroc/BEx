﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace BEx.Exceptions
{
    [Serializable]
    public class LimitOrderRejectedException : Exception
    {
        public LimitOrderRejectedException(string message)
            : base(message)
        {
        }

        public LimitOrderRejectedException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected LimitOrderRejectedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}