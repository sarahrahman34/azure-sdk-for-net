// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Should this parameter be visible to arm and passed in the parameters argument when executing. </summary>
    public readonly partial struct VisibilityParameterEnum : IEquatable<VisibilityParameterEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VisibilityParameterEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VisibilityParameterEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VisibleValue = "Visible";
        private const string HiddenValue = "Hidden";

        /// <summary> Visible. </summary>
        public static VisibilityParameterEnum Visible { get; } = new VisibilityParameterEnum(VisibleValue);
        /// <summary> Hidden. </summary>
        public static VisibilityParameterEnum Hidden { get; } = new VisibilityParameterEnum(HiddenValue);
        /// <summary> Determines if two <see cref="VisibilityParameterEnum"/> values are the same. </summary>
        public static bool operator ==(VisibilityParameterEnum left, VisibilityParameterEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VisibilityParameterEnum"/> values are not the same. </summary>
        public static bool operator !=(VisibilityParameterEnum left, VisibilityParameterEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VisibilityParameterEnum"/>. </summary>
        public static implicit operator VisibilityParameterEnum(string value) => new VisibilityParameterEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VisibilityParameterEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VisibilityParameterEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
