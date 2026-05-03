
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// Default Value: async_flash_v1.0
    /// </summary>
    public enum TextToSpeechRequestModelId
    {
        /// <summary>
        /// 
        /// </summary>
        AsyncFlashV10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestModelId value)
        {
            return value switch
            {
                TextToSpeechRequestModelId.AsyncFlashV10 => "async_flash_v1.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestModelId? ToEnum(string value)
        {
            return value switch
            {
                "async_flash_v1.0" => TextToSpeechRequestModelId.AsyncFlashV10,
                _ => null,
            };
        }
    }
}