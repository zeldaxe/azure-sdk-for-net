// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    internal partial class MetricNamespaceName
    {
        internal static MetricNamespaceName DeserializeMetricNamespaceName(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricNamespaceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricNamespaceName"u8))
                {
                    metricNamespaceName = property.Value.GetString();
                    continue;
                }
            }
            return new MetricNamespaceName(metricNamespaceName);
        }
    }
}
