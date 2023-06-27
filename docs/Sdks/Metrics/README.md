# metrics

### Available Operations

* [GetMetrics](#getmetrics)

## GetMetrics

### Example Usage

```csharp
using hathora;
using hathora.Models.Metrics;

var sdk = new HathoraSDK();

var res = await sdk.Metrics.GetMetrics(new GetMetricsSecurity() {
    auth0 = "",
}, request);
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [GetMetricsRequest](../../Models/Metrics/GetMetricsRequest.md)   | :heavy_check_mark:                                               | The request object to use for the request.                       |
| `security`                                                       | [GetMetricsSecurity](../../Models/Metrics/GetMetricsSecurity.md) | :heavy_check_mark:                                               | The security requirements to use for the request.                |


### Response

**[GetMetricsResponse](../../Models/Metrics/GetMetricsResponse.md)**

