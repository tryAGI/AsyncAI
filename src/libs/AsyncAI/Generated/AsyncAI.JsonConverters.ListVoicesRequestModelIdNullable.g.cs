#nullable enable

namespace AsyncAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListVoicesRequestModelIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AsyncAI.ListVoicesRequestModelId?>
    {
        /// <inheritdoc />
        public override global::AsyncAI.ListVoicesRequestModelId? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::AsyncAI.ListVoicesRequestModelIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AsyncAI.ListVoicesRequestModelId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AsyncAI.ListVoicesRequestModelId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AsyncAI.ListVoicesRequestModelId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AsyncAI.ListVoicesRequestModelIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
