// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The ResponseCommonDiscoveryStatus. </summary>
    public partial class ResponseCommonDiscoveryStatus
    {
        /// <summary> Initializes a new instance of ResponseCommonDiscoveryStatus. </summary>
        /// <param name="data"> . </param>
        /// <param name="links"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> or <paramref name="links"/> is null. </exception>
        internal ResponseCommonDiscoveryStatus(ResponseCommonDiscoveryStatusData data, Links links)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (links == null)
            {
                throw new ArgumentNullException(nameof(links));
            }

            Data = data;
            Links = links;
        }

        /// <summary> Initializes a new instance of ResponseCommonDiscoveryStatus. </summary>
        /// <param name="data"> . </param>
        /// <param name="links"> . </param>
        /// <param name="meta"> Any object. </param>
        internal ResponseCommonDiscoveryStatus(ResponseCommonDiscoveryStatusData data, Links links, object meta)
        {
            Data = data;
            Links = links;
            Meta = meta;
        }

        public ResponseCommonDiscoveryStatusData Data { get; }
        public Links Links { get; }
        /// <summary> Any object. </summary>
        public object Meta { get; }
    }
}
