// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The quality of the read taken.  If absent then assumed to be ACTUAL. </summary>
    public readonly partial struct EnergyUsageReadIntervalReadsQuality : IEquatable<EnergyUsageReadIntervalReadsQuality>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyUsageReadIntervalReadsQuality"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyUsageReadIntervalReadsQuality(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActualValue = "ACTUAL";
        private const string SubstituteValue = "SUBSTITUTE";
        private const string FinalSubstituteValue = "FINAL_SUBSTITUTE";

        /// <summary> ACTUAL. </summary>
        public static EnergyUsageReadIntervalReadsQuality Actual { get; } = new EnergyUsageReadIntervalReadsQuality(ActualValue);
        /// <summary> SUBSTITUTE. </summary>
        public static EnergyUsageReadIntervalReadsQuality Substitute { get; } = new EnergyUsageReadIntervalReadsQuality(SubstituteValue);
        /// <summary> FINAL_SUBSTITUTE. </summary>
        public static EnergyUsageReadIntervalReadsQuality FinalSubstitute { get; } = new EnergyUsageReadIntervalReadsQuality(FinalSubstituteValue);
        /// <summary> Determines if two <see cref="EnergyUsageReadIntervalReadsQuality"/> values are the same. </summary>
        public static bool operator ==(EnergyUsageReadIntervalReadsQuality left, EnergyUsageReadIntervalReadsQuality right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyUsageReadIntervalReadsQuality"/> values are not the same. </summary>
        public static bool operator !=(EnergyUsageReadIntervalReadsQuality left, EnergyUsageReadIntervalReadsQuality right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyUsageReadIntervalReadsQuality"/>. </summary>
        public static implicit operator EnergyUsageReadIntervalReadsQuality(string value) => new EnergyUsageReadIntervalReadsQuality(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyUsageReadIntervalReadsQuality other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyUsageReadIntervalReadsQuality other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
