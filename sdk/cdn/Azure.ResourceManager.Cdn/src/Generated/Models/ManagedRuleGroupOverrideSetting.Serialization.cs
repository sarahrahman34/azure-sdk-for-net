// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ManagedRuleGroupOverrideSetting : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleGroupName");
            writer.WriteStringValue(RuleGroupName);
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleGroupOverrideSetting DeserializeManagedRuleGroupOverrideSetting(JsonElement element)
        {
            string ruleGroupName = default;
            Optional<IList<ManagedRuleOverrideSetting>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"))
                {
                    ruleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleOverrideSetting> array = new List<ManagedRuleOverrideSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleOverrideSetting.DeserializeManagedRuleOverrideSetting(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new ManagedRuleGroupOverrideSetting(ruleGroupName, Optional.ToList(rules));
        }
    }
}
