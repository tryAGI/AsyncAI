#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class VoiceManagementCloneVoiceCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"API version header.",
    };

    private static Option<byte[]> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Audio clip file. Supported formats include wav, mp3, flac, and aiff.",
        Required = true,
    };

    private static Option<string> Audioname { get; } = new(
        name: @"--audioname")
    {
        Description = @"Audio clip file. Supported formats include wav, mp3, flac, and aiff.",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<string?> Accent { get; } = new(
        name: @"--accent")
    {
        Description = @"",
    };

    private static Option<global::AsyncAI.Gender?> Gender { get; } = new(
        name: @"--gender")
    {
        Description = @"",
    };

    private static Option<string?> Style { get; } = new(
        name: @"--style")
    {
        Description = @"",
    };

    private static Option<bool?> Enhance { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance",
        description: @"");

    private static Option<string?> Transcript { get; } = new(
        name: @"--transcript")
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

                    private static string FormatResponse(ParseResult parseResult, global::AsyncAI.CloneVoiceResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AsyncAI.CloneVoiceResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"clone-voice", @"Clone voice
Clones a voice from a short audio clip.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(Version);
                        command.Options.Add(Audio);
                        command.Options.Add(Audioname);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Accent);
                        command.Options.Add(Gender);
                        command.Options.Add(Style);
                        command.Options.Add(Enhance);
                        command.Options.Add(Transcript);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AsyncAI.CloneVoiceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AsyncAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var version = parseResult.GetValue(Version);
                        var audio = parseResult.GetRequiredValue(Audio);
                        var audioname = parseResult.GetRequiredValue(Audioname);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : __requestBase is not null ? __requestBase.Description : default;
                        var accent = CliRuntime.WasSpecified(parseResult, Accent) ? parseResult.GetValue(Accent) : __requestBase is not null ? __requestBase.Accent : default;
                        var gender = CliRuntime.WasSpecified(parseResult, Gender) ? parseResult.GetValue(Gender) : __requestBase is not null ? __requestBase.Gender : default;
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : __requestBase is not null ? __requestBase.Style : default;
                        var enhance = CliRuntime.WasSpecified(parseResult, Enhance) ? parseResult.GetValue(Enhance) : __requestBase is not null ? __requestBase.Enhance : default;
                        var transcript = CliRuntime.WasSpecified(parseResult, Transcript) ? parseResult.GetValue(Transcript) : __requestBase is not null ? __requestBase.Transcript : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.VoiceManagement.CloneVoiceAsync(
                                    name: name,
                                    version: version,
                                    audio: audio,
                                    audioname: audioname,
                                    description: description,
                                    accent: accent,
                                    gender: gender,
                                    style: style,
                                    enhance: enhance,
                                    transcript: transcript,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::AsyncAI.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}