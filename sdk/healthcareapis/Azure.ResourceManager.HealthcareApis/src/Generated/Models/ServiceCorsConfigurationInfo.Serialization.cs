// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class ServiceCorsConfigurationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins");
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers");
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Methods))
            {
                writer.WritePropertyName("methods");
                writer.WriteStartArray();
                foreach (var item in Methods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxAge))
            {
                writer.WritePropertyName("maxAge");
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (Optional.IsDefined(AllowCredentials))
            {
                writer.WritePropertyName("allowCredentials");
                writer.WriteBooleanValue(AllowCredentials.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceCorsConfigurationInfo DeserializeServiceCorsConfigurationInfo(JsonElement element)
        {
            Optional<IList<string>> origins = default;
            Optional<IList<string>> headers = default;
            Optional<IList<string>> methods = default;
            Optional<int> maxAge = default;
            Optional<bool> allowCredentials = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    origins = array;
                    continue;
                }
                if (property.NameEquals("headers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("methods"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    methods = array;
                    continue;
                }
                if (property.NameEquals("maxAge"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceCorsConfigurationInfo(Optional.ToList(origins), Optional.ToList(headers), Optional.ToList(methods), Optional.ToNullable(maxAge), Optional.ToNullable(allowCredentials));
        }
    }
}
