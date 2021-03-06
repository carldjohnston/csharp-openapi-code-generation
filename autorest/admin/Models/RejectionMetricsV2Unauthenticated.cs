// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Agl.Cdr.Admin.Models
{
    /// <summary> Rejection counts for all uauthenticated end points. </summary>
    public partial class RejectionMetricsV2Unauthenticated
    {
        /// <summary> Initializes a new instance of RejectionMetricsV2Unauthenticated. </summary>
        internal RejectionMetricsV2Unauthenticated()
        {
            PreviousDays = new List<float>();
        }

        /// <summary> Initializes a new instance of RejectionMetricsV2Unauthenticated. </summary>
        /// <param name="currentDay"> Number of calls rejected for current day. </param>
        /// <param name="previousDays"> Number of calls rejected for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </param>
        internal RejectionMetricsV2Unauthenticated(float? currentDay, IReadOnlyList<float> previousDays)
        {
            CurrentDay = currentDay;
            PreviousDays = previousDays;
        }

        /// <summary> Number of calls rejected for current day. </summary>
        public float? CurrentDay { get; }
        /// <summary> Number of calls rejected for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </summary>
        public IReadOnlyList<float> PreviousDays { get; }
    }
}
