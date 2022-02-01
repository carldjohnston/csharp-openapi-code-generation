// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Object representing a single rate.  Required if rateBlockUType is singleRate. </summary>
    public partial class EnergyPlanTariffPeriodItemSingleRate
    {
        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodItemSingleRate. </summary>
        /// <param name="displayName"> Display name of the rate. </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="rates"/> is null. </exception>
        internal EnergyPlanTariffPeriodItemSingleRate(string displayName, List<EnergyPlanTariffPeriodSingleRates> rates)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (rates == null)
            {
                throw new ArgumentNullException(nameof(rates));
            }

            DisplayName = displayName;
            Rates = rates;
        }

        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodItemSingleRate. </summary>
        /// <param name="displayName"> Display name of the rate. </param>
        /// <param name="description"> Description of the rate. </param>
        /// <param name="generalUnitPrice"> The block rate (unit price) for any usage above the included fixed usage, in dollars per kWh inclusive of GST.  Only required if pricingModel field is ‘QUOTA’. </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        /// <param name="period"> Usage period for which the block rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </param>
        internal EnergyPlanTariffPeriodItemSingleRate(string displayName, string description, string generalUnitPrice, IReadOnlyList<EnergyPlanTariffPeriodSingleRates> rates, string period)
        {
            DisplayName = displayName;
            Description = description;
            GeneralUnitPrice = generalUnitPrice;
            Rates = rates;
            Period = period;
        }

        /// <summary> Display name of the rate. </summary>
        public string DisplayName { get; }
        /// <summary> Description of the rate. </summary>
        public string Description { get; }
        /// <summary> The block rate (unit price) for any usage above the included fixed usage, in dollars per kWh inclusive of GST.  Only required if pricingModel field is ‘QUOTA’. </summary>
        public string GeneralUnitPrice { get; }
        /// <summary> Array of controlled load rates in order of usage volume. </summary>
        public IReadOnlyList<EnergyPlanTariffPeriodSingleRates> Rates { get; }
        /// <summary> Usage period for which the block rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </summary>
        public string Period { get; }
    }
}