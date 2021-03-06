// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The measurement unit of rate. Assumed to be KWH if absent. </summary>
    public readonly partial struct EnergyBillingUsageTransactionMeasureUnit : IEquatable<EnergyBillingUsageTransactionMeasureUnit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionMeasureUnit"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyBillingUsageTransactionMeasureUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KWHValue = "KWH";
        private const string KVAValue = "KVA";
        private const string KvarValue = "KVAR";
        private const string KvarhValue = "KVARH";
        private const string KWValue = "KW";
        private const string DaysValue = "DAYS";
        private const string MeterValue = "METER";
        private const string MonthValue = "MONTH";

        /// <summary> KWH. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit KWH { get; } = new EnergyBillingUsageTransactionMeasureUnit(KWHValue);
        /// <summary> KVA. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit KVA { get; } = new EnergyBillingUsageTransactionMeasureUnit(KVAValue);
        /// <summary> KVAR. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit Kvar { get; } = new EnergyBillingUsageTransactionMeasureUnit(KvarValue);
        /// <summary> KVARH. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit Kvarh { get; } = new EnergyBillingUsageTransactionMeasureUnit(KvarhValue);
        /// <summary> KW. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit KW { get; } = new EnergyBillingUsageTransactionMeasureUnit(KWValue);
        /// <summary> DAYS. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit Days { get; } = new EnergyBillingUsageTransactionMeasureUnit(DaysValue);
        /// <summary> METER. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit Meter { get; } = new EnergyBillingUsageTransactionMeasureUnit(MeterValue);
        /// <summary> MONTH. </summary>
        public static EnergyBillingUsageTransactionMeasureUnit Month { get; } = new EnergyBillingUsageTransactionMeasureUnit(MonthValue);
        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionMeasureUnit"/> values are the same. </summary>
        public static bool operator ==(EnergyBillingUsageTransactionMeasureUnit left, EnergyBillingUsageTransactionMeasureUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionMeasureUnit"/> values are not the same. </summary>
        public static bool operator !=(EnergyBillingUsageTransactionMeasureUnit left, EnergyBillingUsageTransactionMeasureUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyBillingUsageTransactionMeasureUnit"/>. </summary>
        public static implicit operator EnergyBillingUsageTransactionMeasureUnit(string value) => new EnergyBillingUsageTransactionMeasureUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyBillingUsageTransactionMeasureUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyBillingUsageTransactionMeasureUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
