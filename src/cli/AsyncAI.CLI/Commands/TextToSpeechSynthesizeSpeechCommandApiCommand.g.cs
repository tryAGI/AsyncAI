#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class TextToSpeechSynthesizeSpeechCommandApiCommand
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

    public static Command Create()
    {
        var command = new Command(@"synthesize-speech", @"Text to speech
Generates speech from text and returns complete audio.");
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
                        var language = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Language) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var normalize = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Normalize) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Normalize) : (__requestBase is { } __NormalizeBaseValue ? __NormalizeBaseValue.Normalize : default);
                        var speedControl = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.SpeedControl) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.SpeedControl) : (__requestBase is { } __SpeedControlBaseValue ? __SpeedControlBaseValue.SpeedControl : default);
                        var stability = CliRuntime.WasSpecified(parseResult, TextToSpeechRequestOptionSetOptions.Stability) ? parseResult.GetValue(TextToSpeechRequestOptionSetOptions.Stability) : (__requestBase is { } __StabilityBaseValue ? __StabilityBaseValue.Stability : default);

                        var __VoiceBase = __requestBase is { } __VoiceBaseValue ? __VoiceBaseValue.Voice : default;                        var voiceMode = CliRuntime.WasSpecified(parseResult, VoiceOptions.Mode) ? parseResult.GetValue(VoiceOptions.Mode) : (__VoiceBase is { } __VoicemodeBaseValue ? __VoicemodeBaseValue.Mode : default);
                        var voiceId = parseResult.GetValue(VoiceOptions.Id);
                        var __VoiceSpecified = CliRuntime.WasSpecified(parseResult, VoiceOptions.Mode) || CliRuntime.WasSpecified(parseResult, VoiceOptions.Id);
                        var voice =
                            __VoiceSpecified || __VoiceBase is not null
                                ? new global::AsyncAI.VoiceSelector
                                {
	                                Mode = voiceMode,
                                Id = voiceId!,

                                }
                                : __VoiceBase;

                        var __OutputFormatBase = __requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default;                        var outputFormatContainer = parseResult.GetValue(OutputFormatOptions.Container);
                        var outputFormatEncoding = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Encoding) ? parseResult.GetValue(OutputFormatOptions.Encoding) : (__OutputFormatBase is { } __OutputFormatencodingBaseValue ? __OutputFormatencodingBaseValue.Encoding : default);
                        var outputFormatSampleRate = parseResult.GetValue(OutputFormatOptions.SampleRate);
                        var outputFormatBitRate = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.BitRate) ? parseResult.GetValue(OutputFormatOptions.BitRate) : (__OutputFormatBase is { } __OutputFormatbitRateBaseValue ? __OutputFormatbitRateBaseValue.BitRate : default);
                        var __OutputFormatSpecified = CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Container) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.Encoding) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.SampleRate) || CliRuntime.WasSpecified(parseResult, OutputFormatOptions.BitRate);
                        var outputFormat =
                            __OutputFormatSpecified || __OutputFormatBase is not null
                                ? new global::AsyncAI.OutputFormat
                                {
	                                Container = outputFormatContainer!,
                                Encoding = outputFormatEncoding,
                                SampleRate = outputFormatSampleRate!,
                                BitRate = outputFormatBitRate,

                                }
                                : __OutputFormatBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TextToSpeech.SynthesizeSpeechAsync(
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

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}