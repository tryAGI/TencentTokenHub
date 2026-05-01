
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace TencentTokenHub
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::TencentTokenHub.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::TencentTokenHub.ContentPart>>),

            typeof(global::TencentTokenHub.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TencentTokenHub.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TencentTokenHub.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.OneOf<string, global::System.Collections.Generic.IList<global::TencentTokenHub.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TencentTokenHub.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TencentTokenHub.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::TencentTokenHub.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TencentTokenHub.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TencentTokenHub.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::TencentTokenHub.OneOf<string, global::System.Collections.Generic.List<global::TencentTokenHub.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TencentTokenHub.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TencentTokenHub.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::TencentTokenHub.Choice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}