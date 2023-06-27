# lobby

### Available Operations

* [Create](#create)
* [~~DeprecatedCreateLocalLobby~~](#deprecatedcreatelocallobby) - :warning: **Deprecated**
* [~~DeprecatedCreatePrivateLobby~~](#deprecatedcreateprivatelobby) - :warning: **Deprecated**
* [~~DeprecatedCreatePublicLobby~~](#deprecatedcreatepubliclobby) - :warning: **Deprecated**
* [~~DeprecatedV1CreatePrivateLobby~~](#deprecatedv1createprivatelobby) - :warning: **Deprecated**
* [~~DeprecatedV1CreatePublicLobby~~](#deprecatedv1createpubliclobby) - :warning: **Deprecated**
* [~~DeprecatedV1ListActivePublicLobbies~~](#deprecatedv1listactivepubliclobbies) - :warning: **Deprecated**
* [GetLobbyInfo](#getlobbyinfo)
* [ListActive](#listactive)
* [SetLobbyState](#setlobbystate)

## Create

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.Create(request);
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [CreateLobbyRequest](../../Models/Lobby/CreateLobbyRequest.md) | :heavy_check_mark:                                             | The request object to use for the request.                     |


### Response

**[CreateLobbyResponse](../../Models/Lobby/CreateLobbyResponse.md)**


## ~~DeprecatedCreateLocalLobby~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedCreateLocalLobby(request);
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `request`                                                                                    | [DeprecatedCreateLocalLobbyRequest](../../Models/Lobby/DeprecatedCreateLocalLobbyRequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |


### Response

**[DeprecatedCreateLocalLobbyResponse](../../Models/Lobby/DeprecatedCreateLocalLobbyResponse.md)**


## ~~DeprecatedCreatePrivateLobby~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedCreatePrivateLobby(request);
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `request`                                                                                        | [DeprecatedCreatePrivateLobbyRequest](../../Models/Lobby/DeprecatedCreatePrivateLobbyRequest.md) | :heavy_check_mark:                                                                               | The request object to use for the request.                                                       |


### Response

**[DeprecatedCreatePrivateLobbyResponse](../../Models/Lobby/DeprecatedCreatePrivateLobbyResponse.md)**


## ~~DeprecatedCreatePublicLobby~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedCreatePublicLobby(request);
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `request`                                                                                      | [DeprecatedCreatePublicLobbyRequest](../../Models/Lobby/DeprecatedCreatePublicLobbyRequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |


### Response

**[DeprecatedCreatePublicLobbyResponse](../../Models/Lobby/DeprecatedCreatePublicLobbyResponse.md)**


## ~~DeprecatedV1CreatePrivateLobby~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedV1CreatePrivateLobby(request);
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `request`                                                                                            | [DeprecatedV1CreatePrivateLobbyRequest](../../Models/Lobby/DeprecatedV1CreatePrivateLobbyRequest.md) | :heavy_check_mark:                                                                                   | The request object to use for the request.                                                           |


### Response

**[DeprecatedV1CreatePrivateLobbyResponse](../../Models/Lobby/DeprecatedV1CreatePrivateLobbyResponse.md)**


## ~~DeprecatedV1CreatePublicLobby~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedV1CreatePublicLobby(request);
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `request`                                                                                          | [DeprecatedV1CreatePublicLobbyRequest](../../Models/Lobby/DeprecatedV1CreatePublicLobbyRequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |


### Response

**[DeprecatedV1CreatePublicLobbyResponse](../../Models/Lobby/DeprecatedV1CreatePublicLobbyResponse.md)**


## ~~DeprecatedV1ListActivePublicLobbies~~

> :warning: **DEPRECATED**: this method will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.DeprecatedV1ListActivePublicLobbies(request);
```

### Parameters

| Parameter                                                                                                      | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                      | [DeprecatedV1ListActivePublicLobbiesRequest](../../Models/Lobby/DeprecatedV1ListActivePublicLobbiesRequest.md) | :heavy_check_mark:                                                                                             | The request object to use for the request.                                                                     |


### Response

**[DeprecatedV1ListActivePublicLobbiesResponse](../../Models/Lobby/DeprecatedV1ListActivePublicLobbiesResponse.md)**


## GetLobbyInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.GetLobbyInfo(request);
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [GetLobbyInfoRequest](../../Models/Lobby/GetLobbyInfoRequest.md) | :heavy_check_mark:                                               | The request object to use for the request.                       |


### Response

**[GetLobbyInfoResponse](../../Models/Lobby/GetLobbyInfoResponse.md)**


## ListActive

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.ListActive(request);
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [ListActivePublicLobbiesRequest](../../Models/Lobby/ListActivePublicLobbiesRequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |


### Response

**[ListActivePublicLobbiesResponse](../../Models/Lobby/ListActivePublicLobbiesResponse.md)**


## SetLobbyState

### Example Usage

```csharp
using hathora;
using hathora.Models.Lobby;

var sdk = new HathoraSDK();

var res = await sdk.Lobby.SetLobbyState(new SetLobbyStateSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [SetLobbyStateRequest](../../Models/Lobby/SetLobbyStateRequest.md)   | :heavy_check_mark:                                                   | The request object to use for the request.                           |
| `security`                                                           | [SetLobbyStateSecurity](../../Models/Lobby/SetLobbyStateSecurity.md) | :heavy_check_mark:                                                   | The security requirements to use for the request.                    |


### Response

**[SetLobbyStateResponse](../../Models/Lobby/SetLobbyStateResponse.md)**

