#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class VoiceManagementDeleteVoiceCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Voice id.",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"API version header.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-voice", @"Delete voice
Deletes a cloned voice by id.");
                        command.Arguments.Add(Id);
                        command.Options.Add(Version);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var version = parseResult.GetValue(Version);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.VoiceManagement.DeleteVoiceAsync(
                                    id: id,
                                    version: version,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}