#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal sealed record OutputFormatOptionSet(
    Option<global::AsyncAI.OutputFormatContainer> Container,
                     Option<global::AsyncAI.OutputFormatEncoding?> Encoding,
                     Option<int> SampleRate,
                     Option<int?> BitRate)
{
    public static OutputFormatOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new OutputFormatOptionSet(
                        Container: new Option<global::AsyncAI.OutputFormatContainer>($"--{normalizedPrefix}container")
                {
                    Description = @"",
                    Required = true,
                },
                Encoding: new Option<global::AsyncAI.OutputFormatEncoding?>($"--{normalizedPrefix}encoding")
                {
                    Description = @"",
                },
                SampleRate: new Option<int>($"--{normalizedPrefix}sample-rate")
                {
                    Description = @"",
                    Required = true,
                },
                BitRate: new Option<int?>($"--{normalizedPrefix}bit-rate")
                {
                    Description = @"",
                }
        );
    }
}