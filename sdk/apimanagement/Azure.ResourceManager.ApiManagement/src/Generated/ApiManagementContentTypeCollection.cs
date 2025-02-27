// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementContentTypeResource" /> and their operations.
    /// Each <see cref="ApiManagementContentTypeResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementContentTypeCollection" /> instance call the GetApiManagementContentTypes method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementContentTypeCollection : ArmCollection, IEnumerable<ApiManagementContentTypeResource>, IAsyncEnumerable<ApiManagementContentTypeResource>
    {
        private readonly ClientDiagnostics _apiManagementContentTypeContentTypeClientDiagnostics;
        private readonly ContentTypeRestOperations _apiManagementContentTypeContentTypeRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementContentTypeCollection"/> class for mocking. </summary>
        protected ApiManagementContentTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementContentTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementContentTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementContentTypeContentTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementContentTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementContentTypeResource.ResourceType, out string apiManagementContentTypeContentTypeApiVersion);
            _apiManagementContentTypeContentTypeRestClient = new ContentTypeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementContentTypeContentTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Custom content types&apos; identifiers need to start with the `c-` prefix. Built-in content types can&apos;t be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementContentTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string contentTypeId, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementContentTypeResource>(Response.FromValue(new ApiManagementContentTypeResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints. Custom content types&apos; identifiers need to start with the `c-` prefix. Built-in content types can&apos;t be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual ArmOperation<ApiManagementContentTypeResource> CreateOrUpdate(WaitUntil waitUntil, string contentTypeId, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementContentTypeResource>(Response.FromValue(new ApiManagementContentTypeResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementContentTypeResource>> GetAsync(string contentTypeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementContentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the developer portal&apos;s content type. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual Response<ApiManagementContentTypeResource> Get(string contentTypeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementContentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the developer portal&apos;s content types. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes
        /// Operation Id: ContentType_ListByService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementContentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementContentTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiManagementContentTypeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementContentTypeContentTypeRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementContentTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiManagementContentTypeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _apiManagementContentTypeContentTypeRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementContentTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the developer portal&apos;s content types. Content types describe content items&apos; properties, validation rules, and constraints.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes
        /// Operation Id: ContentType_ListByService
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementContentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementContentTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApiManagementContentTypeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementContentTypeContentTypeRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementContentTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiManagementContentTypeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _apiManagementContentTypeContentTypeRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApiManagementContentTypeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string contentTypeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementContentTypeContentTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/contentTypes/{contentTypeId}
        /// Operation Id: ContentType_Get
        /// </summary>
        /// <param name="contentTypeId"> Content type identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentTypeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentTypeId"/> is null. </exception>
        public virtual Response<bool> Exists(string contentTypeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentTypeId, nameof(contentTypeId));

            using var scope = _apiManagementContentTypeContentTypeClientDiagnostics.CreateScope("ApiManagementContentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementContentTypeContentTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentTypeId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementContentTypeResource> IEnumerable<ApiManagementContentTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementContentTypeResource> IAsyncEnumerable<ApiManagementContentTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
