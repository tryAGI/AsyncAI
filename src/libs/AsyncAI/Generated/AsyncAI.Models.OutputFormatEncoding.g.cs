
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// Default Value: pcm_s16le
    /// </summary>
    public enum OutputFormatEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormatEncoding value)
        {
            return value switch
            {
                OutputFormatEncoding.PcmF32le => "pcm_f32le",
                OutputFormatEncoding.PcmMulaw => "pcm_mulaw",
                OutputFormatEncoding.PcmS16le => "pcm_s16le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormatEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_f32le" => OutputFormatEncoding.PcmF32le,
                "pcm_mulaw" => OutputFormatEncoding.PcmMulaw,
                "pcm_s16le" => OutputFormatEncoding.PcmS16le,
                _ => null,
            };
        }
    }
}