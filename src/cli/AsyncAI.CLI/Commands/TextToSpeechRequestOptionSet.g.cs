#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal sealed record TextToSpeechRequestOptionSet(
    Option<global::AsyncAI.TextToSpeechRequestModelId> ModelId,
                     Option<string> Transcript,
                     Option<global::AsyncAI.LanguageCode?> Language,
                     Option<bool?> Normalize,
                     Option<double?> SpeedControl,
                     Option<int?> Stability)
{
    public static TextToSpeechRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new TextToSpeechRequestOptionSet(
                        ModelId: new Option<global::AsyncAI.TextToSpeechRequestModelId>($"--{normalizedPrefix}model-id")
                {
                    Description = @"",
                    DefaultValueFactory = _ => global::AsyncAI.TextToSpeechRequestModelId.AsyncFlashV10,
                },
                Transcript: new Option<string>($"--{normalizedPrefix}transcript")
                {
                    Description = @"",
                    Required = true,
                },
                Language: new Option<global::AsyncAI.LanguageCode?>($"--{normalizedPrefix}language")
                {
                    Description = @"",
                },
                Normalize: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}normalize", description: @""),
                SpeedControl: new Option<double?>($"--{normalizedPrefix}speed-control")
                {
                    Description = @"",
                },
                Stability: new Option<int?>($"--{normalizedPrefix}stability")
                {
                    Description = @"",
                }
        );
    }
}