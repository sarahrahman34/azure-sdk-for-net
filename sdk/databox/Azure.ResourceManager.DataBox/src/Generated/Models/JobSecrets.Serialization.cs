// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class JobSecrets
    {
        internal static JobSecrets DeserializeJobSecrets(JsonElement element)
        {
            if (element.TryGetProperty("jobSecretsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataboxJobSecrets.DeserializeDataboxJobSecrets(element);
                    case "DataBoxCustomerDisk": return CustomerDiskJobSecrets.DeserializeCustomerDiskJobSecrets(element);
                    case "DataBoxDisk": return DataBoxDiskJobSecrets.DeserializeDataBoxDiskJobSecrets(element);
                    case "DataBoxHeavy": return DataBoxHeavyJobSecrets.DeserializeDataBoxHeavyJobSecrets(element);
                }
            }
            ClassDiscriminator jobSecretsType = default;
            Optional<DcAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobSecretsType"))
                {
                    jobSecretsType = property.Value.GetString().ToClassDiscriminator();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dcAccessSecurityCode = DcAccessSecurityCode.DeserializeDcAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.ToString());
                    continue;
                }
            }
            return new JobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value);
        }
    }
}
