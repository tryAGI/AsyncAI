
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceSelectorMode
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSelectorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSelectorMode value)
        {
            return value switch
            {
                VoiceSelectorMode.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSelectorMode? ToEnum(string value)
        {
            return value switch
            {
                "id" => VoiceSelectorMode.Id,
                _ => null,
            };
        }
    }
}