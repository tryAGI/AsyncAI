
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VoiceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesBatchRequest" /> class.
        /// </summary>
        /// <param name="voiceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesBatchRequest(
            global::System.Collections.Generic.IList<string> voiceIds)
        {
            this.VoiceIds = voiceIds ?? throw new global::System.ArgumentNullException(nameof(voiceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesBatchRequest" /> class.
        /// </summary>
        public GetVoicesBatchRequest()
        {
        }

    }
}