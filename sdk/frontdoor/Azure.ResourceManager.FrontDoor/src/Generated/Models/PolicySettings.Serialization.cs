// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class PolicySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUrl");
                writer.WriteStringValue(RedirectUri.AbsoluteUri);
            }
            if (Optional.IsDefined(CustomBlockResponseStatusCode))
            {
                writer.WritePropertyName("customBlockResponseStatusCode");
                writer.WriteNumberValue(CustomBlockResponseStatusCode.Value);
            }
            if (Optional.IsDefined(CustomBlockResponseBody))
            {
                writer.WritePropertyName("customBlockResponseBody");
                writer.WriteStringValue(CustomBlockResponseBody);
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck");
                writer.WriteStringValue(RequestBodyCheck.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PolicySettings DeserializePolicySettings(JsonElement element)
        {
            Optional<PolicyEnabledState> enabledState = default;
            Optional<PolicyMode> mode = default;
            Optional<Uri> redirectUrl = default;
            Optional<int> customBlockResponseStatusCode = default;
            Optional<string> customBlockResponseBody = default;
            Optional<PolicyRequestBodyCheck> requestBodyCheck = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledState = new PolicyEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new PolicyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("redirectUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        redirectUrl = null;
                        continue;
                    }
                    redirectUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customBlockResponseStatusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customBlockResponseStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customBlockResponseBody"))
                {
                    customBlockResponseBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestBodyCheck = new PolicyRequestBodyCheck(property.Value.GetString());
                    continue;
                }
            }
            return new PolicySettings(Optional.ToNullable(enabledState), Optional.ToNullable(mode), redirectUrl.Value, Optional.ToNullable(customBlockResponseStatusCode), customBlockResponseBody.Value, Optional.ToNullable(requestBodyCheck));
        }
    }
}
