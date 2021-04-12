Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Hosting
Imports Microsoft.Extensions.Logging

Module Program
    Sub Main(args As String())
        CreateHostBuilder(args).Build().Run()
    End Sub

    Public Function CreateHostBuilder(args() As String) As IHostBuilder
        Return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
               Sub(webBuilder)
                   webBuilder.UseStartup(Of Startup)()
               End Sub
        ).ConfigureLogging(
                Sub(loggerFactory)
                    loggerFactory.AddConsole()
                    loggerFactory.AddDebug()
                End Sub
        )
    End Function
End Module
