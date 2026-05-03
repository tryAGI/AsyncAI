
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceVoiceType value)
        {
            return value switch
            {
                VoiceVoiceType.Custom => "CUSTOM",
                VoiceVoiceType.Predefined => "PREDEFINED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => VoiceVoiceType.Custom,
                "PREDEFINED" => VoiceVoiceType.Predefined,
                _ => null,
            };
        }
    }
}