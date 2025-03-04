// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS package execution log location. </summary>
    public partial class SsisLogLocation
    {
        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="locationType"> The type of SSIS log location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logPath"/> is null. </exception>
        public SsisLogLocation(BinaryData logPath, SsisLogLocationType locationType)
        {
            if (logPath == null)
            {
                throw new ArgumentNullException(nameof(logPath));
            }

            LogPath = logPath;
            LocationType = locationType;
        }

        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="locationType"> The type of SSIS log location. </param>
        /// <param name="accessCredential"> The package execution log access credential. </param>
        /// <param name="logRefreshInterval"> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        internal SsisLogLocation(BinaryData logPath, SsisLogLocationType locationType, SsisAccessCredential accessCredential, BinaryData logRefreshInterval)
        {
            LogPath = logPath;
            LocationType = locationType;
            AccessCredential = accessCredential;
            LogRefreshInterval = logRefreshInterval;
        }

        /// <summary>
        /// The SSIS package execution log path. Type: string (or Expression with resultType string)..
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
        public BinaryData LogPath { get; set; }
        /// <summary> The type of SSIS log location. </summary>
        public SsisLogLocationType LocationType { get; set; }
        /// <summary> The package execution log access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary>
        /// Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..
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
        public BinaryData LogRefreshInterval { get; set; }
    }
}
