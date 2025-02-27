// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class TrackingInfo
    {
        internal static TrackingInfo DeserializeTrackingInfo(JsonElement element)
        {
            Optional<string> serialNumber = default;
            Optional<string> carrierName = default;
            Optional<string> trackingId = default;
            Optional<Uri> trackingUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trackingUrl = null;
                        continue;
                    }
                    trackingUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new TrackingInfo(serialNumber.Value, carrierName.Value, trackingId.Value, trackingUrl.Value);
        }
    }
}
