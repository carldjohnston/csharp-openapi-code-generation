// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The ResponseDiscoveryOutagesListData. </summary>
    public partial class ResponseDiscoveryOutagesListData
    {
        /// <summary> Initializes a new instance of ResponseDiscoveryOutagesListData. </summary>
        /// <param name="outages"> List of scheduled outages. Property is mandatory but may contain and empty list if no outages are scheduled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outages"/> is null. </exception>
        internal ResponseDiscoveryOutagesListData(List<DiscoveryOutage> outages)
        {
            if (outages == null)
            {
                throw new ArgumentNullException(nameof(outages));
            }

            Outages = outages;
        }

        /// <summary> Initializes a new instance of ResponseDiscoveryOutagesListData. </summary>
        /// <param name="outages"> List of scheduled outages. Property is mandatory but may contain and empty list if no outages are scheduled. </param>
        internal ResponseDiscoveryOutagesListData(IReadOnlyList<DiscoveryOutage> outages)
        {
            Outages = outages;
        }

        /// <summary> List of scheduled outages. Property is mandatory but may contain and empty list if no outages are scheduled. </summary>
        public IReadOnlyList<DiscoveryOutage> Outages { get; }
    }
}