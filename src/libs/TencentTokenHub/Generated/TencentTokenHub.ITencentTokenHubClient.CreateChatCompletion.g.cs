#nullable enable

namespace TencentTokenHub
{
    public partial interface ITencentTokenHubClient
    {
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TencentTokenHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TencentTokenHub.ChatCompletionResponse> CreateChatCompletionAsync(

            global::TencentTokenHub.ChatCompletionRequest request,
            global::TencentTokenHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="stream"></param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TencentTokenHub.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::TencentTokenHub.Message> messages,
            bool? stream = default,
            int? maxTokens = default,
            float? temperature = default,
            float? topP = default,
            global::System.Collections.Generic.IList<global::TencentTokenHub.Tool>? tools = default,
            string? toolChoice = default,
            global::TencentTokenHub.ResponseFormat? responseFormat = default,
            global::TencentTokenHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}