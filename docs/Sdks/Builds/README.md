# builds

### Available Operations

* [Create](#create)
* [Delete](#delete)
* [Run](#run)

## Create

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Builds;

var sdk = new HathoraSDK();

var res = await sdk.Builds.Create(new CreateBuildSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateBuildRequest](../../Models/Builds/CreateBuildRequest.md)   | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [CreateBuildSecurity](../../Models/Builds/CreateBuildSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[CreateBuildResponse](../../Models/Builds/CreateBuildResponse.md)**


## Delete

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Builds;

var sdk = new HathoraSDK();

var res = await sdk.Builds.Delete(new DeleteBuildSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [DeleteBuildRequest](../../Models/Builds/DeleteBuildRequest.md)   | :heavy_check_mark:                                                | The request object to use for the request.                        |
| `security`                                                        | [DeleteBuildSecurity](../../Models/Builds/DeleteBuildSecurity.md) | :heavy_check_mark:                                                | The security requirements to use for the request.                 |


### Response

**[DeleteBuildResponse](../../Models/Builds/DeleteBuildResponse.md)**


## Run

### Example Usage

```csharp
using Hathora;
using Hathora.Models.Builds;

var sdk = new HathoraSDK();

var res = await sdk.Builds.Run(new RunBuildSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [RunBuildRequest](../../Models/Builds/RunBuildRequest.md)   | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `security`                                                  | [RunBuildSecurity](../../Models/Builds/RunBuildSecurity.md) | :heavy_check_mark:                                          | The security requirements to use for the request.           |


### Response

**[RunBuildResponse](../../Models/Builds/RunBuildResponse.md)**

