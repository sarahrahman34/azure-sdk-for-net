// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of ClassificationPolicy. </summary>
    public partial class ClassificationPolicyItem
    {
        /// <summary> Initializes a new instance of ClassificationPolicyItem. </summary>
        internal ClassificationPolicyItem()
        {
        }

        /// <summary> Initializes a new instance of ClassificationPolicyItem. </summary>
        /// <param name="classificationPolicy"> A container for the rules that govern how jobs are classified. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        internal ClassificationPolicyItem(ClassificationPolicy classificationPolicy, string etag)
        {
            ClassificationPolicy = classificationPolicy;
            Etag = etag;
        }

        /// <summary> A container for the rules that govern how jobs are classified. </summary>
        public ClassificationPolicy ClassificationPolicy { get; }
        /// <summary> (Optional) The Concurrency Token. </summary>
        public string Etag { get; }
    }
}
