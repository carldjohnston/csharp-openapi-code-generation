// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Agl.Cdr.Common.Models
{
    /// <summary> Average response time for the high priority tier. </summary>
    public partial class AverageResponseMetricsV2HighPriority
    {
        /// <summary> Initializes a new instance of AverageResponseMetricsV2HighPriority. </summary>
        internal AverageResponseMetricsV2HighPriority()
        {
            PreviousDays = new List<float>();
        }

        /// <summary> Initializes a new instance of AverageResponseMetricsV2HighPriority. </summary>
        /// <param name="currentDay"> Average response time for current day. </param>
        /// <param name="previousDays"> Average response time for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </param>
        internal AverageResponseMetricsV2HighPriority(float? currentDay, IReadOnlyList<float> previousDays)
        {
            CurrentDay = currentDay;
            PreviousDays = previousDays;
        }

        /// <summary> Average response time for current day. </summary>
        public float? CurrentDay { get; }
        /// <summary> Average response time for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </summary>
        public IReadOnlyList<float> PreviousDays { get; }
    }
}
