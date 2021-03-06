// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Agl.Cdr.Common;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The CommonPhysicalAddress. </summary>
    public partial class CommonPhysicalAddress
    {
        /// <summary> Initializes a new instance of CommonPhysicalAddress. </summary>
        /// <param name="addressUType"> The type of address object present. </param>
        internal CommonPhysicalAddress(CommonPhysicalAddressUType addressUType)
        {
            AddressUType = addressUType;
        }

        /// <summary> Initializes a new instance of CommonPhysicalAddress. </summary>
        /// <param name="addressUType"> The type of address object present. </param>
        /// <param name="simple"> . </param>
        /// <param name="paf"> Australian address formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). </param>
        internal CommonPhysicalAddress(CommonPhysicalAddressUType addressUType, CommonSimpleAddress simple, CommonPAFAddress paf)
        {
            AddressUType = addressUType;
            Simple = simple;
            Paf = paf;
        }

        /// <summary> The type of address object present. </summary>
        public CommonPhysicalAddressUType AddressUType { get; }
        public CommonSimpleAddress Simple { get; }
        /// <summary> Australian address formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). </summary>
        public CommonPAFAddress Paf { get; }
    }
}
