
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechRequest
    {
        /// <summary>
        /// Default Value: async_flash_v1.0
        /// </summary>
        /// <default>global::AsyncAI.TextToSpeechRequestModelId.AsyncFlashV10</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.TextToSpeechRequestModelIdJsonConverter))]
        public global::AsyncAI.TextToSpeechRequestModelId ModelId { get; set; } = global::AsyncAI.TextToSpeechRequestModelId.AsyncFlashV10;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AsyncAI.VoiceSelector Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AsyncAI.OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.LanguageCodeJsonConverter))]
        public global::AsyncAI.LanguageCode? Language { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_control")]
        public double? SpeedControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public int? Stability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="language"></param>
        /// <param name="normalize">
        /// Default Value: false
        /// </param>
        /// <param name="speedControl"></param>
        /// <param name="stability"></param>
        /// <param name="modelId">
        /// Default Value: async_flash_v1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechRequest(
            string transcript,
            global::AsyncAI.VoiceSelector voice,
            global::AsyncAI.OutputFormat outputFormat,
            global::AsyncAI.LanguageCode? language,
            bool? normalize,
            double? speedControl,
            int? stability,
            global::AsyncAI.TextToSpeechRequestModelId modelId = global::AsyncAI.TextToSpeechRequestModelId.AsyncFlashV10)
        {
            this.ModelId = modelId;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.OutputFormat = outputFormat ?? throw new global::System.ArgumentNullException(nameof(outputFormat));
            this.Language = language;
            this.Normalize = normalize;
            this.SpeedControl = speedControl;
            this.Stability = stability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        public TextToSpeechRequest()
        {
        }

    }
}