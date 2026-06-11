#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(APIStatusApiGroupCommand.Create());
                         command.Subcommands.Add(TextToSpeechApiGroupCommand.Create());
                         command.Subcommands.Add(VoiceManagementApiGroupCommand.Create());
        return command;
    }
}