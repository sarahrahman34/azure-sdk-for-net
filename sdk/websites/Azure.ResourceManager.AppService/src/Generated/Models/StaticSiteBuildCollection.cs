// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of static site builds. </summary>
    internal partial class StaticSiteBuildCollection
    {
        /// <summary> Initializes a new instance of StaticSiteBuildCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal StaticSiteBuildCollection(IEnumerable<StaticSiteBuildData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of StaticSiteBuildCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal StaticSiteBuildCollection(IReadOnlyList<StaticSiteBuildData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<StaticSiteBuildData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
