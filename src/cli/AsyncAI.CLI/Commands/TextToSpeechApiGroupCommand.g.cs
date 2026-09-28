#nullable enable

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class TextToSpeechApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"text-to-speech", @"Text to Speech endpoint commands.");
                         command.Subcommands.Add(TextToSpeechStreamSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechSynthesizeSpeechCommandApiCommand.Create());
                         command.Subcommands.Add(TextToSpeechSynthesizeSpeechWithTimestampsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}