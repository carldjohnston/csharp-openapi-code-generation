// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The ResponseCommonCustomerDetailV2. </summary>
    public partial class ResponseCommonCustomerDetailV2
    {
        /// <summary> Initializes a new instance of ResponseCommonCustomerDetailV2. </summary>
        /// <param name="data"> . </param>
        /// <param name="links"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> or <paramref name="links"/> is null. </exception>
        internal ResponseCommonCustomerDetailV2(ResponseCommonCustomerDetailV2Data data, Links links)
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

        /// <summary> Initializes a new instance of ResponseCommonCustomerDetailV2. </summary>
        /// <param name="data"> . </param>
        /// <param name="links"> . </param>
        /// <param name="meta"> Any object. </param>
        internal ResponseCommonCustomerDetailV2(ResponseCommonCustomerDetailV2Data data, Links links, object meta)
        {
            Data = data;
            Links = links;
            Meta = meta;
        }

        public ResponseCommonCustomerDetailV2Data Data { get; }
        public Links Links { get; }
        /// <summary> Any object. </summary>
        public object Meta { get; }
    }
}
