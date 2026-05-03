
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hy,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageCode value)
        {
            return value switch
            {
                LanguageCode.Ar => "ar",
                LanguageCode.De => "de",
                LanguageCode.En => "en",
                LanguageCode.Es => "es",
                LanguageCode.Fr => "fr",
                LanguageCode.He => "he",
                LanguageCode.Hi => "hi",
                LanguageCode.Hy => "hy",
                LanguageCode.It => "it",
                LanguageCode.Ja => "ja",
                LanguageCode.Nl => "nl",
                LanguageCode.Pt => "pt",
                LanguageCode.Ro => "ro",
                LanguageCode.Ru => "ru",
                LanguageCode.Tr => "tr",
                LanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => LanguageCode.Ar,
                "de" => LanguageCode.De,
                "en" => LanguageCode.En,
                "es" => LanguageCode.Es,
                "fr" => LanguageCode.Fr,
                "he" => LanguageCode.He,
                "hi" => LanguageCode.Hi,
                "hy" => LanguageCode.Hy,
                "it" => LanguageCode.It,
                "ja" => LanguageCode.Ja,
                "nl" => LanguageCode.Nl,
                "pt" => LanguageCode.Pt,
                "ro" => LanguageCode.Ro,
                "ru" => LanguageCode.Ru,
                "tr" => LanguageCode.Tr,
                "zh" => LanguageCode.Zh,
                _ => null,
            };
        }
    }
}