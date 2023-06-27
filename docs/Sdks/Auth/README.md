# auth

### Available Operations

* [LoginAnonymous](#loginanonymous)
* [LoginGoogle](#logingoogle)
* [LoginNickname](#loginnickname)

## LoginAnonymous

### Example Usage

```csharp
using hathora;
using hathora.Models.Auth;

var sdk = new HathoraSDK();

var res = await sdk.Auth.LoginAnonymous(request);
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [LoginAnonymousRequest](../../Models/Auth/LoginAnonymousRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[LoginAnonymousResponse](../../Models/Auth/LoginAnonymousResponse.md)**


## LoginGoogle

### Example Usage

```csharp
using hathora;
using hathora.Models.Auth;

var sdk = new HathoraSDK();

var res = await sdk.Auth.LoginGoogle(request);
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [LoginGoogleRequest](../../Models/Auth/LoginGoogleRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |


### Response

**[LoginGoogleResponse](../../Models/Auth/LoginGoogleResponse.md)**


## LoginNickname

### Example Usage

```csharp
using hathora;
using hathora.Models.Auth;

var sdk = new HathoraSDK();

var res = await sdk.Auth.LoginNickname(request);
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [LoginNicknameRequest](../../Models/Auth/LoginNicknameRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[LoginNicknameResponse](../../Models/Auth/LoginNicknameResponse.md)**

