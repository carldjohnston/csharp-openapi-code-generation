// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Agl.Cdr.Admin.Models
{
    /// <summary> Number of calls resulting in error due to server execution over time. </summary>
    public partial class SecondaryHolderMetricsErrors
    {
        /// <summary> Initializes a new instance of SecondaryHolderMetricsErrors. </summary>
        internal SecondaryHolderMetricsErrors()
        {
            PreviousDays = new List<float>();
        }

        /// <summary> Initializes a new instance of SecondaryHolderMetricsErrors. </summary>
        /// <param name="currentDay"> Number of errors for current day. </param>
        /// <param name="previousDays"> Number of errors for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </param>
        internal SecondaryHolderMetricsErrors(float? currentDay, IReadOnlyList<float> previousDays)
        {
            CurrentDay = currentDay;
            PreviousDays = previousDays;
        }

        /// <summary> Number of errors for current day. </summary>
        public float? CurrentDay { get; }
        /// <summary> Number of errors for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </summary>
        public IReadOnlyList<float> PreviousDays { get; }
    }
}
