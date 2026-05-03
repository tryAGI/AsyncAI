#nullable enable

namespace AsyncAI
{
    public partial interface IVoiceManagementClient
    {
        /// <summary>
        /// Delete voice<br/>
        /// Deletes a cloned voice by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVoiceAsync(
            string id,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}