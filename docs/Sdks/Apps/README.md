# apps

### Available Operations

* [Create](#create)
* [Delete](#delete)
* [GetAppInfo](#getappinfo)
* [GetApps](#getapps)
* [GetBuildInfo](#getbuildinfo)
* [GetBuilds](#getbuilds)
* [Update](#update)

## Create

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.Create(new CreateAppSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [AppConfig](../../Models/Apps/AppConfig.md)                 | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `security`                                                  | [CreateAppSecurity](../../Models/Apps/CreateAppSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |


### Response

**[CreateAppResponse](../../Models/Apps/CreateAppResponse.md)**


## Delete

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.Delete(new DeleteAppSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [DeleteAppRequest](../../Models/Apps/DeleteAppRequest.md)   | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `security`                                                  | [DeleteAppSecurity](../../Models/Apps/DeleteAppSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |


### Response

**[DeleteAppResponse](../../Models/Apps/DeleteAppResponse.md)**


## GetAppInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.GetAppInfo(new GetAppInfoSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetAppInfoRequest](../../Models/Apps/GetAppInfoRequest.md)   | :heavy_check_mark:                                            | The request object to use for the request.                    |
| `security`                                                    | [GetAppInfoSecurity](../../Models/Apps/GetAppInfoSecurity.md) | :heavy_check_mark:                                            | The security requirements to use for the request.             |


### Response

**[GetAppInfoResponse](../../Models/Apps/GetAppInfoResponse.md)**


## GetApps

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.GetApps(new GetAppsSecurity() {
    auth0 = "",
});
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `security`                                              | [GetAppsSecurity](../../Models/Apps/GetAppsSecurity.md) | :heavy_check_mark:                                      | The security requirements to use for the request.       |


### Response

**[GetAppsResponse](../../Models/Apps/GetAppsResponse.md)**


## GetBuildInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.GetBuildInfo(new GetBuildInfoSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetBuildInfoRequest](../../Models/Apps/GetBuildInfoRequest.md)   | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [GetBuildInfoSecurity](../../Models/Apps/GetBuildInfoSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[GetBuildInfoResponse](../../Models/Apps/GetBuildInfoResponse.md)**


## GetBuilds

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.GetBuilds(new GetBuildsSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetBuildsRequest](../../Models/Apps/GetBuildsRequest.md)   | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `security`                                                  | [GetBuildsSecurity](../../Models/Apps/GetBuildsSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |


### Response

**[GetBuildsResponse](../../Models/Apps/GetBuildsResponse.md)**


## Update

### Example Usage

```csharp
using hathora;
using hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.Update(new UpdateAppSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [UpdateAppRequest](../../Models/Apps/UpdateAppRequest.md)   | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `security`                                                  | [UpdateAppSecurity](../../Models/Apps/UpdateAppSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |


### Response

**[UpdateAppResponse](../../Models/Apps/UpdateAppResponse.md)**

