// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Agl.Cdr.Common.Models
{
    /// <summary> Session counts over time. Note that a session is defined as the provisioning of an Access Token. </summary>
    public partial class SessionCountMetrics
    {
        /// <summary> Initializes a new instance of SessionCountMetrics. </summary>
        internal SessionCountMetrics()
        {
            PreviousDays = new List<float>();
        }

        /// <summary> Initializes a new instance of SessionCountMetrics. </summary>
        /// <param name="currentDay"> Session count for current day. </param>
        /// <param name="previousDays"> Session count for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </param>
        internal SessionCountMetrics(float? currentDay, IReadOnlyList<float> previousDays)
        {
            CurrentDay = currentDay;
            PreviousDays = previousDays;
        }

        /// <summary> Session count for current day. </summary>
        public float? CurrentDay { get; }
        /// <summary> Session count for previous days. The first element indicates yesterday and so on. A maximum of seven entries is required if available. </summary>
        public IReadOnlyList<float> PreviousDays { get; }
    }
}