// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyPlanTariffPeriodPropertiesItemsItem. </summary>
    public partial class EnergyPlanTariffPeriodPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodPropertiesItemsItem. </summary>
        /// <param name="displayName"> Display name of the rate. </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        /// <param name="timeOfUse"> Array of times of use. </param>
        /// <param name="type"> The type of usage that the rate applies to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/>, <paramref name="rates"/>, or <paramref name="timeOfUse"/> is null. </exception>
        internal EnergyPlanTariffPeriodPropertiesItemsItem(string displayName, List<EnergyPlanTariffPeriodPropertiesItemsRatesItem> rates, List<EnergyPlanTariffPeriodPropertiesItemsTimeOfUseItem> timeOfUse, EnergyPlanTariffPeriodItemTimeOfUseRatesItemType type)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (rates == null)
            {
                throw new ArgumentNullException(nameof(rates));
            }
            if (timeOfUse == null)
            {
                throw new ArgumentNullException(nameof(timeOfUse));
            }

            DisplayName = displayName;
            Rates = rates;
            TimeOfUse = timeOfUse;
            Type = type;
        }

        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodPropertiesItemsItem. </summary>
        /// <param name="displayName"> Display name of the rate. </param>
        /// <param name="description"> Description of the rate. </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        /// <param name="timeOfUse"> Array of times of use. </param>
        /// <param name="type"> The type of usage that the rate applies to. </param>
        internal EnergyPlanTariffPeriodPropertiesItemsItem(string displayName, string description, IReadOnlyList<EnergyPlanTariffPeriodPropertiesItemsRatesItem> rates, IReadOnlyList<EnergyPlanTariffPeriodPropertiesItemsTimeOfUseItem> timeOfUse, EnergyPlanTariffPeriodItemTimeOfUseRatesItemType type)
        {
            DisplayName = displayName;
            Description = description;
            Rates = rates;
            TimeOfUse = timeOfUse;
            Type = type;
        }

        /// <summary> Display name of the rate. </summary>
        public string DisplayName { get; }
        /// <summary> Description of the rate. </summary>
        public string Description { get; }
        /// <summary> Array of controlled load rates in order of usage volume. </summary>
        public IReadOnlyList<EnergyPlanTariffPeriodPropertiesItemsRatesItem> Rates { get; }
        /// <summary> Array of times of use. </summary>
        public IReadOnlyList<EnergyPlanTariffPeriodPropertiesItemsTimeOfUseItem> TimeOfUse { get; }
        /// <summary> The type of usage that the rate applies to. </summary>
        public EnergyPlanTariffPeriodItemTimeOfUseRatesItemType Type { get; }
    }
}
