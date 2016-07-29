using Microsoft.AspNetCore.Hosting;

namespace CoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();
            
            host.Run();


        }
    }
}
