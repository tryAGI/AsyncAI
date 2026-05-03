#nullable enable

namespace AsyncAI
{
    public partial interface IVoiceManagementClient
    {
        /// <summary>
        /// Update voice<br/>
        /// Updates metadata for a cloned voice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateVoiceAsync(
            string id,

            global::AsyncAI.UpdateVoiceRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Updates metadata for a cloned voice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="gender"></param>
        /// <param name="style"></param>
        /// <param name="accent"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateVoiceAsync(
            string id,
            string? version = default,
            string? name = default,
            string? description = default,
            global::AsyncAI.Gender? gender = default,
            string? style = default,
            string? accent = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}