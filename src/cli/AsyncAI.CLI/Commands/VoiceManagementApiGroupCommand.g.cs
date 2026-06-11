#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static class VoiceManagementApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voice-management", @"Voice Management endpoint commands.");
                         command.Subcommands.Add(VoiceManagementCloneVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementDeleteVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementGetVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementGetVoicePreviewCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementGetVoicesBatchCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementListVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(VoiceManagementUpdateVoiceCommandApiCommand.Create());
        return command;
    }
}