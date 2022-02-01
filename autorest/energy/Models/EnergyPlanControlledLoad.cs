// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> Required if pricing model is SINGLE_RATE_CONT_LOAD or TIME_OF_USE_CONT_LOAD or FLEXIBLE_CONT_LOAD. </summary>
    public partial class EnergyPlanControlledLoad
    {
        /// <summary> Initializes a new instance of EnergyPlanControlledLoad. </summary>
        /// <param name="displayName"> A display name for the controlled load tier. </param>
        /// <param name="dailyCharge"> The daily supply charge (exclusive of GST) for this controlled load tier. </param>
        /// <param name="period"> The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/>, <paramref name="dailyCharge"/>, <paramref name="period"/>, or <paramref name="rates"/> is null. </exception>
        internal EnergyPlanControlledLoad(string displayName, string dailyCharge, string period, List<EnergyPlanControlledLoadRates> rates)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (dailyCharge == null)
            {
                throw new ArgumentNullException(nameof(dailyCharge));
            }
            if (period == null)
            {
                throw new ArgumentNullException(nameof(period));
            }
            if (rates == null)
            {
                throw new ArgumentNullException(nameof(rates));
            }

            DisplayName = displayName;
            DailyCharge = dailyCharge;
            Period = period;
            Rates = rates;
        }

        /// <summary> Initializes a new instance of EnergyPlanControlledLoad. </summary>
        /// <param name="displayName"> A display name for the controlled load tier. </param>
        /// <param name="description"> A description of the controlled load tier. </param>
        /// <param name="dailyCharge"> The daily supply charge (exclusive of GST) for this controlled load tier. </param>
        /// <param name="period"> The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </param>
        /// <param name="rates"> Array of controlled load rates in order of usage volume. </param>
        internal EnergyPlanControlledLoad(string displayName, string description, string dailyCharge, string period, IReadOnlyList<EnergyPlanControlledLoadRates> rates)
        {
            DisplayName = displayName;
            Description = description;
            DailyCharge = dailyCharge;
            Period = period;
            Rates = rates;
        }

        /// <summary> A display name for the controlled load tier. </summary>
        public string DisplayName { get; }
        /// <summary> A description of the controlled load tier. </summary>
        public string Description { get; }
        /// <summary> The daily supply charge (exclusive of GST) for this controlled load tier. </summary>
        public string DailyCharge { get; }
        /// <summary> The period for which the controlled load rate applies. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax). </summary>
        public string Period { get; }
        /// <summary> Array of controlled load rates in order of usage volume. </summary>
        public IReadOnlyList<EnergyPlanControlledLoadRates> Rates { get; }
    }
}