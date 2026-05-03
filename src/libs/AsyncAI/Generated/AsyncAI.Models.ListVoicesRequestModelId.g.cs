
#nullable enable

namespace AsyncAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListVoicesRequestModelId
    {
        /// <summary>
        /// 
        /// </summary>
        AsyncFlashV10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListVoicesRequestModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListVoicesRequestModelId value)
        {
            return value switch
            {
                ListVoicesRequestModelId.AsyncFlashV10 => "async_flash_v1.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListVoicesRequestModelId? ToEnum(string value)
        {
            return value switch
            {
                "async_flash_v1.0" => ListVoicesRequestModelId.AsyncFlashV10,
                _ => null,
            };
        }
    }
}