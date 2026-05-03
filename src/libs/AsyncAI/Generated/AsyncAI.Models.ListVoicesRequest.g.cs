
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoicesRequest
    {
        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.GenderJsonConverter))]
        public global::AsyncAI.Gender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after")]
        public string? After { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("my_voice")]
        public bool? MyVoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.ListVoicesRequestModelIdJsonConverter))]
        public global::AsyncAI.ListVoicesRequestModelId? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.LanguageCodeJsonConverter))]
        public global::AsyncAI.LanguageCode? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="gender"></param>
        /// <param name="after"></param>
        /// <param name="myVoice"></param>
        /// <param name="accent"></param>
        /// <param name="style"></param>
        /// <param name="modelId"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesRequest(
            int? limit,
            global::AsyncAI.Gender? gender,
            string? after,
            bool? myVoice,
            string? accent,
            string? style,
            global::AsyncAI.ListVoicesRequestModelId? modelId,
            global::AsyncAI.LanguageCode? language)
        {
            this.Limit = limit;
            this.Gender = gender;
            this.After = after;
            this.MyVoice = myVoice;
            this.Accent = accent;
            this.Style = style;
            this.ModelId = modelId;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesRequest" /> class.
        /// </summary>
        public ListVoicesRequest()
        {
        }
    }
}