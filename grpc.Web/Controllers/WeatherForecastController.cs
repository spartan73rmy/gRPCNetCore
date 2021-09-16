using Existence.grpc.Protos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace grpc.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly HelloWorld.HelloWorldClient client;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, HelloWorld.HelloWorldClient client)
        {
            _logger = logger;
            this.client = client;
        }


        [HttpGet("Saludo/{name}/{year}")]
        public string GetGRPC(string name, int year)
        {
            return client.SayHello(new HelloRequest { Name = name, Year = year }).Message;
        }
    }
}
