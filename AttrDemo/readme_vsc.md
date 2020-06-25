# Til VS Code udvikling

## Certifikat

Tilføj certifikat gennem

```
dotnet dev-certs https --trust
```

Se https://www.hanselman.com/blog/DevelopingLocallyWithASPNETCoreUnderHTTPSSSLAndSelfSignedCerts.aspx

## LibMan

Installering gennem 

```
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
``` 

og restore gennem

```
libman restore
```

Se https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/libman-cli?view=aspnetcore-3.1