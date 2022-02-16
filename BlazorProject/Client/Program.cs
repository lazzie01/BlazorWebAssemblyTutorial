using BlazorProject.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using System;
using System.Threading.Tasks;

namespace BlazorProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTcyOTIyQDMxMzkyZTM0MmUzMG43aFg0aXFsejZCR0p3dVViWGpOMUxad0VpVjhjZi9tbWlpcUdRZGE5RFk9;NTcyOTIzQDMxMzkyZTM0MmUzMEtTSncwU0FOaXNIajRTQVR5NC9vdFkyMlp0UE53RTRySTgreVB6SkFsUVU9;NTcyOTI0QDMxMzkyZTM0MmUzMFN3RjRJSTBxUmNoSkd2Qnk3ZmNzYXlza09hMWxyUVhLK2xMa2l1WUlSOU09;NTcyOTI1QDMxMzkyZTM0MmUzMElwSkdTYWxJT1BXSEhvMEFlNWZ2RjZIMGRXVVNBRFdacnZqc0lSa21lRG89;NTcyOTI2QDMxMzkyZTM0MmUzMEU0K3pTcGF1aVVCUGJUNFFkb2pRTGJOU0liYVZqM3EzeThXM3ZYMERoVzg9;NTcyOTI3QDMxMzkyZTM0MmUzMEVSVXM1VjRhYmQrWFRUdUVxTE9MZlZSZExOLzRUTi9weG1ab2hzcmc5Z1E9;NTcyOTI4QDMxMzkyZTM0MmUzME5HK1JZVHVEY0VzMkZEWlE1Q1cwQWdRM0JVODFWOUF4ekNMSVVrTnl2Tm89;NTcyOTI5QDMxMzkyZTM0MmUzMFpzM09DTkl5bmx4SXhWNjF1SitjYWNZdVlVdmpobWdCNERFRjdGeHU0VHc9;NTcyOTMwQDMxMzkyZTM0MmUzMEdaUTRNU0F5UWFLaFhNKzAzbXpCdGxLWkNyV3BjWVhSVTRsbk5wUGxvM1k9;NTcyOTMxQDMxMzkyZTM0MmUzMGdxNktJTzFFMElvTEdRdStLSnVFOU1QZDZzYWF1UkZGWWMvRGpYbHB0Tm89;NTcyOTMyQDMxMzkyZTM0MmUzMGQ1YXNPdUU1OTRiYlVKSGZ4WlFrWUVSRmxIVFQwa2Y2alpXNUlHTlRsUzA9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });

            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped<EmployeeAdaptor>();
            await builder.Build().RunAsync();
        }
    }
}
