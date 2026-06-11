#nullable enable

using System.CommandLine;
using AsyncAI.CLI;
using AsyncAI.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the AsyncAI SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(APIStatusApiGroupCommand.Create());
rootCommand.Subcommands.Add(TextToSpeechApiGroupCommand.Create());
rootCommand.Subcommands.Add(VoiceManagementApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);