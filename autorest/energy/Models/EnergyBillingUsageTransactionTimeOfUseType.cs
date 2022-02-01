// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The time of use type that the transaction applies to. </summary>
    public readonly partial struct EnergyBillingUsageTransactionTimeOfUseType : IEquatable<EnergyBillingUsageTransactionTimeOfUseType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionTimeOfUseType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyBillingUsageTransactionTimeOfUseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PeakValue = "PEAK";
        private const string OFFPeakValue = "OFF_PEAK";
        private const string OFFPeakDemandChargeValue = "OFF_PEAK_DEMAND_CHARGE";
        private const string ShoulderValue = "SHOULDER";
        private const string Shoulder1Value = "SHOULDER1";
        private const string Shoulder2Value = "SHOULDER2";
        private const string ControlledLoadValue = "CONTROLLED_LOAD";
        private const string SolarValue = "SOLAR";
        private const string AggregateValue = "AGGREGATE";

        /// <summary> PEAK. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Peak { get; } = new EnergyBillingUsageTransactionTimeOfUseType(PeakValue);
        /// <summary> OFF_PEAK. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType OFFPeak { get; } = new EnergyBillingUsageTransactionTimeOfUseType(OFFPeakValue);
        /// <summary> OFF_PEAK_DEMAND_CHARGE. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType OFFPeakDemandCharge { get; } = new EnergyBillingUsageTransactionTimeOfUseType(OFFPeakDemandChargeValue);
        /// <summary> SHOULDER. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Shoulder { get; } = new EnergyBillingUsageTransactionTimeOfUseType(ShoulderValue);
        /// <summary> SHOULDER1. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Shoulder1 { get; } = new EnergyBillingUsageTransactionTimeOfUseType(Shoulder1Value);
        /// <summary> SHOULDER2. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Shoulder2 { get; } = new EnergyBillingUsageTransactionTimeOfUseType(Shoulder2Value);
        /// <summary> CONTROLLED_LOAD. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType ControlledLoad { get; } = new EnergyBillingUsageTransactionTimeOfUseType(ControlledLoadValue);
        /// <summary> SOLAR. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Solar { get; } = new EnergyBillingUsageTransactionTimeOfUseType(SolarValue);
        /// <summary> AGGREGATE. </summary>
        public static EnergyBillingUsageTransactionTimeOfUseType Aggregate { get; } = new EnergyBillingUsageTransactionTimeOfUseType(AggregateValue);
        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionTimeOfUseType"/> values are the same. </summary>
        public static bool operator ==(EnergyBillingUsageTransactionTimeOfUseType left, EnergyBillingUsageTransactionTimeOfUseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyBillingUsageTransactionTimeOfUseType"/> values are not the same. </summary>
        public static bool operator !=(EnergyBillingUsageTransactionTimeOfUseType left, EnergyBillingUsageTransactionTimeOfUseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyBillingUsageTransactionTimeOfUseType"/>. </summary>
        public static implicit operator EnergyBillingUsageTransactionTimeOfUseType(string value) => new EnergyBillingUsageTransactionTimeOfUseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyBillingUsageTransactionTimeOfUseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyBillingUsageTransactionTimeOfUseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}