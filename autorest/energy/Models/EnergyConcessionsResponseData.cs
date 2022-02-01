// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyConcessionsResponseData. </summary>
    public partial class EnergyConcessionsResponseData
    {
        /// <summary> Initializes a new instance of EnergyConcessionsResponseData. </summary>
        /// <param name="concessions"> Array may be empty if no concessions exist. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="concessions"/> is null. </exception>
        internal EnergyConcessionsResponseData(List<EnergyConcession> concessions)
        {
            if (concessions == null)
            {
                throw new ArgumentNullException(nameof(concessions));
            }

            Concessions = concessions;
        }

        /// <summary> Initializes a new instance of EnergyConcessionsResponseData. </summary>
        /// <param name="concessions"> Array may be empty if no concessions exist. </param>
        internal EnergyConcessionsResponseData(IReadOnlyList<EnergyConcession> concessions)
        {
            Concessions = concessions;
        }

        /// <summary> Array may be empty if no concessions exist. </summary>
        public IReadOnlyList<EnergyConcession> Concessions { get; }
    }
}
