// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The QuotaOperationDisplay. </summary>
    public partial class QuotaOperationDisplay
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaOperationDisplay"/>. </summary>
        internal QuotaOperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaOperationDisplay"/>. </summary>
        /// <param name="provider"> Provider name. </param>
        /// <param name="resource"> Resource name. </param>
        /// <param name="operation"> Operation name. </param>
        /// <param name="description"> Operation description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaOperationDisplay(string provider, string resource, string operation, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provider name. </summary>
        public string Provider { get; }
        /// <summary> Resource name. </summary>
        public string Resource { get; }
        /// <summary> Operation name. </summary>
        public string Operation { get; }
        /// <summary> Operation description. </summary>
        public string Description { get; }
    }
}
