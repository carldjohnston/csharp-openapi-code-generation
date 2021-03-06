// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The measurement unit of rate. Assumed to be KWH if absent. </summary>
    public readonly partial struct EnergyPlanTariffPeriodSingleRatesMeasureUnit : IEquatable<EnergyPlanTariffPeriodSingleRatesMeasureUnit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodSingleRatesMeasureUnit"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanTariffPeriodSingleRatesMeasureUnit(string value)
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
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit KWH { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(KWHValue);
        /// <summary> KVA. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit KVA { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(KVAValue);
        /// <summary> KVAR. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit Kvar { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(KvarValue);
        /// <summary> KVARH. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit Kvarh { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(KvarhValue);
        /// <summary> KW. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit KW { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(KWValue);
        /// <summary> DAYS. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit Days { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(DaysValue);
        /// <summary> METER. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit Meter { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(MeterValue);
        /// <summary> MONTH. </summary>
        public static EnergyPlanTariffPeriodSingleRatesMeasureUnit Month { get; } = new EnergyPlanTariffPeriodSingleRatesMeasureUnit(MonthValue);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodSingleRatesMeasureUnit"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanTariffPeriodSingleRatesMeasureUnit left, EnergyPlanTariffPeriodSingleRatesMeasureUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanTariffPeriodSingleRatesMeasureUnit"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanTariffPeriodSingleRatesMeasureUnit left, EnergyPlanTariffPeriodSingleRatesMeasureUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanTariffPeriodSingleRatesMeasureUnit"/>. </summary>
        public static implicit operator EnergyPlanTariffPeriodSingleRatesMeasureUnit(string value) => new EnergyPlanTariffPeriodSingleRatesMeasureUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanTariffPeriodSingleRatesMeasureUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanTariffPeriodSingleRatesMeasureUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
