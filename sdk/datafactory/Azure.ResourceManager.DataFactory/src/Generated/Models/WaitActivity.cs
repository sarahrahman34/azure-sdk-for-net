// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> This activity suspends pipeline execution for the specified interval. </summary>
    public partial class WaitActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of WaitActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="waitTimeInSeconds"/> is null. </exception>
        public WaitActivity(string name, BinaryData waitTimeInSeconds) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (waitTimeInSeconds == null)
            {
                throw new ArgumentNullException(nameof(waitTimeInSeconds));
            }

            WaitTimeInSeconds = waitTimeInSeconds;
            ActivityType = "Wait";
        }

        /// <summary> Initializes a new instance of WaitActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. </param>
        internal WaitActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, BinaryData waitTimeInSeconds) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            WaitTimeInSeconds = waitTimeInSeconds;
            ActivityType = activityType ?? "Wait";
        }

        /// <summary>
        /// Duration in seconds..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData WaitTimeInSeconds { get; set; }
    }
}
