// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The type of the payer. </summary>
    public readonly partial struct EnergyPlanSolarFeedInTariffItemTariffUType : IEquatable<EnergyPlanSolarFeedInTariffItemTariffUType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemTariffUType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanSolarFeedInTariffItemTariffUType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleTariffValue = "singleTariff";
        private const string TimeVaryingTariffsValue = "timeVaryingTariffs";

        /// <summary> singleTariff. </summary>
        public static EnergyPlanSolarFeedInTariffItemTariffUType SingleTariff { get; } = new EnergyPlanSolarFeedInTariffItemTariffUType(SingleTariffValue);
        /// <summary> timeVaryingTariffs. </summary>
        public static EnergyPlanSolarFeedInTariffItemTariffUType TimeVaryingTariffs { get; } = new EnergyPlanSolarFeedInTariffItemTariffUType(TimeVaryingTariffsValue);
        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemTariffUType"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanSolarFeedInTariffItemTariffUType left, EnergyPlanSolarFeedInTariffItemTariffUType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemTariffUType"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanSolarFeedInTariffItemTariffUType left, EnergyPlanSolarFeedInTariffItemTariffUType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanSolarFeedInTariffItemTariffUType"/>. </summary>
        public static implicit operator EnergyPlanSolarFeedInTariffItemTariffUType(string value) => new EnergyPlanSolarFeedInTariffItemTariffUType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanSolarFeedInTariffItemTariffUType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanSolarFeedInTariffItemTariffUType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
