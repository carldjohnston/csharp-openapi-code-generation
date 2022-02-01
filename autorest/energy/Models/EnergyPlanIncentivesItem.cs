// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyPlanIncentivesItem. </summary>
    public partial class EnergyPlanIncentivesItem
    {
        /// <summary> Initializes a new instance of EnergyPlanIncentivesItem. </summary>
        /// <param name="displayName"> The display name of the incentive. </param>
        /// <param name="description"> The description of the incentive. </param>
        /// <param name="category"> The type of the incentive. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="description"/> is null. </exception>
        internal EnergyPlanIncentivesItem(string displayName, string description, EnergyPlanIncentivesItemCategory category)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            DisplayName = displayName;
            Description = description;
            Category = category;
        }

        /// <summary> Initializes a new instance of EnergyPlanIncentivesItem. </summary>
        /// <param name="displayName"> The display name of the incentive. </param>
        /// <param name="description"> The description of the incentive. </param>
        /// <param name="category"> The type of the incentive. </param>
        /// <param name="eligibility"> A display message outlining an eligibility criteria that may apply. </param>
        internal EnergyPlanIncentivesItem(string displayName, string description, EnergyPlanIncentivesItemCategory category, string eligibility)
        {
            DisplayName = displayName;
            Description = description;
            Category = category;
            Eligibility = eligibility;
        }

        /// <summary> The display name of the incentive. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the incentive. </summary>
        public string Description { get; }
        /// <summary> The type of the incentive. </summary>
        public EnergyPlanIncentivesItemCategory Category { get; }
        /// <summary> A display message outlining an eligibility criteria that may apply. </summary>
        public string Eligibility { get; }
    }
}