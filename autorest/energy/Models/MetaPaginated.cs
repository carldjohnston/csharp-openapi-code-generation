// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The MetaPaginated. </summary>
    public partial class MetaPaginated
    {
        /// <summary> Initializes a new instance of MetaPaginated. </summary>
        /// <param name="totalRecords"> The total number of records in the full set. See [pagination](#pagination). </param>
        /// <param name="totalPages"> The total number of pages in the full set. See [pagination](#pagination). </param>
        internal MetaPaginated(int totalRecords, int totalPages)
        {
            TotalRecords = totalRecords;
            TotalPages = totalPages;
        }

        /// <summary> The total number of records in the full set. See [pagination](#pagination). </summary>
        public int TotalRecords { get; }
        /// <summary> The total number of pages in the full set. See [pagination](#pagination). </summary>
        public int TotalPages { get; }
    }
}
