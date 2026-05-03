
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceRequest
    {
        /// <summary>
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.GenderJsonConverter))]
        public global::AsyncAI.Gender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance")]
        public bool? Enhance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </param>
        /// <param name="audioname">
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="accent"></param>
        /// <param name="gender"></param>
        /// <param name="style"></param>
        /// <param name="enhance">
        /// Default Value: false
        /// </param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneVoiceRequest(
            byte[] audio,
            string audioname,
            string name,
            string? description,
            string? accent,
            global::AsyncAI.Gender? gender,
            string? style,
            bool? enhance,
            string? transcript)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Accent = accent;
            this.Gender = gender;
            this.Style = style;
            this.Enhance = enhance;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        public CloneVoiceRequest()
        {
        }
    }
}