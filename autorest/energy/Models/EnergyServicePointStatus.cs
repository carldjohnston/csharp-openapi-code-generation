// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> Code used to indicate the status of the service point. Note the details for the enumeration values below:&lt;ul&gt;&lt;li&gt;**ACTIVE** - An active, energised, service point&lt;/li&gt;&lt;li&gt;**DE_ENERGISED** - The service point exists but is deenergised&lt;/li&gt;&lt;li&gt;**EXTINCT** - The service point has been permanently decommissioned&lt;/li&gt;&lt;li&gt;**GREENFIELD** - Applies to a service point that has never been energised&lt;/li&gt;&lt;li&gt;**OFF_MARKET** - Applies when the service point is no longer settled in the NEM&lt;/li&gt;&lt;/ul&gt;. </summary>
    public readonly partial struct EnergyServicePointStatus : IEquatable<EnergyServicePointStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyServicePointStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyServicePointStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "ACTIVE";
        private const string DEEnergisedValue = "DE_ENERGISED";
        private const string ExtinctValue = "EXTINCT";
        private const string GreenfieldValue = "GREENFIELD";
        private const string OFFMarketValue = "OFF_MARKET";

        /// <summary> ACTIVE. </summary>
        public static EnergyServicePointStatus Active { get; } = new EnergyServicePointStatus(ActiveValue);
        /// <summary> DE_ENERGISED. </summary>
        public static EnergyServicePointStatus DEEnergised { get; } = new EnergyServicePointStatus(DEEnergisedValue);
        /// <summary> EXTINCT. </summary>
        public static EnergyServicePointStatus Extinct { get; } = new EnergyServicePointStatus(ExtinctValue);
        /// <summary> GREENFIELD. </summary>
        public static EnergyServicePointStatus Greenfield { get; } = new EnergyServicePointStatus(GreenfieldValue);
        /// <summary> OFF_MARKET. </summary>
        public static EnergyServicePointStatus OFFMarket { get; } = new EnergyServicePointStatus(OFFMarketValue);
        /// <summary> Determines if two <see cref="EnergyServicePointStatus"/> values are the same. </summary>
        public static bool operator ==(EnergyServicePointStatus left, EnergyServicePointStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyServicePointStatus"/> values are not the same. </summary>
        public static bool operator !=(EnergyServicePointStatus left, EnergyServicePointStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyServicePointStatus"/>. </summary>
        public static implicit operator EnergyServicePointStatus(string value) => new EnergyServicePointStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyServicePointStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyServicePointStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}