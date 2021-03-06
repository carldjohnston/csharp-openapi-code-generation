// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The ResponseErrorListV2. </summary>
    internal partial class ResponseErrorListV2
    {
        /// <summary> Initializes a new instance of ResponseErrorListV2. </summary>
        /// <param name="errors"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/> is null. </exception>
        internal ResponseErrorListV2(List<ResponseErrorListV2Errors> errors)
        {
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            Errors = errors;
        }

        /// <summary> Initializes a new instance of ResponseErrorListV2. </summary>
        /// <param name="errors"> . </param>
        internal ResponseErrorListV2(IReadOnlyList<ResponseErrorListV2Errors> errors)
        {
            Errors = errors;
        }

        public IReadOnlyList<ResponseErrorListV2Errors> Errors { get; }
    }
}
