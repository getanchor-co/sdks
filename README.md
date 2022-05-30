# GetAnchor.co SDK libraries.

| Language |     SDK     |
| -------- | :---------: |
| C#       | sdk/c-sharp |

## C#

### With Swagger Code gen

```
brew install swagger-codegen
cd sdk/csharp/swagger-codegen
swagger-codegen  generate -l csharp -i ../../src/api-docs.json -DpackageName="Co.GetAnchor.Sdk"
```

### With nswag
```
cd sdk/csharp/nswag
nswag
```