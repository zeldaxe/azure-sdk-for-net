// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class WebClientCertificateAuthentication : IUtf8JsonSerializable, IJsonModel<WebClientCertificateAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebClientCertificateAuthentication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebClientCertificateAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebClientCertificateAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebClientCertificateAuthentication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("pfx"u8);
            JsonSerializer.Serialize(writer, Pfx);
            writer.WritePropertyName("password"u8);
            JsonSerializer.Serialize(writer, Password);
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        WebClientCertificateAuthentication IJsonModel<WebClientCertificateAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebClientCertificateAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebClientCertificateAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebClientCertificateAuthentication(document.RootElement, options);
        }

        internal static WebClientCertificateAuthentication DeserializeWebClientCertificateAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactorySecret pfx = default;
            DataFactorySecret password = default;
            DataFactoryElement<string> url = default;
            WebAuthenticationType authenticationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pfx"u8))
                {
                    pfx = JsonSerializer.Deserialize<DataFactorySecret>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = JsonSerializer.Deserialize<DataFactorySecret>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebClientCertificateAuthentication(url, authenticationType, serializedAdditionalRawData, pfx, password);
        }

        BinaryData IPersistableModel<WebClientCertificateAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebClientCertificateAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebClientCertificateAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        WebClientCertificateAuthentication IPersistableModel<WebClientCertificateAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebClientCertificateAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebClientCertificateAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebClientCertificateAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebClientCertificateAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
