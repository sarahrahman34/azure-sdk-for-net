// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Defines the metadata of AzureFunctionOutputDataSource. </summary>
    public partial class FunctionOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of FunctionOutputDataSource. </summary>
        public FunctionOutputDataSource()
        {
            OutputDataSourceType = "Microsoft.AzureFunction";
        }

        /// <summary> Initializes a new instance of FunctionOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="functionAppName"> The name of your Azure Functions app. </param>
        /// <param name="functionName"> The name of the function in your Azure Functions app. </param>
        /// <param name="apiKey"> If you want to use an Azure Function from another subscription, you can do so by providing the key to access your function. </param>
        /// <param name="maxBatchSize"> A property that lets you set the maximum size for each output batch that&apos;s sent to your Azure function. The input unit is in bytes. By default, this value is 262,144 bytes (256 KB). </param>
        /// <param name="maxBatchCount"> A property that lets you specify the maximum number of events in each batch that&apos;s sent to Azure Functions. The default value is 100. </param>
        internal FunctionOutputDataSource(string outputDataSourceType, string functionAppName, string functionName, string apiKey, int? maxBatchSize, int? maxBatchCount) : base(outputDataSourceType)
        {
            FunctionAppName = functionAppName;
            FunctionName = functionName;
            ApiKey = apiKey;
            MaxBatchSize = maxBatchSize;
            MaxBatchCount = maxBatchCount;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.AzureFunction";
        }

        /// <summary> The name of your Azure Functions app. </summary>
        public string FunctionAppName { get; set; }
        /// <summary> The name of the function in your Azure Functions app. </summary>
        public string FunctionName { get; set; }
        /// <summary> If you want to use an Azure Function from another subscription, you can do so by providing the key to access your function. </summary>
        public string ApiKey { get; set; }
        /// <summary> A property that lets you set the maximum size for each output batch that&apos;s sent to your Azure function. The input unit is in bytes. By default, this value is 262,144 bytes (256 KB). </summary>
        public int? MaxBatchSize { get; set; }
        /// <summary> A property that lets you specify the maximum number of events in each batch that&apos;s sent to Azure Functions. The default value is 100. </summary>
        public int? MaxBatchCount { get; set; }
    }
}
