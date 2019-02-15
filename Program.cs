using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace MicroservicesAsp.net
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
			var config = new ConfigurationBuilder().AddCommandLine(args).Build();
			var host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().UseConfiguration(config).Build();
			host.Run();
        }
		
		
		
		
    }
}
