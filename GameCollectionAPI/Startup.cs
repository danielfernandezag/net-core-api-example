using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GameCollectionAPI.Repositories;
using GameCollectionAPI.Repositories.Implementation;
using GameCollectionAPI.Services;
using GameCollectionAPI.Services.Implementation;
using GameCollectionAPI.Persistence.Contexts;
using AutoMapper;

namespace GameCollectionAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //services.AddDbContext<GameCollectionDbContext>(options =>
            //{

            //    options.UseSqlServer(Configuration.GetConnectionString("DBGAMESCOLLECTION"));
            //    //options.UseInMemoryDatabase("GAME_COLLECTION_DB");

            //});

            services.AddDbContext<GameCollectionDbContext>(options => options.UseSqlServer(Configuration["ConnectionString:DBGAMESCOLLECTION"]));

            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ICollectionsRepository, CollectionsRepository>();
            services.AddScoped<IGamesRepository, GamesRepository>();

            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<ICollectionsService, CollectionsService>();
            services.AddScoped<IGamesService, GamesService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
