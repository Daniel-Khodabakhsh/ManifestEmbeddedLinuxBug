# ManifestEmbeddedLinuxBug
Example project demonstrating a bug with ASP.Net-Core: https://github.com/aspnet/Extensions/issues/1344

To use run:

```
$ cd ManifestEmbeddedLinuxBug.Test
$ dotnet restore
$ dotnet build
$ dotnet test
```

Issue only happens in Linux.

The following callstack is thrown:

```
Test run for /home/dan/ManifestEmbeddedLinuxBug/ManifestEmbeddedLinuxBug.Test/bin/Debug/netcoreapp2.2/ManifestEmbeddedLinuxBug.Test.dll(.NETCoreApp,Version=v2.2)
Microsoft (R) Test Execution Command Line Tool Version 15.9.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
[xUnit.net 00:00:02.13]     ManifestEmbeddedLinuxBug.PageTests.Test_embedded_resource_different_from_root [FAIL]
Failed   ManifestEmbeddedLinuxBug.PageTests.Test_embedded_resource_different_from_root
Error Message:
 System.NullReferenceException : Object reference not set to an instance of an object.
Stack Trace:
   at Microsoft.Extensions.FileProviders.Embedded.Manifest.ManifestFileInfo.EnsureLength()
   at Microsoft.Extensions.FileProviders.Embedded.Manifest.ManifestFileInfo.get_Length()
   at Microsoft.AspNetCore.StaticFiles.StaticFileContext.LookupFileInfo()
   at Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.TestHost.HttpContextBuilder.<>c__DisplayClass10_0.<<SendAsync>b__0>d.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.TestHost.ClientHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Mvc.Testing.Handlers.CookieContainerHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Mvc.Testing.Handlers.RedirectHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at System.Net.Http.HttpClient.FinishSendAsyncBuffered(Task`1 sendTask, HttpRequestMessage request, CancellationTokenSource cts, Boolean disposeCts)
   at ManifestEmbeddedLinuxBug.PageTests.Test_embedded_resource_different_from_root() in /home/dan/ManifestEmbeddedLinuxBug/ManifestEmbeddedLinuxBug.Test/PageTests.cs:line 25
--- End of stack trace from previous location where exception was thrown ---

Total tests: 2. Passed: 1. Failed: 1. Skipped: 0.
Test Run Failed.
Test execution time: 4.6064 Seconds
```
