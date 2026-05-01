#!/usr/bin/env bash
set -euo pipefail

# Hand-maintained OpenAPI spec based on Tencent Cloud TokenHub protocol docs:
# https://www.tencentcloud.com/document/product/1300/78941

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace TencentTokenHub \
  --clientClassName TencentTokenHubClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
