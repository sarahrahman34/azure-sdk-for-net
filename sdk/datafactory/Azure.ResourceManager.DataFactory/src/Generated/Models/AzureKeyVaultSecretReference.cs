// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Key Vault secret reference. </summary>
    public partial class AzureKeyVaultSecretReference : FactorySecretBaseDefinition
    {
        /// <summary> Initializes a new instance of AzureKeyVaultSecretReference. </summary>
        /// <param name="store"> The Azure Key Vault linked service reference. </param>
        /// <param name="secretName"> The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="store"/> or <paramref name="secretName"/> is null. </exception>
        public AzureKeyVaultSecretReference(FactoryLinkedServiceReference store, BinaryData secretName)
        {
            if (store == null)
            {
                throw new ArgumentNullException(nameof(store));
            }
            if (secretName == null)
            {
                throw new ArgumentNullException(nameof(secretName));
            }

            Store = store;
            SecretName = secretName;
            SecretBaseType = "AzureKeyVaultSecret";
        }

        /// <summary> Initializes a new instance of AzureKeyVaultSecretReference. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        /// <param name="store"> The Azure Key Vault linked service reference. </param>
        /// <param name="secretName"> The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string). </param>
        /// <param name="secretVersion"> The version of the secret in Azure Key Vault. The default value is the latest version of the secret. Type: string (or Expression with resultType string). </param>
        internal AzureKeyVaultSecretReference(string secretBaseType, FactoryLinkedServiceReference store, BinaryData secretName, BinaryData secretVersion) : base(secretBaseType)
        {
            Store = store;
            SecretName = secretName;
            SecretVersion = secretVersion;
            SecretBaseType = secretBaseType ?? "AzureKeyVaultSecret";
        }

        /// <summary> The Azure Key Vault linked service reference. </summary>
        public FactoryLinkedServiceReference Store { get; set; }
        /// <summary>
        /// The name of the secret in Azure Key Vault. Type: string (or Expression with resultType string)..
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
        public BinaryData SecretName { get; set; }
        /// <summary>
        /// The version of the secret in Azure Key Vault. The default value is the latest version of the secret. Type: string (or Expression with resultType string)..
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
        public BinaryData SecretVersion { get; set; }
    }
}
