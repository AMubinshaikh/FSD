using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Swagger_2.Data;
using Swagger_2.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Swagger_2 {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddControllers ();
            services.AddAutoMapper (AppDomain.CurrentDomain.GetAssemblies ());

            // Db context
            services.AddDbContext<sql_storeContext> (options => options.UseMySQL (Configuration.GetConnectionString ("Default")));

            //Dependency
            services.AddScoped<ISqlStoreRepository, SqlCustomerRepository> ();

            //json patch
            services.AddControllers ().AddNewtonsoftJson (s => { s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver (); });

            //swagger
            services.AddControllers ();
            services.AddControllers ();
            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new Microsoft.OpenApi.Models.OpenApiInfo {

                    Title = "Test API",
                        Description = "ASP.NET Core Web API",
                        Version = "v1"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseHttpsRedirection ();

            app.UseRouting ();

            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapControllers ();
            });

            //swagger

            app.UseSwagger ();
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "Test API V1");
            });

        }
    }
}