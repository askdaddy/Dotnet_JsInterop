using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;


public class Program
{
    private static IJSRuntime _js;

    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        var host = builder.Build();
        _js = host.Services.GetRequiredService<IJSRuntime>();
        await host.RunAsync();
    }

    [JSInvokable("echo")]
    public static async void GetMsgAndPrint(string msg)
    {
        await _js.InvokeVoidAsync("Logger", msg);
    }
}