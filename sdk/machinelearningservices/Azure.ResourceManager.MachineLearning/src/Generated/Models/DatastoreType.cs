// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the datastore contents type. </summary>
    internal readonly partial struct DatastoreType : IEquatable<DatastoreType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatastoreType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatastoreType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureBlobValue = "AzureBlob";
        private const string AzureDataLakeGen1Value = "AzureDataLakeGen1";
        private const string AzureDataLakeGen2Value = "AzureDataLakeGen2";
        private const string AzureFileValue = "AzureFile";
        private const string HdfsValue = "Hdfs";

        /// <summary> AzureBlob. </summary>
        public static DatastoreType AzureBlob { get; } = new DatastoreType(AzureBlobValue);
        /// <summary> AzureDataLakeGen1. </summary>
        public static DatastoreType AzureDataLakeGen1 { get; } = new DatastoreType(AzureDataLakeGen1Value);
        /// <summary> AzureDataLakeGen2. </summary>
        public static DatastoreType AzureDataLakeGen2 { get; } = new DatastoreType(AzureDataLakeGen2Value);
        /// <summary> AzureFile. </summary>
        public static DatastoreType AzureFile { get; } = new DatastoreType(AzureFileValue);
        /// <summary> Hdfs. </summary>
        public static DatastoreType Hdfs { get; } = new DatastoreType(HdfsValue);
        /// <summary> Determines if two <see cref="DatastoreType"/> values are the same. </summary>
        public static bool operator ==(DatastoreType left, DatastoreType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatastoreType"/> values are not the same. </summary>
        public static bool operator !=(DatastoreType left, DatastoreType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatastoreType"/>. </summary>
        public static implicit operator DatastoreType(string value) => new DatastoreType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatastoreType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatastoreType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
