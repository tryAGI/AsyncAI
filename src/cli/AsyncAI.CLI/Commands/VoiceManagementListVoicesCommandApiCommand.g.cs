#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class VoiceManagementListVoicesCommandApiCommand
{
    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"API version header.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

    private static Option<global::AsyncAI.Gender?> Gender { get; } = new(
        name: @"--gender")
    {
        Description = @"",
    };

    private static Option<string?> After { get; } = new(
        name: @"--after")
    {
        Description = @"",
    };

    private static Option<bool?> MyVoice { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--my-voice",
        description: @"");

    private static Option<string?> Accent { get; } = new(
        name: @"--accent")
    {
        Description = @"",
    };

    private static Option<string?> Style { get; } = new(
        name: @"--style")
    {
        Description = @"",
    };

    private static Option<global::AsyncAI.ListVoicesRequestModelId?> ModelId { get; } = new(
        name: @"--model-id")
    {
        Description = @"",
    };

    private static Option<global::AsyncAI.LanguageCode?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::AsyncAI.ListVoicesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AsyncAI.ListVoicesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-voices", @"List voices
Lists available voices from the voice library.");
                        command.Options.Add(Version);
                        command.Options.Add(Limit);
                        command.Options.Add(Gender);
                        command.Options.Add(After);
                        command.Options.Add(MyVoice);
                        command.Options.Add(Accent);
                        command.Options.Add(Style);
                        command.Options.Add(ModelId);
                        command.Options.Add(Language);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AsyncAI.ListVoicesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AsyncAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var version = parseResult.GetValue(Version);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : __requestBase is not null ? __requestBase.Limit : default;
                        var gender = CliRuntime.WasSpecified(parseResult, Gender) ? parseResult.GetValue(Gender) : __requestBase is not null ? __requestBase.Gender : default;
                        var after = CliRuntime.WasSpecified(parseResult, After) ? parseResult.GetValue(After) : __requestBase is not null ? __requestBase.After : default;
                        var myVoice = CliRuntime.WasSpecified(parseResult, MyVoice) ? parseResult.GetValue(MyVoice) : __requestBase is not null ? __requestBase.MyVoice : default;
                        var accent = CliRuntime.WasSpecified(parseResult, Accent) ? parseResult.GetValue(Accent) : __requestBase is not null ? __requestBase.Accent : default;
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : __requestBase is not null ? __requestBase.Style : default;
                        var modelId = CliRuntime.WasSpecified(parseResult, ModelId) ? parseResult.GetValue(ModelId) : __requestBase is not null ? __requestBase.ModelId : default;
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : __requestBase is not null ? __requestBase.Language : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VoiceManagement.ListVoicesAsync(
                                    version: version,
                                    limit: limit,
                                    gender: gender,
                                    after: after,
                                    myVoice: myVoice,
                                    accent: accent,
                                    style: style,
                                    modelId: modelId,
                                    language: language,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::AsyncAI.SourceGenerationContext.Default,
                                        @"Voices",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AsyncAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}