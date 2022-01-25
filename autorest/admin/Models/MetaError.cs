// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Agl.Cdr.Admin.Models
{
    /// <summary> Additional data for customised error codes. </summary>
    internal partial class MetaError
    {
        /// <summary> Initializes a new instance of MetaError. </summary>
        internal MetaError()
        {
        }

        /// <summary> Initializes a new instance of MetaError. </summary>
        /// <param name="urn"> The CDR error code URN which the application-specific error code extends. Mandatory if the error `code` is an application-specific error rather than a standardised error code. </param>
        internal MetaError(string urn)
        {
            Urn = urn;
        }

        /// <summary> The CDR error code URN which the application-specific error code extends. Mandatory if the error `code` is an application-specific error rather than a standardised error code. </summary>
        public string Urn { get; }
    }
}
