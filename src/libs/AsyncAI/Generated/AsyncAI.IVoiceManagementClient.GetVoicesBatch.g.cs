#nullable enable

namespace AsyncAI
{
    public partial interface IVoiceManagementClient
    {
        /// <summary>
        /// Get voices by id<br/>
        /// Gets multiple voices by voice id.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AsyncAI.Voice>> GetVoicesBatchAsync(

            global::AsyncAI.GetVoicesBatchRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get voices by id<br/>
        /// Gets multiple voices by voice id.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="voiceIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AsyncAI.Voice>> GetVoicesBatchAsync(
            global::System.Collections.Generic.IList<string> voiceIds,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}