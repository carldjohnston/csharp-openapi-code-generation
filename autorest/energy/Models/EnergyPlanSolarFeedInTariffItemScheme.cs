// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The applicable scheme. </summary>
    public readonly partial struct EnergyPlanSolarFeedInTariffItemScheme : IEquatable<EnergyPlanSolarFeedInTariffItemScheme>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemScheme"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanSolarFeedInTariffItemScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PremiumValue = "PREMIUM";
        private const string OtherValue = "OTHER";

        /// <summary> PREMIUM. </summary>
        public static EnergyPlanSolarFeedInTariffItemScheme Premium { get; } = new EnergyPlanSolarFeedInTariffItemScheme(PremiumValue);
        /// <summary> OTHER. </summary>
        public static EnergyPlanSolarFeedInTariffItemScheme Other { get; } = new EnergyPlanSolarFeedInTariffItemScheme(OtherValue);
        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemScheme"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanSolarFeedInTariffItemScheme left, EnergyPlanSolarFeedInTariffItemScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanSolarFeedInTariffItemScheme"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanSolarFeedInTariffItemScheme left, EnergyPlanSolarFeedInTariffItemScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanSolarFeedInTariffItemScheme"/>. </summary>
        public static implicit operator EnergyPlanSolarFeedInTariffItemScheme(string value) => new EnergyPlanSolarFeedInTariffItemScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanSolarFeedInTariffItemScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanSolarFeedInTariffItemScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
