#nullable enable

namespace AsyncAI
{
    public partial interface IVoiceManagementClient
    {
        /// <summary>
        /// List voices<br/>
        /// Lists available voices from the voice library.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.ListVoicesResponse> ListVoicesAsync(

            global::AsyncAI.ListVoicesRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// Lists available voices from the voice library.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.AutoSDKHttpResponse<global::AsyncAI.ListVoicesResponse>> ListVoicesAsResponseAsync(

            global::AsyncAI.ListVoicesRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// Lists available voices from the voice library.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="gender"></param>
        /// <param name="after"></param>
        /// <param name="myVoice"></param>
        /// <param name="accent"></param>
        /// <param name="style"></param>
        /// <param name="modelId"></param>
        /// <param name="language"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.ListVoicesResponse> ListVoicesAsync(
            string? version = default,
            int? limit = default,
            global::AsyncAI.Gender? gender = default,
            string? after = default,
            bool? myVoice = default,
            string? accent = default,
            string? style = default,
            global::AsyncAI.ListVoicesRequestModelId? modelId = default,
            global::AsyncAI.LanguageCode? language = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}