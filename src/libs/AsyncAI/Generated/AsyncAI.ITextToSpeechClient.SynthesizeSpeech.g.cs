#nullable enable

namespace AsyncAI
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Text to speech<br/>
        /// Generates speech from text and returns complete audio.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(

            global::AsyncAI.TextToSpeechRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to speech<br/>
        /// Generates speech from text and returns complete audio.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="modelId">
        /// Default Value: async_flash_v1.0
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="language"></param>
        /// <param name="normalize">
        /// Default Value: false
        /// </param>
        /// <param name="speedControl"></param>
        /// <param name="stability"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SynthesizeSpeechAsync(
            string transcript,
            global::AsyncAI.VoiceSelector voice,
            global::AsyncAI.OutputFormat outputFormat,
            string? version = default,
            global::AsyncAI.TextToSpeechRequestModelId modelId = global::AsyncAI.TextToSpeechRequestModelId.AsyncFlashV10,
            global::AsyncAI.LanguageCode? language = default,
            bool? normalize = default,
            double? speedControl = default,
            int? stability = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}