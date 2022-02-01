// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyAccountListResponseData. </summary>
    public partial class EnergyAccountListResponseData
    {
        /// <summary> Initializes a new instance of EnergyAccountListResponseData. </summary>
        /// <param name="accounts"> Array of accounts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accounts"/> is null. </exception>
        internal EnergyAccountListResponseData(List<EnergyAccount> accounts)
        {
            if (accounts == null)
            {
                throw new ArgumentNullException(nameof(accounts));
            }

            Accounts = accounts;
        }

        /// <summary> Initializes a new instance of EnergyAccountListResponseData. </summary>
        /// <param name="accounts"> Array of accounts. </param>
        internal EnergyAccountListResponseData(IReadOnlyList<EnergyAccount> accounts)
        {
            Accounts = accounts;
        }

        /// <summary> Array of accounts. </summary>
        public IReadOnlyList<EnergyAccount> Accounts { get; }
    }
}
