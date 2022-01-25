// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Agl.Cdr.Admin.Models
{
    /// <summary> API call counts for the large payload tier. </summary>
    public partial class InvocationMetricsV2LargePayload
    {
        /// <summary> Initializes a new instance of InvocationMetricsV2LargePayload. </summary>
        internal InvocationMetricsV2LargePayload()
        {
            PreviousDays = new List<float>();
        }

        /// <summary> Initializes a new instance of InvocationMetricsV2LargePayload. </summary>
        /// <param name="currentDay"> API call counts for current day. </param>
        /// <param name="previousDays"> API call counts for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </param>
        internal InvocationMetricsV2LargePayload(float? currentDay, IReadOnlyList<float> previousDays)
        {
            CurrentDay = currentDay;
            PreviousDays = previousDays;
        }

        /// <summary> API call counts for current day. </summary>
        public float? CurrentDay { get; }
        /// <summary> API call counts for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </summary>
        public IReadOnlyList<float> PreviousDays { get; }
    }
}
