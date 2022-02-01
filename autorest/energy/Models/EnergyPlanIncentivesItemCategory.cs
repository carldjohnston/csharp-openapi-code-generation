// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The type of the incentive. </summary>
    public readonly partial struct EnergyPlanIncentivesItemCategory : IEquatable<EnergyPlanIncentivesItemCategory>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanIncentivesItemCategory"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanIncentivesItemCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GiftValue = "GIFT";
        private const string AccountCreditValue = "ACCOUNT_CREDIT";
        private const string OtherValue = "OTHER";

        /// <summary> GIFT. </summary>
        public static EnergyPlanIncentivesItemCategory Gift { get; } = new EnergyPlanIncentivesItemCategory(GiftValue);
        /// <summary> ACCOUNT_CREDIT. </summary>
        public static EnergyPlanIncentivesItemCategory AccountCredit { get; } = new EnergyPlanIncentivesItemCategory(AccountCreditValue);
        /// <summary> OTHER. </summary>
        public static EnergyPlanIncentivesItemCategory Other { get; } = new EnergyPlanIncentivesItemCategory(OtherValue);
        /// <summary> Determines if two <see cref="EnergyPlanIncentivesItemCategory"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanIncentivesItemCategory left, EnergyPlanIncentivesItemCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanIncentivesItemCategory"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanIncentivesItemCategory left, EnergyPlanIncentivesItemCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanIncentivesItemCategory"/>. </summary>
        public static implicit operator EnergyPlanIncentivesItemCategory(string value) => new EnergyPlanIncentivesItemCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanIncentivesItemCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanIncentivesItemCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
