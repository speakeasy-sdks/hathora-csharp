<!-- Start SDK Example Usage -->
```csharp
using Hathora;
using Hathora.Models.Apps;

var sdk = new HathoraSDK();

var res = await sdk.Apps.Create(new CreateAppSecurity() {
    auth0 = "",
}, request);
```
<!-- End SDK Example Usage -->