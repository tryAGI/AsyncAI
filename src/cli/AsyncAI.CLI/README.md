# AsyncAI.CLI

Command-line interface for the AsyncAI SDK generated with AutoSDK.

## Installation

```bash
dotnet tool install --global AsyncAI.CLI --prerelease
```

## Usage

```bash
async-ai --help
async-ai api-status --help
```

## Shell completion

The `completion` command prints a script built from the live command tree, so
subcommands, option names and the values of enum-typed options stay correct after the
spec is refreshed and the CLI regenerated — there is no word list to maintain.

```bash
async-ai completion bash > /usr/local/etc/bash_completion.d/async-ai
async-ai completion zsh  > _async-ai   # then put it on your zsh fpath
async-ai completion fish > ~/.config/fish/completions/async-ai.fish
```

## Customization

Generated operation, tag, and API group command classes are partial. Implement
`static partial void CustomizeCommand(ref Command command)` in a separate source
file to add aliases or validators, change the action, or replace a command. The
hook runs after the generated command has been configured.