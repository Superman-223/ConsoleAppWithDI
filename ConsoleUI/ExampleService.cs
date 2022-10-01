using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;



// Using Ingection Dependancy, Serilog and Settings

namespace ConsoleUI
{
    public class ExampleService : IExampleService
    {
        private readonly ILogger<ExampleService> _log;
        private readonly IConfiguration _config;

        public ExampleService(ILogger<ExampleService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        public void Courir()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
