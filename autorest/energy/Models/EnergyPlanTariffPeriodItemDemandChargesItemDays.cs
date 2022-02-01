// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Object containing demand tariff by day of week. </summary>
    public partial class EnergyPlanTariffPeriodItemDemandChargesItemDays
    {
        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodItemDemandChargesItemDays. </summary>
        /// <param name="weekdays"> Indicates the demand tariff is applicable on weekdays. </param>
        /// <param name="saturday"> Indicates the demand tariff is applicable on Saturdays. </param>
        /// <param name="sunday"> Indicates the demand tariff is applicable on Sundays. </param>
        internal EnergyPlanTariffPeriodItemDemandChargesItemDays(bool weekdays, bool saturday, bool sunday)
        {
            Weekdays = weekdays;
            Saturday = saturday;
            Sunday = sunday;
        }

        /// <summary> Indicates the demand tariff is applicable on weekdays. </summary>
        public bool Weekdays { get; }
        /// <summary> Indicates the demand tariff is applicable on Saturdays. </summary>
        public bool Saturday { get; }
        /// <summary> Indicates the demand tariff is applicable on Sundays. </summary>
        public bool Sunday { get; }
    }
}