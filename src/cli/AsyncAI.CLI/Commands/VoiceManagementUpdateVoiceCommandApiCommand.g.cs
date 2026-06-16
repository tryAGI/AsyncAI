#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace AsyncAI.CLI.Commands;

internal static partial class VoiceManagementUpdateVoiceCommandApiCommand
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

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<global::AsyncAI.Gender?> Gender { get; } = new(
        name: @"--gender")
    {
        Description = @"",
    };

    private static Option<string?> Style { get; } = new(
        name: @"--style")
    {
        Description = @"",
    };

    private static Option<string?> Accent { get; } = new(
        name: @"--accent")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"update-voice", @"Update voice
Updates metadata for a cloned voice.");
                        command.Arguments.Add(Id);
                        command.Options.Add(Version);
                        command.Options.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Gender);
                        command.Options.Add(Style);
                        command.Options.Add(Accent);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::AsyncAI.UpdateVoiceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::AsyncAI.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var version = parseResult.GetValue(Version);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var gender = CliRuntime.WasSpecified(parseResult, Gender) ? parseResult.GetValue(Gender) : (__requestBase is { } __GenderBaseValue ? __GenderBaseValue.Gender : default);
                        var style = CliRuntime.WasSpecified(parseResult, Style) ? parseResult.GetValue(Style) : (__requestBase is { } __StyleBaseValue ? __StyleBaseValue.Style : default);
                        var accent = CliRuntime.WasSpecified(parseResult, Accent) ? parseResult.GetValue(Accent) : (__requestBase is { } __AccentBaseValue ? __AccentBaseValue.Accent : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.VoiceManagement.UpdateVoiceAsync(
                                    id: id,
                                    version: version,
                                    name: name,
                                    description: description,
                                    gender: gender,
                                    style: style,
                                    accent: accent,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}