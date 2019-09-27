# Example AWS Lambda C# .NET Core 3.0 Release with connect MySQL via EF Core

Based from https://github.com/ifew/aws-lambda-efcore and migrate to .NET CORE 3.0

## List of update
- .NET Core 2.2 to 3.0
- Amazon.Lambda.Serialization.Json 1.5.0 to 1.6.0
- MySql.Data 8.0.15 to 8.0.17
- MySql.Data.EntityFrameworkCore 8.0.15 t0 8.0.17

## NOW Microsoft.EntityFrameworkCore 3.0.0 NOT SUPPORT MySql.Data (Tested on 8.0.17)

## Test and Deploy with AWS CLI

**Deploy**
```
$ cd src/aws-lambda-netcore3-efcore
$ dotnet lambda deploy-function {LAMBDA_FUNCTION_NAME} –-function-role {ROLE_NAME}
```

**Try to Run and Get result**
```
$ cd src/aws-lambda-netcore3-efcore
$ aws lambda invoke --function-name {LAMBDA_FUNCTION_NAME} output.txt
```