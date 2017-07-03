using Microsoft.Data.Entity;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using webservice.Infrastructure.DbManager;
using webservice.Infrastructure.Interface.Repository;
using webservice.Infrastructure.Interface.Service;
using webservice.Infrastructure.Service;

namespace webservice
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Data Source=uqhhs001;Initial Catalog=mi_test_ef;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<ISalesService, SalesService>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddMvc()
                   .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling
                       = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                   .AddJsonOptions(
                       option => option.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

            services.AddCors(options =>
                                    options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                        .AllowAnyMethod()
                                                                        .AllowAnyHeader()
                                                                        .WithMethods("POST", "GET")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseCors("AllowAll");

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                //serviceScope.ServiceProvider.GetService<DatabaseContext>().Database.Migrate();
                serviceScope.ServiceProvider.GetService<DatabaseContext>().EnsureSeedData();
            }


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "api/{controller}/{id?}");
            });

        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
