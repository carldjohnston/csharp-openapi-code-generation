// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> Indicates whether the DER device is connected via an inverter (and what category of inverter it is) or not (e.g. rotating machine). If absent, assume equipment type to be “OTHER”. </summary>
    public readonly partial struct EnergyDerRecordAcConnectionsEquipmentType : IEquatable<EnergyDerRecordAcConnectionsEquipmentType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyDerRecordAcConnectionsEquipmentType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyDerRecordAcConnectionsEquipmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InverterValue = "INVERTER";
        private const string OtherValue = "OTHER";

        /// <summary> INVERTER. </summary>
        public static EnergyDerRecordAcConnectionsEquipmentType Inverter { get; } = new EnergyDerRecordAcConnectionsEquipmentType(InverterValue);
        /// <summary> OTHER. </summary>
        public static EnergyDerRecordAcConnectionsEquipmentType Other { get; } = new EnergyDerRecordAcConnectionsEquipmentType(OtherValue);
        /// <summary> Determines if two <see cref="EnergyDerRecordAcConnectionsEquipmentType"/> values are the same. </summary>
        public static bool operator ==(EnergyDerRecordAcConnectionsEquipmentType left, EnergyDerRecordAcConnectionsEquipmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyDerRecordAcConnectionsEquipmentType"/> values are not the same. </summary>
        public static bool operator !=(EnergyDerRecordAcConnectionsEquipmentType left, EnergyDerRecordAcConnectionsEquipmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyDerRecordAcConnectionsEquipmentType"/>. </summary>
        public static implicit operator EnergyDerRecordAcConnectionsEquipmentType(string value) => new EnergyDerRecordAcConnectionsEquipmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyDerRecordAcConnectionsEquipmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyDerRecordAcConnectionsEquipmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
