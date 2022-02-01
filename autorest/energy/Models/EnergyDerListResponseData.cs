// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyDerListResponseData. </summary>
    public partial class EnergyDerListResponseData
    {
        /// <summary> Initializes a new instance of EnergyDerListResponseData. </summary>
        /// <param name="derRecords"> Array of meter reads. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="derRecords"/> is null. </exception>
        internal EnergyDerListResponseData(List<EnergyDerRecord> derRecords)
        {
            if (derRecords == null)
            {
                throw new ArgumentNullException(nameof(derRecords));
            }

            DerRecords = derRecords;
        }

        /// <summary> Initializes a new instance of EnergyDerListResponseData. </summary>
        /// <param name="derRecords"> Array of meter reads. </param>
        internal EnergyDerListResponseData(IReadOnlyList<EnergyDerRecord> derRecords)
        {
            DerRecords = derRecords;
        }

        /// <summary> Array of meter reads. </summary>
        public IReadOnlyList<EnergyDerRecord> DerRecords { get; }
    }
}