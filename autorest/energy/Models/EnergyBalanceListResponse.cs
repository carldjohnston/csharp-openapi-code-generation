// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyBalanceListResponse. </summary>
    public partial class EnergyBalanceListResponse
    {
        /// <summary> Initializes a new instance of EnergyBalanceListResponse. </summary>
        /// <param name="data"> . </param>
        /// <param name="links"> . </param>
        /// <param name="meta"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/>, <paramref name="links"/>, or <paramref name="meta"/> is null. </exception>
        internal EnergyBalanceListResponse(EnergyBalanceListResponseData data, LinksPaginated links, MetaPaginated meta)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (links == null)
            {
                throw new ArgumentNullException(nameof(links));
            }
            if (meta == null)
            {
                throw new ArgumentNullException(nameof(meta));
            }

            Data = data;
            Links = links;
            Meta = meta;
        }

        public EnergyBalanceListResponseData Data { get; }
        public LinksPaginated Links { get; }
        public MetaPaginated Meta { get; }
    }
}