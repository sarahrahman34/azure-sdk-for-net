// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines modifiable attributes of an Experiment. </summary>
    public partial class ExperimentPatch
    {
        /// <summary> Initializes a new instance of ExperimentPatch. </summary>
        public ExperimentPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The description of the intent or details of the Experiment. </summary>
        public string Description { get; set; }
        /// <summary> The state of the Experiment. </summary>
        public State? EnabledState { get; set; }
    }
}
