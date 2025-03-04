// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxSecret
    {
        internal static DataBoxSecret DeserializeDataBoxSecret(JsonElement element)
        {
            Optional<string> deviceSerialNumber = default;
            Optional<string> devicePassword = default;
            Optional<IReadOnlyList<ApplianceNetworkConfiguration>> networkConfigurations = default;
            Optional<string> encodedValidationCertPubKey = default;
            Optional<IReadOnlyList<AccountCredentialDetails>> accountCredentialDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceSerialNumber"))
                {
                    deviceSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devicePassword"))
                {
                    devicePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApplianceNetworkConfiguration> array = new List<ApplianceNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceNetworkConfiguration.DeserializeApplianceNetworkConfiguration(item));
                    }
                    networkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("encodedValidationCertPubKey"))
                {
                    encodedValidationCertPubKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountCredentialDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AccountCredentialDetails> array = new List<AccountCredentialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AccountCredentialDetails.DeserializeAccountCredentialDetails(item));
                    }
                    accountCredentialDetails = array;
                    continue;
                }
            }
            return new DataBoxSecret(deviceSerialNumber.Value, devicePassword.Value, Optional.ToList(networkConfigurations), encodedValidationCertPubKey.Value, Optional.ToList(accountCredentialDetails));
        }
    }
}
