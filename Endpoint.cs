using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace PolWarmDictionary_Frontend;

public class Endpoint
{
    private readonly IWebAssemblyHostEnvironment _hostEnvironment;
    private readonly IConfiguration _configuration;
    public string Url { get; set; }
    public Endpoint(IWebAssemblyHostEnvironment hostEnvironment, IConfiguration configuration)
    {
        _hostEnvironment = hostEnvironment;
        _configuration = configuration;

        if (_hostEnvironment.Environment == "Development") Url = _configuration["serviceEndpointDevelop"];
        else Url = _configuration["serviceEndpoint"];
    }
}