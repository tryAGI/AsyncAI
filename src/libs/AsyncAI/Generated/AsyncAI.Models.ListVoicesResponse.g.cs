
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoicesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AsyncAI.Voice> Voices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesResponse(
            global::System.Collections.Generic.IList<global::AsyncAI.Voice> voices,
            string nextCursor)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.NextCursor = nextCursor ?? throw new global::System.ArgumentNullException(nameof(nextCursor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        public ListVoicesResponse()
        {
        }
    }
}