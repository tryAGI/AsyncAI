#nullable enable

namespace AsyncAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceSelectorModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AsyncAI.VoiceSelectorMode>
    {
        /// <inheritdoc />
        public override global::AsyncAI.VoiceSelectorMode Read(
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
                        return global::AsyncAI.VoiceSelectorModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AsyncAI.VoiceSelectorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AsyncAI.VoiceSelectorMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AsyncAI.VoiceSelectorMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AsyncAI.VoiceSelectorModeExtensions.ToValueString(value));
        }
    }
}
