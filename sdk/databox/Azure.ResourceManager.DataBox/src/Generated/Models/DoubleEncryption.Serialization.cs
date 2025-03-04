// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class DoubleEncryptionExtensions
    {
        public static string ToSerialString(this DoubleEncryption value) => value switch
        {
            DoubleEncryption.Enabled => "Enabled",
            DoubleEncryption.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DoubleEncryption value.")
        };

        public static DoubleEncryption ToDoubleEncryption(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return DoubleEncryption.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return DoubleEncryption.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DoubleEncryption value.");
        }
    }
}
