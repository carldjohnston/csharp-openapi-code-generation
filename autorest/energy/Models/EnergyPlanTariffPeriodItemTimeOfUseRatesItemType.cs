// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The type of usage that the rate applies to. </summary>
    public readonly partial struct EnergyPlanTariffPeriodItemTimeOfUseRatesItemType : IEquatable<EnergyPlanTariffPeriodItemTimeOfUseRatesItemType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodItemTimeOfUseRatesItemType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PeakValue = "PEAK";
        private const string OFFPeakValue = "OFF_PEAK";
        private const string ShoulderValue = "SHOULDER";
        private const string Shoulder1Value = "SHOULDER1";
        private const string Shoulder2Value = "SHOULDER2";

        /// <summary> PEAK. </summary>
        public static EnergyPlanTariffPeriodItemTimeOfUseRatesItemType Peak { get; } = new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(PeakValue);
        /// <summary> OFF_PEAK. </summary>
        public static EnergyPlanTariffPeriodItemTimeOfUseRatesItemType OFFPeak { get; } = new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(OFFPeakValue);
        /// <summary> SHOULDER. </summary>
        public static EnergyPlanTariffPeriodItemTimeOfUseRatesItemType Shoulder { get; } = new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(ShoulderValue);
        /// <summary> SHOULDER1. </summary>
        public static EnergyPlanTariffPeriodItemTimeOfUseRatesItemType Shoulder1 { get; } = new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(Shoulder1Value);
        /// <summary> SHOULDER2. </summary>
        public static EnergyPlanTariffPeriodItemTimeOfUseRatesItemType Shoulder2 { get; } = new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(Shoulder2Value);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodItemTimeOfUseRatesItemType"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanTariffPeriodItemTimeOfUseRatesItemType left, EnergyPlanTariffPeriodItemTimeOfUseRatesItemType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodItemTimeOfUseRatesItemType"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanTariffPeriodItemTimeOfUseRatesItemType left, EnergyPlanTariffPeriodItemTimeOfUseRatesItemType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanTariffPeriodItemTimeOfUseRatesItemType"/>. </summary>
        public static implicit operator EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(string value) => new EnergyPlanTariffPeriodItemTimeOfUseRatesItemType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanTariffPeriodItemTimeOfUseRatesItemType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanTariffPeriodItemTimeOfUseRatesItemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}