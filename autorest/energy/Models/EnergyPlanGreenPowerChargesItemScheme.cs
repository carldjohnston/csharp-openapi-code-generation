// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The applicable green power scheme. </summary>
    public readonly partial struct EnergyPlanGreenPowerChargesItemScheme : IEquatable<EnergyPlanGreenPowerChargesItemScheme>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanGreenPowerChargesItemScheme"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanGreenPowerChargesItemScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GreenpowerValue = "GREENPOWER";
        private const string OtherValue = "OTHER";

        /// <summary> GREENPOWER. </summary>
        public static EnergyPlanGreenPowerChargesItemScheme Greenpower { get; } = new EnergyPlanGreenPowerChargesItemScheme(GreenpowerValue);
        /// <summary> OTHER. </summary>
        public static EnergyPlanGreenPowerChargesItemScheme Other { get; } = new EnergyPlanGreenPowerChargesItemScheme(OtherValue);
        /// <summary> Determines if two <see cref="EnergyPlanGreenPowerChargesItemScheme"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanGreenPowerChargesItemScheme left, EnergyPlanGreenPowerChargesItemScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanGreenPowerChargesItemScheme"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanGreenPowerChargesItemScheme left, EnergyPlanGreenPowerChargesItemScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanGreenPowerChargesItemScheme"/>. </summary>
        public static implicit operator EnergyPlanGreenPowerChargesItemScheme(string value) => new EnergyPlanGreenPowerChargesItemScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanGreenPowerChargesItemScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanGreenPowerChargesItemScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
