#nullable enable

namespace AsyncAI
{
    public partial interface IApiStatusClient
    {
        /// <summary>
        /// API status check
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.StatusResponse> GetStatusAsync(
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// API status check
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.AutoSDKHttpResponse<global::AsyncAI.StatusResponse>> GetStatusAsResponseAsync(
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}