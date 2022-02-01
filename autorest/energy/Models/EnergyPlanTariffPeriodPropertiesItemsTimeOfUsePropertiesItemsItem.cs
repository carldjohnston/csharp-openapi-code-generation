// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem. </summary>
    public readonly partial struct EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem : IEquatable<EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "SUNDAY";
        private const string MondayValue = "MONDAY";
        private const string TuesdayValue = "TUESDAY";
        private const string WednesdayValue = "WEDNESDAY";
        private const string ThursdayValue = "THURSDAY";
        private const string FridayValue = "FRIDAY";
        private const string SaturdayValue = "SATURDAY";
        private const string BusinessDaysValue = "BUSINESS_DAYS";

        /// <summary> SUNDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Sunday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(SundayValue);
        /// <summary> MONDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Monday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(MondayValue);
        /// <summary> TUESDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Tuesday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(TuesdayValue);
        /// <summary> WEDNESDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Wednesday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(WednesdayValue);
        /// <summary> THURSDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Thursday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(ThursdayValue);
        /// <summary> FRIDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Friday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(FridayValue);
        /// <summary> SATURDAY. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem Saturday { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(SaturdayValue);
        /// <summary> BUSINESS_DAYS. </summary>
        public static EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem BusinessDays { get; } = new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(BusinessDaysValue);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem left, EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem left, EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem"/>. </summary>
        public static implicit operator EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(string value) => new EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanTariffPeriodPropertiesItemsTimeOfUsePropertiesItemsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}