// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The DiscoveryOutage. </summary>
    public partial class DiscoveryOutage
    {
        /// <summary> Initializes a new instance of DiscoveryOutage. </summary>
        /// <param name="outageTime"> Date and time that the outage is scheduled to begin. </param>
        /// <param name="duration"> Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </param>
        /// <param name="explanation"> Provides an explanation of the current outage that can be displayed to an end customer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outageTime"/>, <paramref name="duration"/>, or <paramref name="explanation"/> is null. </exception>
        internal DiscoveryOutage(string outageTime, string duration, string explanation)
        {
            if (outageTime == null)
            {
                throw new ArgumentNullException(nameof(outageTime));
            }
            if (duration == null)
            {
                throw new ArgumentNullException(nameof(duration));
            }
            if (explanation == null)
            {
                throw new ArgumentNullException(nameof(explanation));
            }

            OutageTime = outageTime;
            Duration = duration;
            Explanation = explanation;
        }

        /// <summary> Initializes a new instance of DiscoveryOutage. </summary>
        /// <param name="outageTime"> Date and time that the outage is scheduled to begin. </param>
        /// <param name="duration"> Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </param>
        /// <param name="isPartial"> Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage. </param>
        /// <param name="explanation"> Provides an explanation of the current outage that can be displayed to an end customer. </param>
        internal DiscoveryOutage(string outageTime, string duration, bool? isPartial, string explanation)
        {
            OutageTime = outageTime;
            Duration = duration;
            IsPartial = isPartial;
            Explanation = explanation;
        }

        /// <summary> Date and time that the outage is scheduled to begin. </summary>
        public string OutageTime { get; }
        /// <summary> Planned duration of the outage. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </summary>
        public string Duration { get; }
        /// <summary> Flag that indicates, if present and set to true, that the outage is only partial meaning that only a subset of normally available end points will be affected by the outage. </summary>
        public bool? IsPartial { get; }
        /// <summary> Provides an explanation of the current outage that can be displayed to an end customer. </summary>
        public string Explanation { get; }
    }
}
