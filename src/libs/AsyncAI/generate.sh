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
