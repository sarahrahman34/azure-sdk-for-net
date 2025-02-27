// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary> A class representing the ServiceAlert data model. </summary>
    public partial class ServiceAlertData : ResourceData
    {
        /// <summary> Initializes a new instance of ServiceAlertData. </summary>
        public ServiceAlertData()
        {
        }

        /// <summary> Initializes a new instance of ServiceAlertData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="essentials"> This object contains consistent fields across different monitor services. </param>
        /// <param name="context"> Information specific to the monitor service that gives more contextual details about the alert. </param>
        /// <param name="egressConfig"> Config which would be used for displaying the data in portal. </param>
        internal ServiceAlertData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ServiceAlertEssentials essentials, BinaryData context, BinaryData egressConfig) : base(id, name, resourceType, systemData)
        {
            Essentials = essentials;
            Context = context;
            EgressConfig = egressConfig;
        }

        /// <summary> This object contains consistent fields across different monitor services. </summary>
        public ServiceAlertEssentials Essentials { get; set; }
        /// <summary>
        /// Information specific to the monitor service that gives more contextual details about the alert..
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
        public BinaryData Context { get; }
        /// <summary>
        /// Config which would be used for displaying the data in portal..
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
        public BinaryData EgressConfig { get; }
    }
}
