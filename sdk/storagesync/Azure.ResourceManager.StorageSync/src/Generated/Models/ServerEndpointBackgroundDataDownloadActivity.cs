// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Background data download activity object. </summary>
    public partial class ServerEndpointBackgroundDataDownloadActivity
    {
        /// <summary> Initializes a new instance of ServerEndpointBackgroundDataDownloadActivity. </summary>
        internal ServerEndpointBackgroundDataDownloadActivity()
        {
        }

        /// <summary> Initializes a new instance of ServerEndpointBackgroundDataDownloadActivity. </summary>
        /// <param name="timestamp"> Timestamp when properties were updated. </param>
        /// <param name="startedTimestamp"> Timestamp when the operation started. </param>
        /// <param name="percentProgress"> Progress percentage. </param>
        /// <param name="downloadedBytes"> Running count of bytes downloaded. </param>
        internal ServerEndpointBackgroundDataDownloadActivity(DateTimeOffset? timestamp, DateTimeOffset? startedTimestamp, int? percentProgress, long? downloadedBytes)
        {
            Timestamp = timestamp;
            StartedTimestamp = startedTimestamp;
            PercentProgress = percentProgress;
            DownloadedBytes = downloadedBytes;
        }

        /// <summary> Timestamp when properties were updated. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Timestamp when the operation started. </summary>
        public DateTimeOffset? StartedTimestamp { get; }
        /// <summary> Progress percentage. </summary>
        public int? PercentProgress { get; }
        /// <summary> Running count of bytes downloaded. </summary>
        public long? DownloadedBytes { get; }
    }
}
