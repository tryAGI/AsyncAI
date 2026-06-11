#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static class APIStatusApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"api-status", @"API Status endpoint commands.");
                         command.Subcommands.Add(ApiStatusGetStatusCommandApiCommand.Create());
        return command;
    }
}