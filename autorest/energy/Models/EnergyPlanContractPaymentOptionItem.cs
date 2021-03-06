// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The EnergyPlanContractPaymentOptionItem. </summary>
    public readonly partial struct EnergyPlanContractPaymentOptionItem : IEquatable<EnergyPlanContractPaymentOptionItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanContractPaymentOptionItem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanContractPaymentOptionItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PaperBillValue = "PAPER_BILL";
        private const string CreditCardValue = "CREDIT_CARD";
        private const string DirectDebitValue = "DIRECT_DEBIT";
        private const string BpayValue = "BPAY";
        private const string OtherValue = "OTHER";

        /// <summary> PAPER_BILL. </summary>
        public static EnergyPlanContractPaymentOptionItem PaperBill { get; } = new EnergyPlanContractPaymentOptionItem(PaperBillValue);
        /// <summary> CREDIT_CARD. </summary>
        public static EnergyPlanContractPaymentOptionItem CreditCard { get; } = new EnergyPlanContractPaymentOptionItem(CreditCardValue);
        /// <summary> DIRECT_DEBIT. </summary>
        public static EnergyPlanContractPaymentOptionItem DirectDebit { get; } = new EnergyPlanContractPaymentOptionItem(DirectDebitValue);
        /// <summary> BPAY. </summary>
        public static EnergyPlanContractPaymentOptionItem Bpay { get; } = new EnergyPlanContractPaymentOptionItem(BpayValue);
        /// <summary> OTHER. </summary>
        public static EnergyPlanContractPaymentOptionItem Other { get; } = new EnergyPlanContractPaymentOptionItem(OtherValue);
        /// <summary> Determines if two <see cref="EnergyPlanContractPaymentOptionItem"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanContractPaymentOptionItem left, EnergyPlanContractPaymentOptionItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanContractPaymentOptionItem"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanContractPaymentOptionItem left, EnergyPlanContractPaymentOptionItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanContractPaymentOptionItem"/>. </summary>
        public static implicit operator EnergyPlanContractPaymentOptionItem(string value) => new EnergyPlanContractPaymentOptionItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanContractPaymentOptionItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanContractPaymentOptionItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
