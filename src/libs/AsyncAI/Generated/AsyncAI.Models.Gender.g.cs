
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Gender value)
        {
            return value switch
            {
                Gender.Female => "Female",
                Gender.Male => "Male",
                Gender.Neutral => "Neutral",
                Gender.Unspecified => "Unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Gender? ToEnum(string value)
        {
            return value switch
            {
                "Female" => Gender.Female,
                "Male" => Gender.Male,
                "Neutral" => Gender.Neutral,
                "Unspecified" => Gender.Unspecified,
                _ => null,
            };
        }
    }
}