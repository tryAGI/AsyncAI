#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal sealed record VoiceSelectorOptionSet(
    Option<global::AsyncAI.VoiceSelectorMode> Mode,
                     Option<string> Id)
{
    public static VoiceSelectorOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new VoiceSelectorOptionSet(
                        Mode: new Option<global::AsyncAI.VoiceSelectorMode>($"--{normalizedPrefix}mode")
                {
                    Description = @"",
                },
                Id: new Option<string>($"--{normalizedPrefix}id")
                {
                    Description = @"",
                    Required = true,
                }
        );
    }
}