// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The definition of a parameter that can be provided to the policy. </summary>
    public partial class ArmPolicyParameter
    {
        /// <summary> Initializes a new instance of ArmPolicyParameter. </summary>
        public ArmPolicyParameter()
        {
            AllowedValues = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of ArmPolicyParameter. </summary>
        /// <param name="parameterType"> The data type of the parameter. </param>
        /// <param name="allowedValues"> The allowed values for the parameter. </param>
        /// <param name="defaultValue"> The default value for the parameter if no value is provided. </param>
        /// <param name="metadata"> General metadata for the parameter. </param>
        internal ArmPolicyParameter(ArmPolicyParameterType? parameterType, IList<BinaryData> allowedValues, BinaryData defaultValue, ParameterDefinitionsValueMetadata metadata)
        {
            ParameterType = parameterType;
            AllowedValues = allowedValues;
            DefaultValue = defaultValue;
            Metadata = metadata;
        }

        /// <summary> The data type of the parameter. </summary>
        public ArmPolicyParameterType? ParameterType { get; set; }
        /// <summary> The allowed values for the parameter. </summary>
        public IList<BinaryData> AllowedValues { get; }
        /// <summary>
        /// The default value for the parameter if no value is provided..
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
        public BinaryData DefaultValue { get; set; }
        /// <summary> General metadata for the parameter. </summary>
        public ParameterDefinitionsValueMetadata Metadata { get; set; }
    }
}
