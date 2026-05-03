
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.OutputFormatContainerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AsyncAI.OutputFormatContainer Container { get; set; }

        /// <summary>
        /// Default Value: pcm_s16le
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AsyncAI.JsonConverters.OutputFormatEncodingJsonConverter))]
        public global::AsyncAI.OutputFormatEncoding? Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Default Value: 192000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat" /> class.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="sampleRate"></param>
        /// <param name="encoding">
        /// Default Value: pcm_s16le
        /// </param>
        /// <param name="bitRate">
        /// Default Value: 192000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputFormat(
            global::AsyncAI.OutputFormatContainer container,
            int sampleRate,
            global::AsyncAI.OutputFormatEncoding? encoding,
            int? bitRate)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
            this.BitRate = bitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormat" /> class.
        /// </summary>
        public OutputFormat()
        {
        }
    }
}