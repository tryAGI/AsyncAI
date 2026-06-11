#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class TextToSpeechSynthesizeSpeechWithTimestampsCommandApiCommand
{
    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"API version header.",
    };
    private static readonly TextToSpeechRequestOptionSet TextToSpeechRequestOptionSetOptions = TextToSpeechRequestOptionSet.Create();

    private static readonly VoiceSelectorOptionSet VoiceOptions = VoiceSelectorOptionSet.Create(@"voice");

    private static readonly OutputFormatOptionSet OutputFormatOptions = OutputFormatOptionSet.Create(@"output-format");
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

                    private static string FormatResponse(ParseResult parseResult, global::AsyncAI.TextToSpeechWithTimestampsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::AsyncAI.TextToSpeechWithTimestampsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"synthesize-speech-with-timestamps", @"Text to speech with word timestamps
Generates speech and returns base64 audio with word-level timestamps.");
                        command.Options.Add(Version);                        command.Options.Add(TextToSpeechRequestOptionSetOptions.ModelId);
                        command.Options.Add(TextToSpeechRequestOptionSetOptions.Transcript);
                        command.Options.Add(TextToSpeechRequestOptionSetOptions.Language);
                        command.Options.Add(TextToSpeechRequestOptionSetOptions.Normalize);
                        command.Options.Add(TextToSpeechRequestOptionSetOptions.SpeedControl);
                        command.Options.Add(TextToSpeechRequestOptionSetOptions.Stability);                        command.Options.Add(VoiceOptions.Mode);
                        command.Options.Add(VoiceOptions.Id);                        command.Options.Add(OutputFormatOptions.Container);
                        command.Options.Add(OutputFormatOptions.Encoding);
                        command.Options.Add(OutputFormatOptions.SampleRate);
                        command.Options.Add(OutputFormatOptions.BitRate);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AsyncAI.TextToSpeechRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AsyncAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var version = parseResult.GetValue(Version);                        var modelId = parseResult.GetRequiredValue(TextToSpeechRequestOptionSetOptions.ModelId);
                        var transcript = parseResult.GetRequiredValue(TextToSpeechRequestOptionSetOptions.Transcript);
                        var language = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Language) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Language) : __requestBase is not null ? __requestBase.Language : default;
                        var normalize = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Normalize) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Normalize) : __requestBase is not null ? __requestBase.Normalize : default;
                        var speedControl = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.SpeedControl) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.SpeedControl) : __requestBase is not null ? __requestBase.SpeedControl : default;
                        var stability = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Stability) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Stability) : __requestBase is not null ? __requestBase.Stability : default;

                        var __voiceBase = __requestBase?.Voice;                        var voiceMode = CliRuntime.WasSpecified(parseResult, VoiceOptions.Mode) ? parseResult.GetValue(VoiceOptions.Mode) : __voiceBase is not null ? __voiceBase.Mode : default;
                        var voiceId = parseResult.GetValue(VoiceOptions.Id);
                        var __voiceSpecified = CliRuntime.WasSpecified(parseResult, VoiceOptions.Mode) || CliRuntime.WasSpecified(parseResult, VoiceOptions.Id);
                        var voice =
                            __voiceSpecified || __voiceBase is not null
                                ? new global::AsyncAI.VoiceSelector
                                {
	                                Mode = voiceMode,
                                Id = voiceId!,

                                }
                                : __voiceBase;

                        var __outputFormatBase = __requestBase?.OutputFormat;                        var outputFormatContainer = parseResult.GetValue(OutputFormatOptions.Container);
                        var outputFormatEncoding = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Encoding) ? parseResult.GetValue(OutputFormatOptions.Encoding) : __outputFormatBase is not null ? __outputFormatBase.Encoding : default;
                        var outputFormatSampleRate = parseResult.GetValue(OutputFormatOptions.SampleRate);
                        var outputFormatBitRate = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.BitRate) ? parseResult.GetValue(OutputFormatOptions.BitRate) : __outputFormatBase is not null ? __outputFormatBase.BitRate : default;
                        var __outputFormatSpecified = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Container) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Encoding) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.SampleRate) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.BitRate);
                        var outputFormat =
                            __outputFormatSpecified || __outputFormatBase is not null
                                ? new global::AsyncAI.OutputFormat
                                {
	                                Container = outputFormatContainer!,
                                Encoding = outputFormatEncoding,
                                SampleRate = outputFormatSampleRate!,
                                BitRate = outputFormatBitRate,

                                }
                                : __outputFormatBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TextToSpeech.SynthesizeSpeechWithTimestampsAsync(
                                    version: version,
                                    modelId: modelId,
                                    transcript: transcript,
                                    language: language,
                                    normalize: normalize,
                                    speedControl: speedControl,
                                    stability: stability,
                                    voice: voice!,
                                    outputFormat: outputFormat!,
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