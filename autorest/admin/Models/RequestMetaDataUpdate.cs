// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Admin.Models
{
    /// <summary> The RequestMetaDataUpdate. </summary>
    public partial class RequestMetaDataUpdate
    {
        /// <summary> Initializes a new instance of RequestMetaDataUpdate. </summary>
        /// <param name="data"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public RequestMetaDataUpdate(RequestMetaDataUpdateData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        public RequestMetaDataUpdateData Data { get; }
        /// <summary> Any object. </summary>
        public object Meta { get; set; }
    }
}
