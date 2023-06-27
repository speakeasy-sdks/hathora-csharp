# Deployment

Ok


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `appId`                                                                               | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `buildId`                                                                             | *float*                                                                               | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `containerPort`                                                                       | *int*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `createdAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `createdBy`                                                                           | *string*                                                                              | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `deploymentId`                                                                        | *float*                                                                               | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `env`                                                                                 | List<[DeploymentEnv](../../Models/Shared/DeploymentEnv.md)>   !!!                     | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `planName`                                                                            | [PlanName](../../Models/Shared/PlanName.md)                                           | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `requestedCPU`                                                                        | *float*                                                                               | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `requestedMemoryMB`                                                                   | *float*                                                                               | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `roomsPerProcess`                                                                     | *int*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `transportType`                                                                       | [TransportType](../../Models/Shared/TransportType.md)                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |