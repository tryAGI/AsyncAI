
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="gender"></param>
        /// <param name="style"></param>
        /// <param name="accent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceRequest(
            string? name,
            string? description,
            global::AsyncAI.Gender? gender,
            string? style,
            string? accent)
        {
            this.Name = name;
            this.Description = description;
            this.Gender = gender;
            this.Style = style;
            this.Accent = accent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        public UpdateVoiceRequest()
        {
        }

    }
}