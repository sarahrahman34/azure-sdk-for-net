// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Encryption key containing details about key to encrypt different keys. </summary>
    public partial class KeyEncryptionKey
    {
        /// <summary> Initializes a new instance of KeyEncryptionKey. </summary>
        /// <param name="kekType"> Type of encryption key used for key encryption. </param>
        public KeyEncryptionKey(KekType kekType)
        {
            KekType = kekType;
        }

        /// <summary> Initializes a new instance of KeyEncryptionKey. </summary>
        /// <param name="kekType"> Type of encryption key used for key encryption. </param>
        /// <param name="identityProperties"> Managed identity properties used for key encryption. </param>
        /// <param name="kekUri"> Key encryption key. It is required in case of Customer managed KekType. </param>
        /// <param name="kekVaultResourceId"> Kek vault resource id. It is required in case of Customer managed KekType. </param>
        internal KeyEncryptionKey(KekType kekType, IdentityProperties identityProperties, Uri kekUri, string kekVaultResourceId)
        {
            KekType = kekType;
            IdentityProperties = identityProperties;
            KekUri = kekUri;
            KekVaultResourceId = kekVaultResourceId;
        }

        /// <summary> Type of encryption key used for key encryption. </summary>
        public KekType KekType { get; set; }
        /// <summary> Managed identity properties used for key encryption. </summary>
        public IdentityProperties IdentityProperties { get; set; }
        /// <summary> Key encryption key. It is required in case of Customer managed KekType. </summary>
        public Uri KekUri { get; set; }
        /// <summary> Kek vault resource id. It is required in case of Customer managed KekType. </summary>
        public string KekVaultResourceId { get; set; }
    }
}
