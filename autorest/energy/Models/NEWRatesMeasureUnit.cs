// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The measurement unit of rate. Assumed to be KWH if absent. </summary>
    public readonly partial struct NEWRatesMeasureUnit : IEquatable<NEWRatesMeasureUnit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NEWRatesMeasureUnit"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NEWRatesMeasureUnit(string value)
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
        public static NEWRatesMeasureUnit KWH { get; } = new NEWRatesMeasureUnit(KWHValue);
        /// <summary> KVA. </summary>
        public static NEWRatesMeasureUnit KVA { get; } = new NEWRatesMeasureUnit(KVAValue);
        /// <summary> KVAR. </summary>
        public static NEWRatesMeasureUnit Kvar { get; } = new NEWRatesMeasureUnit(KvarValue);
        /// <summary> KVARH. </summary>
        public static NEWRatesMeasureUnit Kvarh { get; } = new NEWRatesMeasureUnit(KvarhValue);
        /// <summary> KW. </summary>
        public static NEWRatesMeasureUnit KW { get; } = new NEWRatesMeasureUnit(KWValue);
        /// <summary> DAYS. </summary>
        public static NEWRatesMeasureUnit Days { get; } = new NEWRatesMeasureUnit(DaysValue);
        /// <summary> METER. </summary>
        public static NEWRatesMeasureUnit Meter { get; } = new NEWRatesMeasureUnit(MeterValue);
        /// <summary> MONTH. </summary>
        public static NEWRatesMeasureUnit Month { get; } = new NEWRatesMeasureUnit(MonthValue);
        /// <summary> Determines if two <see cref="NEWRatesMeasureUnit"/> values are the same. </summary>
        public static bool operator ==(NEWRatesMeasureUnit left, NEWRatesMeasureUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NEWRatesMeasureUnit"/> values are not the same. </summary>
        public static bool operator !=(NEWRatesMeasureUnit left, NEWRatesMeasureUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NEWRatesMeasureUnit"/>. </summary>
        public static implicit operator NEWRatesMeasureUnit(string value) => new NEWRatesMeasureUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NEWRatesMeasureUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NEWRatesMeasureUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
