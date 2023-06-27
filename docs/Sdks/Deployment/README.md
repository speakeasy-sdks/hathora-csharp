# deployment

### Available Operations

* [Create](#create)
* [GetDeploymentInfo](#getdeploymentinfo)
* [GetDeployments](#getdeployments)

## Create

### Example Usage

```csharp
using hathora;
using hathora.Models.Deployment;

var sdk = new HathoraSDK();

var res = await sdk.Deployment.Create(new CreateDeploymentSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateDeploymentRequest](../../Models/Deployment/CreateDeploymentRequest.md)   | :heavy_check_mark:                                                              | The request object to use for the request.                                      |
| `security`                                                                      | [CreateDeploymentSecurity](../../Models/Deployment/CreateDeploymentSecurity.md) | :heavy_check_mark:                                                              | The security requirements to use for the request.                               |


### Response

**[CreateDeploymentResponse](../../Models/Deployment/CreateDeploymentResponse.md)**


## GetDeploymentInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Deployment;

var sdk = new HathoraSDK();

var res = await sdk.Deployment.GetDeploymentInfo(new GetDeploymentInfoSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetDeploymentInfoRequest](../../Models/Deployment/GetDeploymentInfoRequest.md)   | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `security`                                                                        | [GetDeploymentInfoSecurity](../../Models/Deployment/GetDeploymentInfoSecurity.md) | :heavy_check_mark:                                                                | The security requirements to use for the request.                                 |


### Response

**[GetDeploymentInfoResponse](../../Models/Deployment/GetDeploymentInfoResponse.md)**


## GetDeployments

### Example Usage

```csharp
using hathora;
using hathora.Models.Deployment;

var sdk = new HathoraSDK();

var res = await sdk.Deployment.GetDeployments(new GetDeploymentsSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetDeploymentsRequest](../../Models/Deployment/GetDeploymentsRequest.md)   | :heavy_check_mark:                                                          | The request object to use for the request.                                  |
| `security`                                                                  | [GetDeploymentsSecurity](../../Models/Deployment/GetDeploymentsSecurity.md) | :heavy_check_mark:                                                          | The security requirements to use for the request.                           |


### Response

**[GetDeploymentsResponse](../../Models/Deployment/GetDeploymentsResponse.md)**

