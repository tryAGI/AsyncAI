#nullable enable

namespace AsyncAI
{
    public partial interface IVoiceManagementClient
    {
        /// <summary>
        /// Clone voice<br/>
        /// Clones a voice from a short audio clip.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AsyncAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.CloneVoiceResponse> CloneVoiceAsync(

            global::AsyncAI.CloneVoiceRequest request,
            string? version = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone voice<br/>
        /// Clones a voice from a short audio clip.
        /// </summary>
        /// <param name="version">
        /// Default Value: v1
        /// </param>
        /// <param name="audio">
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </param>
        /// <param name="audioname">
        /// Audio clip file. Supported formats include wav, mp3, flac, and aiff.
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="accent"></param>
        /// <param name="gender"></param>
        /// <param name="style"></param>
        /// <param name="enhance">
        /// Default Value: false
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AsyncAI.CloneVoiceResponse> CloneVoiceAsync(
            byte[] audio,
            string audioname,
            string name,
            string? version = default,
            string? description = default,
            string? accent = default,
            global::AsyncAI.Gender? gender = default,
            string? style = default,
            bool? enhance = default,
            string? transcript = default,
            global::AsyncAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}