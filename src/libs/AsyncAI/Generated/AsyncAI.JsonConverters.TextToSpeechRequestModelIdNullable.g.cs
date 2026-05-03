#nullable enable

namespace AsyncAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToSpeechRequestModelIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AsyncAI.TextToSpeechRequestModelId?>
    {
        /// <inheritdoc />
        public override global::AsyncAI.TextToSpeechRequestModelId? Read(
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
                        return global::AsyncAI.TextToSpeechRequestModelIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AsyncAI.TextToSpeechRequestModelId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AsyncAI.TextToSpeechRequestModelId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AsyncAI.TextToSpeechRequestModelId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AsyncAI.TextToSpeechRequestModelIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
