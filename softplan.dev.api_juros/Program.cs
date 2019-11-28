using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace softplan.dev.api_juros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:6000", "https://*:6001");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
