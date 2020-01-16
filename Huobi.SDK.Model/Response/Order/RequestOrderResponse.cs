﻿using Newtonsoft.Json;

namespace Huobi.SDK.Model.Response.Order
{
    /// <summary>
    /// RequestOrder response
    /// </summary>
    public class RequestOrderResponse
    {
        /// <summary>
        /// Operation
        /// </summary>
        public string op;

        /// <summary>
        /// Timestamp
        /// </summary>
        public long ts;

        /// <summary>
        /// Topic
        /// </summary>
        public string topic;

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("err-code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode;

        /// <summary>
        /// Client id
        /// </summary>
        public string cid;

        /// <summary>
        /// Response body
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Order data;

        /// <summary>
        /// Order
        /// </summary>
        public class Order
        {
            /// <summary>
            /// The account id
            /// </summary>
            [JsonProperty("account-id")]
            public int accountId;

            /// <summary>
            /// The order size
            /// </summary>
            public string amount;

            /// <summary>
            /// Order id
            /// </summary>
            public long id;

            /// <summary>
            /// Trading symbol
            /// </summary>
            public string symbol;

            /// <summary>
            /// The limit price of limit order
            /// </summary>
            public string price;

            /// <summary>
            /// The timestamp in milliseconds when the order was created
            /// </summary>
            [JsonProperty("created-at")]
            public long createdAt;

            /// <summary>
            /// The order type
            /// Possible values: [buy-market, sell-market, buy-limit, sell-limit,
            ///         buy-ioc, sell-ioc, buy-limit-maker, sell-limit-maker,
            ///         buy-stop-limit, sell-stop-limit]
            /// </summary>
            public string type;

            /// <summary>
            /// The amount which has been filled
            /// </summary>
            [JsonProperty("filled-amount")]
            public string filledAmount;

            /// <summary>
            /// The filled total in quote currency
            /// </summary>
            [JsonProperty("filled-cash-amount")]
            public string filledCashAmount;

            /// <summary>
            /// Transaction fee paid so far
            /// </summary>
            [JsonProperty("filled-fees")]
            public string filledFees;

            /// <summary>
            /// The source where the order was triggered
            /// Possible values: [sys, web, api, app]
            /// </summary>
            public string source;

            /// <summary>
            /// The orders state
            /// Possible values: [submitted, partial-filled, cancelling, created]
            /// </summary>
            public string state;
        }
    }
}