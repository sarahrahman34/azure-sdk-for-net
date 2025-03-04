// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ManagedDiskDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceGroupId");
            writer.WriteStringValue(ResourceGroupId);
            writer.WritePropertyName("stagingStorageAccountId");
            writer.WriteStringValue(StagingStorageAccountId);
            writer.WritePropertyName("dataAccountType");
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(SharePassword))
            {
                writer.WritePropertyName("sharePassword");
                writer.WriteStringValue(SharePassword);
            }
            writer.WriteEndObject();
        }

        internal static ManagedDiskDetails DeserializeManagedDiskDetails(JsonElement element)
        {
            string resourceGroupId = default;
            string stagingStorageAccountId = default;
            DataAccountType dataAccountType = default;
            Optional<string> sharePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGroupId"))
                {
                    resourceGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stagingStorageAccountId"))
                {
                    stagingStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataAccountType"))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("sharePassword"))
                {
                    sharePassword = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedDiskDetails(dataAccountType, sharePassword.Value, resourceGroupId, stagingStorageAccountId);
        }
    }
}
