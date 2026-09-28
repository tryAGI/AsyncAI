#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class APIStatusApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"api-status", @"API Status endpoint commands.");
                         command.Subcommands.Add(ApiStatusGetStatusCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}