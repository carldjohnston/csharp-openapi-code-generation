// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyBalanceResponseData. </summary>
    public partial class EnergyBalanceResponseData
    {
        /// <summary> Initializes a new instance of EnergyBalanceResponseData. </summary>
        /// <param name="balance"> The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="balance"/> is null. </exception>
        internal EnergyBalanceResponseData(string balance)
        {
            if (balance == null)
            {
                throw new ArgumentNullException(nameof(balance));
            }

            Balance = balance;
        }

        /// <summary> The current balance of the account.  A positive value indicates that amount is owing to be paid.  A negative value indicates that the account is in credit. </summary>
        public string Balance { get; }
    }
}
