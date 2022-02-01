// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyAccountBase. </summary>
    public partial class EnergyAccountBase
    {
        /// <summary> Initializes a new instance of EnergyAccountBase. </summary>
        /// <param name="accountId"> The ID of the account.  To be created in accordance with CDR ID permanence requirements. </param>
        /// <param name="creationDate"> The date that the account was created or opened. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountId"/> or <paramref name="creationDate"/> is null. </exception>
        internal EnergyAccountBase(string accountId, string creationDate)
        {
            if (accountId == null)
            {
                throw new ArgumentNullException(nameof(accountId));
            }
            if (creationDate == null)
            {
                throw new ArgumentNullException(nameof(creationDate));
            }

            AccountId = accountId;
            CreationDate = creationDate;
        }

        /// <summary> Initializes a new instance of EnergyAccountBase. </summary>
        /// <param name="accountId"> The ID of the account.  To be created in accordance with CDR ID permanence requirements. </param>
        /// <param name="accountNumber"> Optional identifier of the account as defined by the data holder.  This must be the value presented on physical statements (if it exists) and must not be used for the value of accountId. </param>
        /// <param name="displayName"> An optional display name for the account if one exists or can be derived.  The content of this field is at the discretion of the data holder. </param>
        /// <param name="creationDate"> The date that the account was created or opened. </param>
        internal EnergyAccountBase(string accountId, string accountNumber, string displayName, string creationDate)
        {
            AccountId = accountId;
            AccountNumber = accountNumber;
            DisplayName = displayName;
            CreationDate = creationDate;
        }

        /// <summary> The ID of the account.  To be created in accordance with CDR ID permanence requirements. </summary>
        public string AccountId { get; }
        /// <summary> Optional identifier of the account as defined by the data holder.  This must be the value presented on physical statements (if it exists) and must not be used for the value of accountId. </summary>
        public string AccountNumber { get; }
        /// <summary> An optional display name for the account if one exists or can be derived.  The content of this field is at the discretion of the data holder. </summary>
        public string DisplayName { get; }
        /// <summary> The date that the account was created or opened. </summary>
        public string CreationDate { get; }
    }
}
