# processes

### Available Operations

* [GetProcessInfo](#getprocessinfo)
* [GetRunning](#getrunning)
* [GetStopped](#getstopped)

## GetProcessInfo

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Processes;

var sdk = new HathoraSDK();

var res = await sdk.Processes.GetProcessInfo(new GetProcessInfoSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [GetProcessInfoRequest](../../Models/Processes/GetProcessInfoRequest.md)   | :heavy_check_mark:                                                         | The request object to use for the request.                                 |
| `security`                                                                 | [GetProcessInfoSecurity](../../Models/Processes/GetProcessInfoSecurity.md) | :heavy_check_mark:                                                         | The security requirements to use for the request.                          |


### Response

**[GetProcessInfoResponse](../../Models/Processes/GetProcessInfoResponse.md)**


## GetRunning

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Processes;

var sdk = new HathoraSDK();

var res = await sdk.Processes.GetRunning(new GetRunningProcessesSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `request`                                                                            | [GetRunningProcessesRequest](../../Models/Processes/GetRunningProcessesRequest.md)   | :heavy_check_mark:                                                                   | The request object to use for the request.                                           |
| `security`                                                                           | [GetRunningProcessesSecurity](../../Models/Processes/GetRunningProcessesSecurity.md) | :heavy_check_mark:                                                                   | The security requirements to use for the request.                                    |


### Response

**[GetRunningProcessesResponse](../../Models/Processes/GetRunningProcessesResponse.md)**


## GetStopped

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Processes;

var sdk = new HathoraSDK();

var res = await sdk.Processes.GetStopped(new GetStoppedProcessesSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `request`                                                                            | [GetStoppedProcessesRequest](../../Models/Processes/GetStoppedProcessesRequest.md)   | :heavy_check_mark:                                                                   | The request object to use for the request.                                           |
| `security`                                                                           | [GetStoppedProcessesSecurity](../../Models/Processes/GetStoppedProcessesSecurity.md) | :heavy_check_mark:                                                                   | The security requirements to use for the request.                                    |


### Response

**[GetStoppedProcessesResponse](../../Models/Processes/GetStoppedProcessesResponse.md)**

