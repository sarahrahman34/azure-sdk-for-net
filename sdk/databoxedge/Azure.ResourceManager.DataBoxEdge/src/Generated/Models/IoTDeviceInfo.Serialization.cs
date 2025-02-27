// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class IoTDeviceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deviceId");
            writer.WriteStringValue(DeviceId);
            writer.WritePropertyName("ioTHostHub");
            writer.WriteStringValue(IoTHostHub);
            if (Optional.IsDefined(IoTHostHubId))
            {
                writer.WritePropertyName("ioTHostHubId");
                writer.WriteStringValue(IoTHostHubId);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication");
                writer.WriteObjectValue(Authentication);
            }
            writer.WriteEndObject();
        }

        internal static IoTDeviceInfo DeserializeIoTDeviceInfo(JsonElement element)
        {
            string deviceId = default;
            string ioTHostHub = default;
            Optional<string> ioTHostHubId = default;
            Optional<Authentication> authentication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHub"))
                {
                    ioTHostHub = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ioTHostHubId"))
                {
                    ioTHostHubId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authentication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authentication = Authentication.DeserializeAuthentication(property.Value);
                    continue;
                }
            }
            return new IoTDeviceInfo(deviceId, ioTHostHub, ioTHostHubId.Value, authentication.Value);
        }
    }
}
