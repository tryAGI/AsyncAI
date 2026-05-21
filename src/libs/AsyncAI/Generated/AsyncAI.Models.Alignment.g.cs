
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Alignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_start_times_milliseconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> WordStartTimesMilliseconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_end_times_milliseconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> WordEndTimesMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Alignment" /> class.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="wordStartTimesMilliseconds"></param>
        /// <param name="wordEndTimesMilliseconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Alignment(
            global::System.Collections.Generic.IList<string> words,
            global::System.Collections.Generic.IList<double> wordStartTimesMilliseconds,
            global::System.Collections.Generic.IList<double> wordEndTimesMilliseconds)
        {
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.WordStartTimesMilliseconds = wordStartTimesMilliseconds ?? throw new global::System.ArgumentNullException(nameof(wordStartTimesMilliseconds));
            this.WordEndTimesMilliseconds = wordEndTimesMilliseconds ?? throw new global::System.ArgumentNullException(nameof(wordEndTimesMilliseconds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alignment" /> class.
        /// </summary>
        public Alignment()
        {
        }

    }
}