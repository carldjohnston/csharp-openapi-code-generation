// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyBalanceListResponseData. </summary>
    public partial class EnergyBalanceListResponseData
    {
        /// <summary> Initializes a new instance of EnergyBalanceListResponseData. </summary>
        /// <param name="balances"> Array of account balances. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="balances"/> is null. </exception>
        internal EnergyBalanceListResponseData(List<EnergyBalanceListResponseDataBalances> balances)
        {
            if (balances == null)
            {
                throw new ArgumentNullException(nameof(balances));
            }

            Balances = balances;
        }

        /// <summary> Initializes a new instance of EnergyBalanceListResponseData. </summary>
        /// <param name="balances"> Array of account balances. </param>
        internal EnergyBalanceListResponseData(IReadOnlyList<EnergyBalanceListResponseDataBalances> balances)
        {
            Balances = balances;
        }

        /// <summary> Array of account balances. </summary>
        public IReadOnlyList<EnergyBalanceListResponseDataBalances> Balances { get; }
    }
}