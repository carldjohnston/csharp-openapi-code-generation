// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Agl.Cdr.Energy;

namespace Agl.Cdr.Energy.Models
{
    /// <summary> The EnergyPlanTariffPeriodPropertiesItemsRatesItem. </summary>
    public partial class EnergyPlanTariffPeriodPropertiesItemsRatesItem
    {
        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodPropertiesItemsRatesItem. </summary>
        /// <param name="unitPrice"> Unit price of usage per  measure unit (exclusive of GST). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="unitPrice"/> is null. </exception>
        internal EnergyPlanTariffPeriodPropertiesItemsRatesItem(string unitPrice)
        {
            if (unitPrice == null)
            {
                throw new ArgumentNullException(nameof(unitPrice));
            }

            UnitPrice = unitPrice;
        }

        /// <summary> Initializes a new instance of EnergyPlanTariffPeriodPropertiesItemsRatesItem. </summary>
        /// <param name="unitPrice"> Unit price of usage per  measure unit (exclusive of GST). </param>
        /// <param name="measureUnit"> The measurement unit of rate. Assumed to be KWH if absent. </param>
        /// <param name="volume"> Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period. </param>
        internal EnergyPlanTariffPeriodPropertiesItemsRatesItem(string unitPrice, EnergyPlanTariffPeriodItemTimeOfUseRatesItemMeasureUnit? measureUnit, float? volume)
        {
            UnitPrice = unitPrice;
            MeasureUnit = measureUnit;
            Volume = volume;
        }

        /// <summary> Unit price of usage per  measure unit (exclusive of GST). </summary>
        public string UnitPrice { get; }
        /// <summary> The measurement unit of rate. Assumed to be KWH if absent. </summary>
        public EnergyPlanTariffPeriodItemTimeOfUseRatesItemMeasureUnit? MeasureUnit { get; }
        /// <summary> Volume in kWh that this rate applies to.  Only applicable for ‘stepped’ rates where different rates apply for different volumes of usage in a period. </summary>
        public float? Volume { get; }
    }
}
