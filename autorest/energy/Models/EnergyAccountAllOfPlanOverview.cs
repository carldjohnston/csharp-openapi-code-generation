// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyAccountAllOfPlanOverview. </summary>
    public partial class EnergyAccountAllOfPlanOverview
    {
        /// <summary> Initializes a new instance of EnergyAccountAllOfPlanOverview. </summary>
        /// <param name="startDate"> The start date of the applicability of this plan. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startDate"/> is null. </exception>
        internal EnergyAccountAllOfPlanOverview(string startDate)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException(nameof(startDate));
            }

            StartDate = startDate;
        }

        /// <summary> Initializes a new instance of EnergyAccountAllOfPlanOverview. </summary>
        /// <param name="displayName"> The name of the plan if one exists. </param>
        /// <param name="startDate"> The start date of the applicability of this plan. </param>
        /// <param name="endDate"> The end date of the applicability of this plan. </param>
        internal EnergyAccountAllOfPlanOverview(string displayName, string startDate, string endDate)
        {
            DisplayName = displayName;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary> The name of the plan if one exists. </summary>
        public string DisplayName { get; }
        /// <summary> The start date of the applicability of this plan. </summary>
        public string StartDate { get; }
        /// <summary> The end date of the applicability of this plan. </summary>
        public string EndDate { get; }
    }
}
