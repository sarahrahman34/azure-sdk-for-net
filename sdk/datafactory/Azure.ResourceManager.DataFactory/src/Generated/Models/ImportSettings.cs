// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Import command settings.
    /// Please note <see cref="ImportSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SnowflakeImportCopyCommand"/> and <see cref="AzureDatabricksDeltaLakeImportCommand"/>.
    /// </summary>
    public partial class ImportSettings
    {
        /// <summary> Initializes a new instance of ImportSettings. </summary>
        public ImportSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ImportSettings. </summary>
        /// <param name="importSettingsType"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ImportSettings(string importSettingsType, IDictionary<string, BinaryData> additionalProperties)
        {
            ImportSettingsType = importSettingsType;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The import setting type. </summary>
        internal string ImportSettingsType { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
