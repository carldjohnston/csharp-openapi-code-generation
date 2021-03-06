// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> Code used to indicate the status of the device. This will be used to identify if an inverter is active or inactive or decommissioned. </summary>
    public readonly partial struct EnergyDerRecordDerDevicesStatus : IEquatable<EnergyDerRecordDerDevicesStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyDerRecordDerDevicesStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyDerRecordDerDevicesStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "ACTIVE";
        private const string InactiveValue = "INACTIVE";
        private const string DecommissionedValue = "DECOMMISSIONED";

        /// <summary> ACTIVE. </summary>
        public static EnergyDerRecordDerDevicesStatus Active { get; } = new EnergyDerRecordDerDevicesStatus(ActiveValue);
        /// <summary> INACTIVE. </summary>
        public static EnergyDerRecordDerDevicesStatus Inactive { get; } = new EnergyDerRecordDerDevicesStatus(InactiveValue);
        /// <summary> DECOMMISSIONED. </summary>
        public static EnergyDerRecordDerDevicesStatus Decommissioned { get; } = new EnergyDerRecordDerDevicesStatus(DecommissionedValue);
        /// <summary> Determines if two <see cref="EnergyDerRecordDerDevicesStatus"/> values are the same. </summary>
        public static bool operator ==(EnergyDerRecordDerDevicesStatus left, EnergyDerRecordDerDevicesStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyDerRecordDerDevicesStatus"/> values are not the same. </summary>
        public static bool operator !=(EnergyDerRecordDerDevicesStatus left, EnergyDerRecordDerDevicesStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyDerRecordDerDevicesStatus"/>. </summary>
        public static implicit operator EnergyDerRecordDerDevicesStatus(string value) => new EnergyDerRecordDerDevicesStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyDerRecordDerDevicesStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyDerRecordDerDevicesStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
