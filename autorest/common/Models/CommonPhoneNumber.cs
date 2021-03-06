// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Agl.Cdr.Common;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The CommonPhoneNumber. </summary>
    public partial class CommonPhoneNumber
    {
        /// <summary> Initializes a new instance of CommonPhoneNumber. </summary>
        /// <param name="purpose"> The purpose of the number as specified by the customer. </param>
        /// <param name="number"> The actual phone number, with leading zeros as appropriate. </param>
        /// <param name="fullNumber"> Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of [RFC 3966](https://www.ietf.org/rfc/rfc3966.txt). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="number"/> or <paramref name="fullNumber"/> is null. </exception>
        internal CommonPhoneNumber(CommonPhoneNumberPurpose purpose, string number, string fullNumber)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            if (fullNumber == null)
            {
                throw new ArgumentNullException(nameof(fullNumber));
            }

            Purpose = purpose;
            Number = number;
            FullNumber = fullNumber;
        }

        /// <summary> Initializes a new instance of CommonPhoneNumber. </summary>
        /// <param name="isPreferred"> May be true for one and only one entry to indicate the preferred phone number. Assumed to be &apos;false&apos; if not present. </param>
        /// <param name="purpose"> The purpose of the number as specified by the customer. </param>
        /// <param name="countryCode"> If absent, assumed to be Australia (+61). The + should be included. </param>
        /// <param name="areaCode"> Required for non Mobile Phones, if field is present and refers to Australian code - the leading 0 should be omitted. </param>
        /// <param name="number"> The actual phone number, with leading zeros as appropriate. </param>
        /// <param name="extension"> An extension number (if applicable). </param>
        /// <param name="fullNumber"> Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of [RFC 3966](https://www.ietf.org/rfc/rfc3966.txt). </param>
        internal CommonPhoneNumber(bool? isPreferred, CommonPhoneNumberPurpose purpose, string countryCode, string areaCode, string number, string extension, string fullNumber)
        {
            IsPreferred = isPreferred;
            Purpose = purpose;
            CountryCode = countryCode;
            AreaCode = areaCode;
            Number = number;
            Extension = extension;
            FullNumber = fullNumber;
        }

        /// <summary> May be true for one and only one entry to indicate the preferred phone number. Assumed to be &apos;false&apos; if not present. </summary>
        public bool? IsPreferred { get; }
        /// <summary> The purpose of the number as specified by the customer. </summary>
        public CommonPhoneNumberPurpose Purpose { get; }
        /// <summary> If absent, assumed to be Australia (+61). The + should be included. </summary>
        public string CountryCode { get; }
        /// <summary> Required for non Mobile Phones, if field is present and refers to Australian code - the leading 0 should be omitted. </summary>
        public string AreaCode { get; }
        /// <summary> The actual phone number, with leading zeros as appropriate. </summary>
        public string Number { get; }
        /// <summary> An extension number (if applicable). </summary>
        public string Extension { get; }
        /// <summary> Fully formatted phone number with country code, area code, number and extension incorporated. Formatted according to section 5.1.4. of [RFC 3966](https://www.ietf.org/rfc/rfc3966.txt). </summary>
        public string FullNumber { get; }
    }
}
