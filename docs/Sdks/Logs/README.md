# logs

### Available Operations

* [GetLogsForApp](#getlogsforapp)
* [GetLogsForDeployment](#getlogsfordeployment)
* [GetLogsForProcess](#getlogsforprocess)

## GetLogsForApp

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Logs;

var sdk = new HathoraSDK();

var res = await sdk.Logs.GetLogsForApp(new GetLogsForAppSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetLogsForAppRequest](../../Models/Logs/GetLogsForAppRequest.md)   | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `security`                                                          | [GetLogsForAppSecurity](../../Models/Logs/GetLogsForAppSecurity.md) | :heavy_check_mark:                                                  | The security requirements to use for the request.                   |


### Response

**[GetLogsForAppResponse](../../Models/Logs/GetLogsForAppResponse.md)**


## GetLogsForDeployment

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Logs;

var sdk = new HathoraSDK();

var res = await sdk.Logs.GetLogsForDeployment(new GetLogsForDeploymentSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetLogsForDeploymentRequest](../../Models/Logs/GetLogsForDeploymentRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [GetLogsForDeploymentSecurity](../../Models/Logs/GetLogsForDeploymentSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |


### Response

**[GetLogsForDeploymentResponse](../../Models/Logs/GetLogsForDeploymentResponse.md)**


## GetLogsForProcess

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Logs;

var sdk = new HathoraSDK();

var res = await sdk.Logs.GetLogsForProcess(new GetLogsForProcessSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetLogsForProcessRequest](../../Models/Logs/GetLogsForProcessRequest.md)   | :heavy_check_mark:                                                          | The request object to use for the request.                                  |
| `security`                                                                  | [GetLogsForProcessSecurity](../../Models/Logs/GetLogsForProcessSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |


### Response

**[GetLogsForProcessResponse](../../Models/Logs/GetLogsForProcessResponse.md)**

