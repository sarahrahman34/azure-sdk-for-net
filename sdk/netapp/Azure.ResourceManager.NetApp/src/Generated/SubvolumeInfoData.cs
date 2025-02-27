// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class representing the SubvolumeInfo data model. </summary>
    public partial class SubvolumeInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of SubvolumeInfoData. </summary>
        public SubvolumeInfoData()
        {
        }

        /// <summary> Initializes a new instance of SubvolumeInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="path"> Path to the subvolume. </param>
        /// <param name="size"> Truncate subvolume to the provided size in bytes. </param>
        /// <param name="parentPath"> parent path to the subvolume. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        internal SubvolumeInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string path, long? size, string parentPath, string provisioningState) : base(id, name, resourceType, systemData)
        {
            Path = path;
            Size = size;
            ParentPath = parentPath;
            ProvisioningState = provisioningState;
        }

        /// <summary> Path to the subvolume. </summary>
        public string Path { get; set; }
        /// <summary> Truncate subvolume to the provided size in bytes. </summary>
        public long? Size { get; set; }
        /// <summary> parent path to the subvolume. </summary>
        public string ParentPath { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
    }
}
