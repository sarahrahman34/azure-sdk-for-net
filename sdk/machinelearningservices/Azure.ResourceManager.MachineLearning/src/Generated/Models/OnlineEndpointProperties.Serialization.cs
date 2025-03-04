// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class OnlineEndpointProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Compute))
            {
                if (Compute != null)
                {
                    writer.WritePropertyName("compute");
                    writer.WriteStringValue(Compute);
                }
                else
                {
                    writer.WriteNull("compute");
                }
            }
            if (Optional.IsCollectionDefined(MirrorTraffic))
            {
                if (MirrorTraffic != null)
                {
                    writer.WritePropertyName("mirrorTraffic");
                    writer.WriteStartObject();
                    foreach (var item in MirrorTraffic)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("mirrorTraffic");
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                if (Traffic != null)
                {
                    writer.WritePropertyName("traffic");
                    writer.WriteStartObject();
                    foreach (var item in Traffic)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("traffic");
                }
            }
            writer.WritePropertyName("authMode");
            writer.WriteStringValue(AuthMode.ToString());
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(Keys))
            {
                if (Keys != null)
                {
                    writer.WritePropertyName("keys");
                    writer.WriteObjectValue(Keys);
                }
                else
                {
                    writer.WriteNull("keys");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties");
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WriteEndObject();
        }

        internal static OnlineEndpointProperties DeserializeOnlineEndpointProperties(JsonElement element)
        {
            Optional<string> compute = default;
            Optional<IDictionary<string, int>> mirrorTraffic = default;
            Optional<EndpointProvisioningState> provisioningState = default;
            Optional<PublicNetworkAccessType> publicNetworkAccess = default;
            Optional<IDictionary<string, int>> traffic = default;
            EndpointAuthMode authMode = default;
            Optional<string> description = default;
            Optional<EndpointAuthKeys> keys = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<Uri> scoringUri = default;
            Optional<Uri> swaggerUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        compute = null;
                        continue;
                    }
                    compute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mirrorTraffic"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        mirrorTraffic = null;
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    mirrorTraffic = dictionary;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new EndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("traffic"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        traffic = null;
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    traffic = dictionary;
                    continue;
                }
                if (property.NameEquals("authMode"))
                {
                    authMode = new EndpointAuthMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keys = null;
                        continue;
                    }
                    keys = EndpointAuthKeys.DeserializeEndpointAuthKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("scoringUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scoringUri = null;
                        continue;
                    }
                    scoringUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swaggerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        swaggerUri = null;
                        continue;
                    }
                    swaggerUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new OnlineEndpointProperties(authMode, description.Value, keys.Value, Optional.ToDictionary(properties), scoringUri.Value, swaggerUri.Value, compute.Value, Optional.ToDictionary(mirrorTraffic), Optional.ToNullable(provisioningState), Optional.ToNullable(publicNetworkAccess), Optional.ToDictionary(traffic));
        }
    }
}
