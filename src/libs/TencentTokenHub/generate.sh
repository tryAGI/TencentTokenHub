#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Hand-maintained OpenAPI spec based on Tencent Cloud TokenHub protocol docs:
# https://www.tencentcloud.com/document/product/1300/78941
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace TencentTokenHub \
  --clientClassName TencentTokenHubClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
