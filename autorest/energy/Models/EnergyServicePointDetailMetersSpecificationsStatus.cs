// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> A code to denote the status of the meter. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**CURRENT** -Applies when a meter is current and not disconnected&lt;/li&gt;&lt;li&gt;**DISCONNECTED** - Applies when a meter is present but has been remotely disconnected&lt;/li&gt;&lt;/ul&gt;. </summary>
    public readonly partial struct EnergyServicePointDetailMetersSpecificationsStatus : IEquatable<EnergyServicePointDetailMetersSpecificationsStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyServicePointDetailMetersSpecificationsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "CURRENT";
        private const string DisconnectedValue = "DISCONNECTED";

        /// <summary> CURRENT. </summary>
        public static EnergyServicePointDetailMetersSpecificationsStatus Current { get; } = new EnergyServicePointDetailMetersSpecificationsStatus(CurrentValue);
        /// <summary> DISCONNECTED. </summary>
        public static EnergyServicePointDetailMetersSpecificationsStatus Disconnected { get; } = new EnergyServicePointDetailMetersSpecificationsStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsStatus"/> values are the same. </summary>
        public static bool operator ==(EnergyServicePointDetailMetersSpecificationsStatus left, EnergyServicePointDetailMetersSpecificationsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsStatus"/> values are not the same. </summary>
        public static bool operator !=(EnergyServicePointDetailMetersSpecificationsStatus left, EnergyServicePointDetailMetersSpecificationsStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyServicePointDetailMetersSpecificationsStatus"/>. </summary>
        public static implicit operator EnergyServicePointDetailMetersSpecificationsStatus(string value) => new EnergyServicePointDetailMetersSpecificationsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyServicePointDetailMetersSpecificationsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyServicePointDetailMetersSpecificationsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
