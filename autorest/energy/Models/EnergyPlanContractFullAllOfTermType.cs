// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Energy
{
    /// <summary> The term for the contract.  If absent assumes no specified term. </summary>
    public readonly partial struct EnergyPlanContractFullAllOfTermType : IEquatable<EnergyPlanContractFullAllOfTermType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EnergyPlanContractFullAllOfTermType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnergyPlanContractFullAllOfTermType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneYearValue = "1_YEAR";
        private const string TwoYearValue = "2_YEAR";
        private const string ThreeYearValue = "3_YEAR";
        private const string FourYearValue = "4_YEAR";
        private const string FiveYearValue = "5_YEAR";
        private const string OngoingValue = "ONGOING";
        private const string OtherValue = "OTHER";

        /// <summary> 1_YEAR. </summary>
        public static EnergyPlanContractFullAllOfTermType OneYear { get; } = new EnergyPlanContractFullAllOfTermType(OneYearValue);
        /// <summary> 2_YEAR. </summary>
        public static EnergyPlanContractFullAllOfTermType TwoYear { get; } = new EnergyPlanContractFullAllOfTermType(TwoYearValue);
        /// <summary> 3_YEAR. </summary>
        public static EnergyPlanContractFullAllOfTermType ThreeYear { get; } = new EnergyPlanContractFullAllOfTermType(ThreeYearValue);
        /// <summary> 4_YEAR. </summary>
        public static EnergyPlanContractFullAllOfTermType FourYear { get; } = new EnergyPlanContractFullAllOfTermType(FourYearValue);
        /// <summary> 5_YEAR. </summary>
        public static EnergyPlanContractFullAllOfTermType FiveYear { get; } = new EnergyPlanContractFullAllOfTermType(FiveYearValue);
        /// <summary> ONGOING. </summary>
        public static EnergyPlanContractFullAllOfTermType Ongoing { get; } = new EnergyPlanContractFullAllOfTermType(OngoingValue);
        /// <summary> OTHER. </summary>
        public static EnergyPlanContractFullAllOfTermType Other { get; } = new EnergyPlanContractFullAllOfTermType(OtherValue);
        /// <summary> Determines if two <see cref="EnergyPlanContractFullAllOfTermType"/> values are the same. </summary>
        public static bool operator ==(EnergyPlanContractFullAllOfTermType left, EnergyPlanContractFullAllOfTermType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnergyPlanContractFullAllOfTermType"/> values are not the same. </summary>
        public static bool operator !=(EnergyPlanContractFullAllOfTermType left, EnergyPlanContractFullAllOfTermType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnergyPlanContractFullAllOfTermType"/>. </summary>
        public static implicit operator EnergyPlanContractFullAllOfTermType(string value) => new EnergyPlanContractFullAllOfTermType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnergyPlanContractFullAllOfTermType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnergyPlanContractFullAllOfTermType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
