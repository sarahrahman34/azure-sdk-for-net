// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Lookup activity. </summary>
    public partial class LookupActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of LookupActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="source">
        /// Dataset-specific source properties, same as copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="AzureBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="dataset"> Lookup activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="source"/> or <paramref name="dataset"/> is null. </exception>
        public LookupActivity(string name, CopyActivitySource source, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Source = source;
            Dataset = dataset;
            ActivityType = "Lookup";
        }

        /// <summary> Initializes a new instance of LookupActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="source">
        /// Dataset-specific source properties, same as copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="AzureBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </param>
        /// <param name="dataset"> Lookup activity dataset reference. </param>
        /// <param name="firstRowOnly"> Whether to return first row or all rows. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        internal LookupActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, CopyActivitySource source, DatasetReference dataset, BinaryData firstRowOnly) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Source = source;
            Dataset = dataset;
            FirstRowOnly = firstRowOnly;
            ActivityType = activityType ?? "Lookup";
        }

        /// <summary>
        /// Dataset-specific source properties, same as copy activity source.
        /// Please note <see cref="CopyActivitySource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonMwsSource"/>, <see cref="AmazonRdsForOracleSource"/>, <see cref="AmazonRdsForSqlServerSource"/>, <see cref="AmazonRedshiftSource"/>, <see cref="AvroSource"/>, <see cref="AzureBlobFSSource"/>, <see cref="AzureDataExplorerSource"/>, <see cref="AzureDataLakeStoreSource"/>, <see cref="AzureDatabricksDeltaLakeSource"/>, <see cref="AzureMariaDBSource"/>, <see cref="AzureMySqlSource"/>, <see cref="AzurePostgreSqlSource"/>, <see cref="AzureSqlSource"/>, <see cref="AzureTableSource"/>, <see cref="BinarySource"/>, <see cref="AzureBlobSource"/>, <see cref="CassandraSource"/>, <see cref="CommonDataServiceForAppsSource"/>, <see cref="ConcurSource"/>, <see cref="CosmosDBMongoDBApiSource"/>, <see cref="CosmosDBSqlApiSource"/>, <see cref="CouchbaseSource"/>, <see cref="Db2Source"/>, <see cref="DelimitedTextSource"/>, <see cref="DocumentDBCollectionSource"/>, <see cref="DrillSource"/>, <see cref="DynamicsAXSource"/>, <see cref="DynamicsCrmSource"/>, <see cref="DynamicsSource"/>, <see cref="EloquaSource"/>, <see cref="ExcelSource"/>, <see cref="FileSystemSource"/>, <see cref="GoogleAdWordsSource"/>, <see cref="GoogleBigQuerySource"/>, <see cref="GreenplumSource"/>, <see cref="HBaseSource"/>, <see cref="HdfsSource"/>, <see cref="HiveSource"/>, <see cref="HttpFileSource"/>, <see cref="HubspotSource"/>, <see cref="ImpalaSource"/>, <see cref="InformixSource"/>, <see cref="JiraSource"/>, <see cref="JsonSource"/>, <see cref="MagentoSource"/>, <see cref="MariaDBSource"/>, <see cref="MarketoSource"/>, <see cref="MicrosoftAccessSource"/>, <see cref="MongoDBAtlasSource"/>, <see cref="MongoDBSource"/>, <see cref="MongoDBV2Source"/>, <see cref="MySqlSource"/>, <see cref="NetezzaSource"/>, <see cref="ODataSource"/>, <see cref="OdbcSource"/>, <see cref="Office365Source"/>, <see cref="OracleServiceCloudSource"/>, <see cref="OracleSource"/>, <see cref="OrcSource"/>, <see cref="ParquetSource"/>, <see cref="PaypalSource"/>, <see cref="PhoenixSource"/>, <see cref="PostgreSqlSource"/>, <see cref="PrestoSource"/>, <see cref="QuickBooksSource"/>, <see cref="RelationalSource"/>, <see cref="ResponsysSource"/>, <see cref="RestSource"/>, <see cref="SalesforceMarketingCloudSource"/>, <see cref="SalesforceServiceCloudSource"/>, <see cref="SalesforceSource"/>, <see cref="SapBwSource"/>, <see cref="SapCloudForCustomerSource"/>, <see cref="SapEccSource"/>, <see cref="SapHanaSource"/>, <see cref="SapOdpSource"/>, <see cref="SapOpenHubSource"/>, <see cref="SapTableSource"/>, <see cref="ServiceNowSource"/>, <see cref="SharePointOnlineListSource"/>, <see cref="ShopifySource"/>, <see cref="SnowflakeSource"/>, <see cref="SparkSource"/>, <see cref="SqlDWSource"/>, <see cref="SqlMISource"/>, <see cref="SqlServerSource"/>, <see cref="SqlSource"/>, <see cref="SquareSource"/>, <see cref="SybaseSource"/>, <see cref="TabularSource"/>, <see cref="TeradataSource"/>, <see cref="VerticaSource"/>, <see cref="WebSource"/>, <see cref="XeroSource"/>, <see cref="XmlSource"/> and <see cref="ZohoSource"/>.
        /// </summary>
        public CopyActivitySource Source { get; set; }
        /// <summary> Lookup activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary>
        /// Whether to return first row or all rows. Default value is true. Type: boolean (or Expression with resultType boolean)..
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
        public BinaryData FirstRowOnly { get; set; }
    }
}
