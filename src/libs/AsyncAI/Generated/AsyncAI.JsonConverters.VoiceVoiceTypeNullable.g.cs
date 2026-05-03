#nullable enable

namespace AsyncAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceVoiceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AsyncAI.VoiceVoiceType?>
    {
        /// <inheritdoc />
        public override global::AsyncAI.VoiceVoiceType? Read(
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
                        return global::AsyncAI.VoiceVoiceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AsyncAI.VoiceVoiceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AsyncAI.VoiceVoiceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AsyncAI.VoiceVoiceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AsyncAI.VoiceVoiceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
