// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class representing the VolumeQuotaRule data model. </summary>
    public partial class VolumeQuotaRuleData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VolumeQuotaRuleData. </summary>
        /// <param name="location"> The location. </param>
        public VolumeQuotaRuleData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of VolumeQuotaRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Gets the status of the VolumeQuotaRule at the time the operation was called. </param>
        /// <param name="quotaSizeInKiBs"> Size of quota. </param>
        /// <param name="quotaType"> Type of quota. </param>
        /// <param name="quotaTarget"> UserID/GroupID/SID based on the quota target type. UserID and groupID can be found by running ‘id’ or ‘getent’ command for the user or group and SID can be found by running &lt;wmic useraccount where name=&apos;user-name&apos; get sid&gt;. </param>
        internal VolumeQuotaRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, long? quotaSizeInKiBs, Type? quotaType, string quotaTarget) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            QuotaSizeInKiBs = quotaSizeInKiBs;
            QuotaType = quotaType;
            QuotaTarget = quotaTarget;
        }

        /// <summary> Gets the status of the VolumeQuotaRule at the time the operation was called. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Size of quota. </summary>
        public long? QuotaSizeInKiBs { get; set; }
        /// <summary> Type of quota. </summary>
        public Type? QuotaType { get; set; }
        /// <summary> UserID/GroupID/SID based on the quota target type. UserID and groupID can be found by running ‘id’ or ‘getent’ command for the user or group and SID can be found by running &lt;wmic useraccount where name=&apos;user-name&apos; get sid&gt;. </summary>
        public string QuotaTarget { get; set; }
    }
}
