// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The ErrorListResponse. </summary>
    internal partial class ErrorListResponse
    {
        /// <summary> Initializes a new instance of ErrorListResponse. </summary>
        /// <param name="errors"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/> is null. </exception>
        internal ErrorListResponse(List<ErrorListResponseErrors> errors)
        {
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            Errors = errors;
        }

        /// <summary> Initializes a new instance of ErrorListResponse. </summary>
        /// <param name="errors"> . </param>
        internal ErrorListResponse(IReadOnlyList<ErrorListResponseErrors> errors)
        {
            Errors = errors;
        }

        public IReadOnlyList<ErrorListResponseErrors> Errors { get; }
    }
}