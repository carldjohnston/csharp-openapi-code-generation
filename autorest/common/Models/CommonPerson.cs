// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Agl.Cdr.Common;

namespace Agl.Cdr.Common.Models
{
    /// <summary> The CommonPerson. </summary>
    public partial class CommonPerson
    {
        /// <summary> Initializes a new instance of CommonPerson. </summary>
        /// <param name="lastName"> For people with single names the single name should be in this field. </param>
        /// <param name="middleNames"> Field is mandatory but array may be empty. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lastName"/> or <paramref name="middleNames"/> is null. </exception>
        internal CommonPerson(string lastName, List<string> middleNames)
        {
            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            if (middleNames == null)
            {
                throw new ArgumentNullException(nameof(middleNames));
            }

            LastName = lastName;
            MiddleNames = middleNames;
        }

        /// <summary> Initializes a new instance of CommonPerson. </summary>
        /// <param name="lastUpdateTime"> The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data. </param>
        /// <param name="firstName"> For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided. </param>
        /// <param name="lastName"> For people with single names the single name should be in this field. </param>
        /// <param name="middleNames"> Field is mandatory but array may be empty. </param>
        /// <param name="prefix"> Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc). </param>
        /// <param name="suffix"> Used for a trailing suffix to the name (e.g. Jr). </param>
        /// <param name="occupationCode"> Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied. </param>
        /// <param name="occupationCodeVersion"> The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an ``occupationCode`` is supplied. If ``occupationCode`` is supplied but ``occupationCodeVersion`` is absent, default is ``ANZSCO_1220.0_2013_V1.2``. </param>
        internal CommonPerson(string lastUpdateTime, string firstName, string lastName, IReadOnlyList<string> middleNames, string prefix, string suffix, string occupationCode, CommonPersonOccupationCodeVersion? occupationCodeVersion)
        {
            LastUpdateTime = lastUpdateTime;
            FirstName = firstName;
            LastName = lastName;
            MiddleNames = middleNames;
            Prefix = prefix;
            Suffix = suffix;
            OccupationCode = occupationCode;
            OccupationCodeVersion = occupationCodeVersion;
        }

        /// <summary> The date and time that this record was last updated by the customer.  If no update has occurred then this date should reflect the initial creation date for the data. </summary>
        public string LastUpdateTime { get; }
        /// <summary> For people with single names this field need not be present. The single name should be in the lastName field. Where a data holder cannot determine first and middle names from a collection of given names, a single string representing all given names MAY be provided. </summary>
        public string FirstName { get; }
        /// <summary> For people with single names the single name should be in this field. </summary>
        public string LastName { get; }
        /// <summary> Field is mandatory but array may be empty. </summary>
        public IReadOnlyList<string> MiddleNames { get; }
        /// <summary> Also known as title or salutation.  The prefix to the name (e.g. Mr, Mrs, Ms, Miss, Sir, etc). </summary>
        public string Prefix { get; }
        /// <summary> Used for a trailing suffix to the name (e.g. Jr). </summary>
        public string Suffix { get; }
        /// <summary> Value is a valid [ANZSCO](http://www.abs.gov.au/ANZSCO) Standard Occupation classification code. If the occupation code held by the data holder is not one of the supported [ANZSCO](http://www.abs.gov.au/ANZSCO) versions, then it must not be supplied. </summary>
        public string OccupationCode { get; }
        /// <summary> The applicable [ANZSCO](http://www.abs.gov.au/ANZSCO) release version of the occupation code provided. Mandatory if an ``occupationCode`` is supplied. If ``occupationCode`` is supplied but ``occupationCodeVersion`` is absent, default is ``ANZSCO_1220.0_2013_V1.2``. </summary>
        public CommonPersonOccupationCodeVersion? OccupationCodeVersion { get; }
    }
}
