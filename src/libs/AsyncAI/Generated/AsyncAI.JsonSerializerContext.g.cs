
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AsyncAI.JsonConverters.TextToSpeechRequestModelIdJsonConverter),

            typeof(global::AsyncAI.JsonConverters.TextToSpeechRequestModelIdNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.VoiceSelectorModeJsonConverter),

            typeof(global::AsyncAI.JsonConverters.VoiceSelectorModeNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.OutputFormatContainerJsonConverter),

            typeof(global::AsyncAI.JsonConverters.OutputFormatContainerNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.OutputFormatEncodingJsonConverter),

            typeof(global::AsyncAI.JsonConverters.OutputFormatEncodingNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.LanguageCodeJsonConverter),

            typeof(global::AsyncAI.JsonConverters.LanguageCodeNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.ListVoicesRequestModelIdJsonConverter),

            typeof(global::AsyncAI.JsonConverters.ListVoicesRequestModelIdNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.VoiceVoiceTypeJsonConverter),

            typeof(global::AsyncAI.JsonConverters.VoiceVoiceTypeNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.GenderJsonConverter),

            typeof(global::AsyncAI.JsonConverters.GenderNullableJsonConverter),

            typeof(global::AsyncAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.StatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.TextToSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.TextToSpeechRequestModelId), TypeInfoPropertyName = "TextToSpeechRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.VoiceSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.OutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.LanguageCode), TypeInfoPropertyName = "LanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.VoiceSelectorMode), TypeInfoPropertyName = "VoiceSelectorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.OutputFormatContainer), TypeInfoPropertyName = "OutputFormatContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.OutputFormatEncoding), TypeInfoPropertyName = "OutputFormatEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.TextToSpeechWithTimestampsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.Alignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.ListVoicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.Gender), TypeInfoPropertyName = "Gender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.ListVoicesRequestModelId), TypeInfoPropertyName = "ListVoicesRequestModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AsyncAI.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.GetVoicesBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.CloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.CloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.VoicePreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.VoiceVoiceType), TypeInfoPropertyName = "VoiceVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AsyncAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AsyncAI.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}