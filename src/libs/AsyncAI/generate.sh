#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace AsyncAI \
  --clientClassName AsyncAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:X-Api-Key \
  --exclude-deprecated-operations

rm -rf ../../cli/AsyncAI.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/AsyncAI.CLI \
  --sdk-project ../../libs/AsyncAI/AsyncAI.csproj \
  --targetFramework net10.0 \
  --namespace AsyncAI \
  --clientClassName AsyncAIClient \
  --package-id AsyncAI.CLI \
  --tool-command-name async-ai \
  --user-secrets-id AsyncAI.CLI \
  --api-key-env-var ASYNCAI_API_KEY \
  --base-url-env-var ASYNCAI_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-Api-Key
