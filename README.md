# cKernel with build tools

Single endpoint for all CRUD api

## Usage

Using tool for build dictionary and DLL for your project.

## Example API

```csharp
var service = new S(connectionString, isDebug, uid); //isDebug = true -> show error message in response object, uid is logged user id
var obj = new GCRequest
{
    _a = "fGetgc_App", //Action prefix f,p for get data; gc_App is table name
    _c = new Dictionary< string , object>
    {
        {"Id", appId}   //Condition: Id = appId
    },
    _f = "Id, Name"
};
var robj = service.P(obj); // {Result: 0 is failed, 1 is success, Records: List object array, TotalRecordCount: number of records, Message: error content }
```
