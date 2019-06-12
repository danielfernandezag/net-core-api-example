using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using GameCollectionAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace GameCollectionAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args);

            using (var scope = host.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<GameCollectionDbContext>())
            {
                context.Database.EnsureCreated();
            }

            host.Run();

        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().Build();
    }
}
