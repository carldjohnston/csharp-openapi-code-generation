// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Common
{
    /// <summary> The purpose for the email, as specified by the customer (Enumeration). </summary>
    public readonly partial struct CommonEmailAddressPurpose : IEquatable<CommonEmailAddressPurpose>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CommonEmailAddressPurpose"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommonEmailAddressPurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HomeValue = "HOME";
        private const string OtherValue = "OTHER";
        private const string UnspecifiedValue = "UNSPECIFIED";
        private const string WorkValue = "WORK";

        /// <summary> HOME. </summary>
        public static CommonEmailAddressPurpose Home { get; } = new CommonEmailAddressPurpose(HomeValue);
        /// <summary> OTHER. </summary>
        public static CommonEmailAddressPurpose Other { get; } = new CommonEmailAddressPurpose(OtherValue);
        /// <summary> UNSPECIFIED. </summary>
        public static CommonEmailAddressPurpose Unspecified { get; } = new CommonEmailAddressPurpose(UnspecifiedValue);
        /// <summary> WORK. </summary>
        public static CommonEmailAddressPurpose Work { get; } = new CommonEmailAddressPurpose(WorkValue);
        /// <summary> Determines if two <see cref="CommonEmailAddressPurpose"/> values are the same. </summary>
        public static bool operator ==(CommonEmailAddressPurpose left, CommonEmailAddressPurpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommonEmailAddressPurpose"/> values are not the same. </summary>
        public static bool operator !=(CommonEmailAddressPurpose left, CommonEmailAddressPurpose right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommonEmailAddressPurpose"/>. </summary>
        public static implicit operator CommonEmailAddressPurpose(string value) => new CommonEmailAddressPurpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommonEmailAddressPurpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommonEmailAddressPurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
