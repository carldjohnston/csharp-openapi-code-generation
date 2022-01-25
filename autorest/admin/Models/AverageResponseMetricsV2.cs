// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Admin.Models
{
    /// <summary> Average response time in seconds, at millisecond resolution, within each performance tier. </summary>
    public partial class AverageResponseMetricsV2
    {
        /// <summary> Initializes a new instance of AverageResponseMetricsV2. </summary>
        /// <param name="unauthenticated"> Average response time for the unauthenticated tier. </param>
        /// <param name="highPriority"> Average response time for the high priority tier. </param>
        /// <param name="lowPriority"> Average response time for the low priority tier. </param>
        /// <param name="unattended"> Average response time for the unattended tier. </param>
        /// <param name="largePayload"> Average response time for the large payload tier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="unauthenticated"/>, <paramref name="highPriority"/>, <paramref name="lowPriority"/>, <paramref name="unattended"/>, or <paramref name="largePayload"/> is null. </exception>
        internal AverageResponseMetricsV2(AverageResponseMetricsV2Unauthenticated unauthenticated, AverageResponseMetricsV2HighPriority highPriority, AverageResponseMetricsV2LowPriority lowPriority, AverageResponseMetricsV2Unattended unattended, AverageResponseMetricsV2LargePayload largePayload)
        {
            if (unauthenticated == null)
            {
                throw new ArgumentNullException(nameof(unauthenticated));
            }
            if (highPriority == null)
            {
                throw new ArgumentNullException(nameof(highPriority));
            }
            if (lowPriority == null)
            {
                throw new ArgumentNullException(nameof(lowPriority));
            }
            if (unattended == null)
            {
                throw new ArgumentNullException(nameof(unattended));
            }
            if (largePayload == null)
            {
                throw new ArgumentNullException(nameof(largePayload));
            }

            Unauthenticated = unauthenticated;
            HighPriority = highPriority;
            LowPriority = lowPriority;
            Unattended = unattended;
            LargePayload = largePayload;
        }

        /// <summary> Initializes a new instance of AverageResponseMetricsV2. </summary>
        /// <param name="unauthenticated"> Average response time for the unauthenticated tier. </param>
        /// <param name="highPriority"> Average response time for the high priority tier. </param>
        /// <param name="lowPriority"> Average response time for the low priority tier. </param>
        /// <param name="unattended"> Average response time for the unattended tier. </param>
        /// <param name="largePayload"> Average response time for the large payload tier. </param>
        /// <param name="secondary"> Average response time for the secondary tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster. </param>
        /// <param name="largeSecondary"> Average response time for the large payload tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster. </param>
        internal AverageResponseMetricsV2(AverageResponseMetricsV2Unauthenticated unauthenticated, AverageResponseMetricsV2HighPriority highPriority, AverageResponseMetricsV2LowPriority lowPriority, AverageResponseMetricsV2Unattended unattended, AverageResponseMetricsV2LargePayload largePayload, AverageResponseMetricsV2SecondaryRef secondary, AverageResponseMetricsV2LargeSecondary largeSecondary)
        {
            Unauthenticated = unauthenticated;
            HighPriority = highPriority;
            LowPriority = lowPriority;
            Unattended = unattended;
            LargePayload = largePayload;
            Secondary = secondary;
            LargeSecondary = largeSecondary;
        }

        /// <summary> Average response time for the unauthenticated tier. </summary>
        public AverageResponseMetricsV2Unauthenticated Unauthenticated { get; }
        /// <summary> Average response time for the high priority tier. </summary>
        public AverageResponseMetricsV2HighPriority HighPriority { get; }
        /// <summary> Average response time for the low priority tier. </summary>
        public AverageResponseMetricsV2LowPriority LowPriority { get; }
        /// <summary> Average response time for the unattended tier. </summary>
        public AverageResponseMetricsV2Unattended Unattended { get; }
        /// <summary> Average response time for the large payload tier. </summary>
        public AverageResponseMetricsV2LargePayload LargePayload { get; }
        /// <summary> Average response time for the secondary tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster. </summary>
        public AverageResponseMetricsV2SecondaryRef Secondary { get; }
        /// <summary> Average response time for the large payload tier.  Mandatory for data holders designated for a Shared Responsibility Data Request data cluster. </summary>
        public AverageResponseMetricsV2LargeSecondary LargeSecondary { get; }
    }
}
