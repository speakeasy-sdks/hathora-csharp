# rooms

### Available Operations

* [Create](#create)
* [Destroy](#destroy)
* [GetActive](#getactive)
* [GetConnectionInfo](#getconnectioninfo)
* [GetInactive](#getinactive)
* [GetRoomInfo](#getroominfo)
* [Suspend](#suspend)

## Create

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.Create(new CreateRoomSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [CreateRoomRequest](../../Models/Rooms/CreateRoomRequest.md)   | :heavy_check_mark:                                             | The request object to use for the request.                     |
| `security`                                                     | [CreateRoomSecurity](../../Models/Rooms/CreateRoomSecurity.md) | :heavy_check_mark:                                             | The security requirements to use for the request.              |


### Response

**[CreateRoomResponse](../../Models/Rooms/CreateRoomResponse.md)**


## Destroy

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.Destroy(new DestroyRoomSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [DestroyRoomRequest](../../Models/Rooms/DestroyRoomRequest.md)   | :heavy_check_mark:                                               | The request object to use for the request.                       |
| `security`                                                       | [DestroyRoomSecurity](../../Models/Rooms/DestroyRoomSecurity.md) | :heavy_check_mark:                                               | The security requirements to use for the request.                |


### Response

**[DestroyRoomResponse](../../Models/Rooms/DestroyRoomResponse.md)**


## GetActive

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.GetActive(new GetActiveRoomsForProcessSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `request`                                                                                  | [GetActiveRoomsForProcessRequest](../../Models/Rooms/GetActiveRoomsForProcessRequest.md)   | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `security`                                                                                 | [GetActiveRoomsForProcessSecurity](../../Models/Rooms/GetActiveRoomsForProcessSecurity.md) | :heavy_check_mark:                                                                         | The security requirements to use for the request.                                          |


### Response

**[GetActiveRoomsForProcessResponse](../../Models/Rooms/GetActiveRoomsForProcessResponse.md)**


## GetConnectionInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.GetConnectionInfo(request);
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [GetConnectionInfoRequest](../../Models/Rooms/GetConnectionInfoRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |


### Response

**[GetConnectionInfoResponse](../../Models/Rooms/GetConnectionInfoResponse.md)**


## GetInactive

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.GetInactive(new GetInactiveRoomsForProcessSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `request`                                                                                      | [GetInactiveRoomsForProcessRequest](../../Models/Rooms/GetInactiveRoomsForProcessRequest.md)   | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |
| `security`                                                                                     | [GetInactiveRoomsForProcessSecurity](../../Models/Rooms/GetInactiveRoomsForProcessSecurity.md) | :heavy_check_mark:                                                                             | The security requirements to use for the request.                                              |


### Response

**[GetInactiveRoomsForProcessResponse](../../Models/Rooms/GetInactiveRoomsForProcessResponse.md)**


## GetRoomInfo

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.GetRoomInfo(new GetRoomInfoSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [GetRoomInfoRequest](../../Models/Rooms/GetRoomInfoRequest.md)   | :heavy_check_mark:                                               | The request object to use for the request.                       |
| `security`                                                       | [GetRoomInfoSecurity](../../Models/Rooms/GetRoomInfoSecurity.md) | :heavy_check_mark:                                               | The security requirements to use for the request.                |


### Response

**[GetRoomInfoResponse](../../Models/Rooms/GetRoomInfoResponse.md)**


## Suspend

### Example Usage

```csharp
using hathora;
using hathora.Models.Rooms;

var sdk = new HathoraSDK();

var res = await sdk.Rooms.Suspend(new SuspendRoomSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [SuspendRoomRequest](../../Models/Rooms/SuspendRoomRequest.md)   | :heavy_check_mark:                                               | The request object to use for the request.                       |
| `security`                                                       | [SuspendRoomSecurity](../../Models/Rooms/SuspendRoomSecurity.md) | :heavy_check_mark:                                               | The security requirements to use for the request.                |


### Response

**[SuspendRoomResponse](../../Models/Rooms/SuspendRoomResponse.md)**

