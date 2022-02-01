// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Agl.Cdr.Common
{
    /// <summary> Enumeration of values indicating the purpose of the physical address. </summary>
    public readonly partial struct CommonPhysicalAddressWithPurpose2Purpose : IEquatable<CommonPhysicalAddressWithPurpose2Purpose>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CommonPhysicalAddressWithPurpose2Purpose"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommonPhysicalAddressWithPurpose2Purpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MailValue = "MAIL";
        private const string OtherValue = "OTHER";
        private const string PhysicalValue = "PHYSICAL";
        private const string RegisteredValue = "REGISTERED";
        private const string WorkValue = "WORK";

        /// <summary> MAIL. </summary>
        public static CommonPhysicalAddressWithPurpose2Purpose Mail { get; } = new CommonPhysicalAddressWithPurpose2Purpose(MailValue);
        /// <summary> OTHER. </summary>
        public static CommonPhysicalAddressWithPurpose2Purpose Other { get; } = new CommonPhysicalAddressWithPurpose2Purpose(OtherValue);
        /// <summary> PHYSICAL. </summary>
        public static CommonPhysicalAddressWithPurpose2Purpose Physical { get; } = new CommonPhysicalAddressWithPurpose2Purpose(PhysicalValue);
        /// <summary> REGISTERED. </summary>
        public static CommonPhysicalAddressWithPurpose2Purpose Registered { get; } = new CommonPhysicalAddressWithPurpose2Purpose(RegisteredValue);
        /// <summary> WORK. </summary>
        public static CommonPhysicalAddressWithPurpose2Purpose Work { get; } = new CommonPhysicalAddressWithPurpose2Purpose(WorkValue);
        /// <summary> Determines if two <see cref="CommonPhysicalAddressWithPurpose2Purpose"/> values are the same. </summary>
        public static bool operator ==(CommonPhysicalAddressWithPurpose2Purpose left, CommonPhysicalAddressWithPurpose2Purpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommonPhysicalAddressWithPurpose2Purpose"/> values are not the same. </summary>
        public static bool operator !=(CommonPhysicalAddressWithPurpose2Purpose left, CommonPhysicalAddressWithPurpose2Purpose right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommonPhysicalAddressWithPurpose2Purpose"/>. </summary>
        public static implicit operator CommonPhysicalAddressWithPurpose2Purpose(string value) => new CommonPhysicalAddressWithPurpose2Purpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommonPhysicalAddressWithPurpose2Purpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommonPhysicalAddressWithPurpose2Purpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}