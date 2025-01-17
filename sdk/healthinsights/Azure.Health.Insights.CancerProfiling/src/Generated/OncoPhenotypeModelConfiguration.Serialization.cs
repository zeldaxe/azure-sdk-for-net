// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.CancerProfiling
{
    public partial class OncoPhenotypeModelConfiguration : IUtf8JsonSerializable, IJsonModel<OncoPhenotypeModelConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OncoPhenotypeModelConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OncoPhenotypeModelConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeModelConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Verbose))
            {
                writer.WritePropertyName("verbose"u8);
                writer.WriteBooleanValue(Verbose.Value);
            }
            if (Optional.IsDefined(IncludeEvidence))
            {
                writer.WritePropertyName("includeEvidence"u8);
                writer.WriteBooleanValue(IncludeEvidence.Value);
            }
            if (Optional.IsCollectionDefined(InferenceTypes))
            {
                writer.WritePropertyName("inferenceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in InferenceTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CheckForCancerCase))
            {
                writer.WritePropertyName("checkForCancerCase"u8);
                writer.WriteBooleanValue(CheckForCancerCase.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        OncoPhenotypeModelConfiguration IJsonModel<OncoPhenotypeModelConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OncoPhenotypeModelConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOncoPhenotypeModelConfiguration(document.RootElement, options);
        }

        internal static OncoPhenotypeModelConfiguration DeserializeOncoPhenotypeModelConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? verbose = default;
            bool? includeEvidence = default;
            IList<OncoPhenotypeInferenceType> inferenceTypes = default;
            bool? checkForCancerCase = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verbose"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verbose = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeEvidence = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("inferenceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OncoPhenotypeInferenceType> array = new List<OncoPhenotypeInferenceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new OncoPhenotypeInferenceType(item.GetString()));
                    }
                    inferenceTypes = array;
                    continue;
                }
                if (property.NameEquals("checkForCancerCase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkForCancerCase = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OncoPhenotypeModelConfiguration(verbose, includeEvidence, inferenceTypes ?? new ChangeTrackingList<OncoPhenotypeInferenceType>(), checkForCancerCase, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OncoPhenotypeModelConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OncoPhenotypeModelConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        OncoPhenotypeModelConfiguration IPersistableModel<OncoPhenotypeModelConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OncoPhenotypeModelConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOncoPhenotypeModelConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OncoPhenotypeModelConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OncoPhenotypeModelConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OncoPhenotypeModelConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOncoPhenotypeModelConfiguration(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<OncoPhenotypeModelConfiguration>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
