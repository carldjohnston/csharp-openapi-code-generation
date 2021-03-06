// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> Indicator of the type of transaction object present in this record. </summary>
    public readonly partial struct EnergyBillingTransactionUType : IEquatable<EnergyBillingTransactionUType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyBillingTransactionUType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyBillingTransactionUType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UsageValue = "usage";
        private const string DemandValue = "demand";
        private const string OnceOffValue = "onceOff";
        private const string OtherChargesValue = "otherCharges";
        private const string PaymentValue = "payment";

        /// <summary> usage. </summary>
        public static EnergyBillingTransactionUType Usage { get; } = new EnergyBillingTransactionUType(UsageValue);
        /// <summary> demand. </summary>
        public static EnergyBillingTransactionUType Demand { get; } = new EnergyBillingTransactionUType(DemandValue);
        /// <summary> onceOff. </summary>
        public static EnergyBillingTransactionUType OnceOff { get; } = new EnergyBillingTransactionUType(OnceOffValue);
        /// <summary> otherCharges. </summary>
        public static EnergyBillingTransactionUType OtherCharges { get; } = new EnergyBillingTransactionUType(OtherChargesValue);
        /// <summary> payment. </summary>
        public static EnergyBillingTransactionUType Payment { get; } = new EnergyBillingTransactionUType(PaymentValue);
        /// <summary> Determines if two <see cref="EnergyBillingTransactionUType"/> values are the same. </summary>
        public static bool operator ==(EnergyBillingTransactionUType left, EnergyBillingTransactionUType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyBillingTransactionUType"/> values are not the same. </summary>
        public static bool operator !=(EnergyBillingTransactionUType left, EnergyBillingTransactionUType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyBillingTransactionUType"/>. </summary>
        public static implicit operator EnergyBillingTransactionUType(string value) => new EnergyBillingTransactionUType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyBillingTransactionUType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyBillingTransactionUType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
