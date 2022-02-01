// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The metering Installation type code indicates whether the metering installation has to be manually read. Note the details of enumeration values below: &lt;ul&gt;&lt;li&gt;**BASIC** - Accumulation Meter – Type 6&lt;/li&gt;&lt;li&gt;**COMMS1** - Interval Meter with communications – Type 1&lt;/li&gt;&lt;li&gt;**COMMS2** - Interval Meter with communications – Type 2&lt;/li&gt;&lt;li&gt;**COMMS3** - Interval Meter with communications – Type 3&lt;/li&gt;&lt;li&gt;**COMMS4** - Interval Meter with communications – Type 4&lt;/li&gt;&lt;li&gt;**COMMS4C** - CT connected metering installation that meets the minimum services specifications&lt;/li&gt;&lt;li&gt;**COMMS4D** - Whole current metering installation that meets the minimum services specifications&lt;/li&gt;&lt;li&gt;**MRAM** - Small customer metering installation – Type 4A&lt;/li&gt;&lt;li&gt;**MRIM** - Manually Read Interval Meter – Type 5&lt;/li&gt;&lt;li&gt;**UMCP** - Unmetered Supply – Type 7&lt;/li&gt;&lt;li&gt;**VICAMI** - A relevant metering installation as defined in clause 9.9C of the NER&lt;/li&gt;&lt;li&gt;**NCONUML** - Non-contestable unmeter load - Introduced as part of Global Settlement&lt;/li&gt;&lt;/ul&gt;. </summary>
    public readonly partial struct EnergyServicePointDetailMetersSpecificationsInstallationType : IEquatable<EnergyServicePointDetailMetersSpecificationsInstallationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsInstallationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyServicePointDetailMetersSpecificationsInstallationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "BASIC";
        private const string Comms1Value = "COMMS1";
        private const string Comms2Value = "COMMS2";
        private const string Comms3Value = "COMMS3";
        private const string Comms4Value = "COMMS4";
        private const string Comms4CValue = "COMMS4C";
        private const string Comms4DValue = "COMMS4D";
        private const string MramValue = "MRAM";
        private const string MrimValue = "MRIM";
        private const string ProfValue = "PROF";
        private const string SampleValue = "SAMPLE";
        private const string UmcpValue = "UMCP";
        private const string VicamiValue = "VICAMI";
        private const string NcolnumlValue = "NCOLNUML";

        /// <summary> BASIC. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Basic { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(BasicValue);
        /// <summary> COMMS1. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms1 { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms1Value);
        /// <summary> COMMS2. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms2 { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms2Value);
        /// <summary> COMMS3. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms3 { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms3Value);
        /// <summary> COMMS4. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms4 { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms4Value);
        /// <summary> COMMS4C. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms4C { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms4CValue);
        /// <summary> COMMS4D. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Comms4D { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(Comms4DValue);
        /// <summary> MRAM. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Mram { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(MramValue);
        /// <summary> MRIM. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Mrim { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(MrimValue);
        /// <summary> PROF. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Prof { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(ProfValue);
        /// <summary> SAMPLE. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Sample { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(SampleValue);
        /// <summary> UMCP. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Umcp { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(UmcpValue);
        /// <summary> VICAMI. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Vicami { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(VicamiValue);
        /// <summary> NCOLNUML. </summary>
        public static EnergyServicePointDetailMetersSpecificationsInstallationType Ncolnuml { get; } = new EnergyServicePointDetailMetersSpecificationsInstallationType(NcolnumlValue);
        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsInstallationType"/> values are the same. </summary>
        public static bool operator ==(EnergyServicePointDetailMetersSpecificationsInstallationType left, EnergyServicePointDetailMetersSpecificationsInstallationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyServicePointDetailMetersSpecificationsInstallationType"/> values are not the same. </summary>
        public static bool operator !=(EnergyServicePointDetailMetersSpecificationsInstallationType left, EnergyServicePointDetailMetersSpecificationsInstallationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyServicePointDetailMetersSpecificationsInstallationType"/>. </summary>
        public static implicit operator EnergyServicePointDetailMetersSpecificationsInstallationType(string value) => new EnergyServicePointDetailMetersSpecificationsInstallationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyServicePointDetailMetersSpecificationsInstallationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyServicePointDetailMetersSpecificationsInstallationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
