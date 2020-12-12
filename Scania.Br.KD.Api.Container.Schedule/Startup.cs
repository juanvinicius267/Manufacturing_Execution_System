using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scania.Br.KD.Api.Container.Schedule.Dao;
using Scania.Br.KD.Api.Container.Schedule.Data;

namespace Scania.Br.KD.Api.Container.Schedule
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors(c =>
            {
            c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .AllowCredentials()
                );
            });
            services.AddDbContext<KdexContext > (options =>
                   options.UseSqlServer(Configuration.GetConnectionString("db_kdex")));
            services.AddDbContext<ContainerContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("db_ScheduleContainer")));
            services.AddSession();
            services.AddTransient<ContainerDao>();
            services.AddTransient<DockDao>();
            services.AddTransient<LineDao>();
            services.AddTransient<ContainerTypeDao>();

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
            // Shows UseCors with CorsPolicyBuilder.
            app.UseCors(options => options.AllowAnyOrigin()
                                                            .AllowAnyHeader()
                                                            .AllowAnyMethod()
                                                            .AllowCredentials());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
