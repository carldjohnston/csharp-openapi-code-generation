// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> Jurisdiction code to which the service point belongs.This code defines the jurisdictional rules which apply to the service point. Note the details of enumeration values below:&lt;ul&gt;&lt;li&gt;**ALL** - All Jurisdictions&lt;/li&gt;&lt;li&gt;**ACT** - Australian Capital Territory&lt;/li&gt;&lt;li&gt;**NEM** - National Electricity Market&lt;/li&gt;&lt;li&gt;**NSW** - New South Wales&lt;/li&gt;&lt;li&gt;**QLD** - Queensland&lt;/li&gt;&lt;li&gt;**SA** - South Australia&lt;/li&gt;&lt;li&gt;**TAS** - Tasmania&lt;/li&gt;&lt;li&gt;**VIC** - Victoria&lt;/li&gt;&lt;/ul&gt;. </summary>
    public readonly partial struct EnergyServicePointJurisdictionCode : IEquatable<EnergyServicePointJurisdictionCode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyServicePointJurisdictionCode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyServicePointJurisdictionCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ALLValue = "ALL";
        private const string ACTValue = "ACT";
        private const string NEMValue = "NEM";
        private const string NSWValue = "NSW";
        private const string QLDValue = "QLD";
        private const string SAValue = "SA";
        private const string TASValue = "TAS";
        private const string VICValue = "VIC";

        /// <summary> ALL. </summary>
        public static EnergyServicePointJurisdictionCode ALL { get; } = new EnergyServicePointJurisdictionCode(ALLValue);
        /// <summary> ACT. </summary>
        public static EnergyServicePointJurisdictionCode ACT { get; } = new EnergyServicePointJurisdictionCode(ACTValue);
        /// <summary> NEM. </summary>
        public static EnergyServicePointJurisdictionCode NEM { get; } = new EnergyServicePointJurisdictionCode(NEMValue);
        /// <summary> NSW. </summary>
        public static EnergyServicePointJurisdictionCode NSW { get; } = new EnergyServicePointJurisdictionCode(NSWValue);
        /// <summary> QLD. </summary>
        public static EnergyServicePointJurisdictionCode QLD { get; } = new EnergyServicePointJurisdictionCode(QLDValue);
        /// <summary> SA. </summary>
        public static EnergyServicePointJurisdictionCode SA { get; } = new EnergyServicePointJurisdictionCode(SAValue);
        /// <summary> TAS. </summary>
        public static EnergyServicePointJurisdictionCode TAS { get; } = new EnergyServicePointJurisdictionCode(TASValue);
        /// <summary> VIC. </summary>
        public static EnergyServicePointJurisdictionCode VIC { get; } = new EnergyServicePointJurisdictionCode(VICValue);
        /// <summary> Determines if two <see cref="EnergyServicePointJurisdictionCode"/> values are the same. </summary>
        public static bool operator ==(EnergyServicePointJurisdictionCode left, EnergyServicePointJurisdictionCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyServicePointJurisdictionCode"/> values are not the same. </summary>
        public static bool operator !=(EnergyServicePointJurisdictionCode left, EnergyServicePointJurisdictionCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyServicePointJurisdictionCode"/>. </summary>
        public static implicit operator EnergyServicePointJurisdictionCode(string value) => new EnergyServicePointJurisdictionCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyServicePointJurisdictionCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyServicePointJurisdictionCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
