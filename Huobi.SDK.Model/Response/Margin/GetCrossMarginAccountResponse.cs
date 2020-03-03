﻿using Newtonsoft.Json;

namespace Huobi.SDK.Model.Response.Margin
{
    /// <summary>
    /// GetCrossMarginAccount response
    /// </summary>
    public class GetCrossMarginAccountResponse
    {
        /// <summary>
        /// Response status
        /// </summary>
        public string status;

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("err-code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode;

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("err-msg", NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage;

        /// <summary>
        /// Response body
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Account data;

        /// <summary>
        /// Loan info
        /// </summary>
        public class Account
        {
            /// <summary>
            /// Account id
            /// </summary>
            public int id;

            /// <summary>
            /// Account type: cross-margin
            /// </summary>
            public string type;

            /// <summary>
            /// Loan state
            /// Possible values: [created, accrual, cleared, invalid]
            /// </summary>
            public string state;
            
            /// <summary>
            /// Sum of all account balance
            /// </summary>
            [JsonProperty("acct-balance-sum")]
            public string AcctBalanceSum;

            /// <summary>
            /// Sum of all debt balance
            /// </summary>
            [JsonProperty("debt-balance-sum")]
            public string DebtBalanceSum;

            /// <summary>
            /// The list of margin accounts and their details
            /// </summary>
            public AccountDetail[] list;

            /// <summary>
            /// Currency detail
            /// </summary>
            public class AccountDetail
            {
                /// <summary>
                /// The currency of this balance
                /// </summary>
                public string currency;

                /// <summary>
                /// The balance type
                /// </summary>
                public string type;

                /// <summary>
                /// The balance in the main currency unit
                /// </summary>
                public string balance;
            }

        }
    }

}