// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure keyVault Properties. </summary>
    public partial class EventHubsKeyVaultProperties
    {
        /// <summary> Initializes a new instance of EventHubsKeyVaultProperties. </summary>
        public EventHubsKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of EventHubsKeyVaultProperties. </summary>
        /// <param name="keyName"> Name of the Key from KeyVault. </param>
        /// <param name="keyVaultUri"> Uri of KeyVault. </param>
        /// <param name="keyVersion"> Key Version. </param>
        /// <param name="identity"></param>
        internal EventHubsKeyVaultProperties(string keyName, Uri keyVaultUri, string keyVersion, UserAssignedIdentityProperties identity)
        {
            KeyName = keyName;
            KeyVaultUri = keyVaultUri;
            KeyVersion = keyVersion;
            Identity = identity;
        }

        /// <summary> Name of the Key from KeyVault. </summary>
        public string KeyName { get; set; }
        /// <summary> Uri of KeyVault. </summary>
        public Uri KeyVaultUri { get; set; }
        /// <summary> Key Version. </summary>
        public string KeyVersion { get; set; }
        /// <summary> Gets or sets the identity. </summary>
        internal UserAssignedIdentityProperties Identity { get; set; }
        /// <summary> ARM ID of user Identity selected for encryption. </summary>
        public string UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new UserAssignedIdentityProperties();
                Identity.UserAssignedIdentity = value;
            }
        }
    }
}
