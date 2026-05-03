
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechWithTimestampsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AsyncAI.Alignment Alignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsResponse" /> class.
        /// </summary>
        /// <param name="audioBase64"></param>
        /// <param name="alignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechWithTimestampsResponse(
            string audioBase64,
            global::AsyncAI.Alignment alignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Alignment = alignment ?? throw new global::System.ArgumentNullException(nameof(alignment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsResponse" /> class.
        /// </summary>
        public TextToSpeechWithTimestampsResponse()
        {
        }
    }
}