using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Encryption_Login.Data;
using Encryption_Login.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Encryption_Login {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            //AutoMapper
            services.AddAutoMapper (AppDomain.CurrentDomain.GetAssemblies ());

            // using Microsoft.EntityFrameworkCore;
            services.AddDbContext<logindbContext> (options =>
                options.UseMySQL (Configuration.GetConnectionString ("Default")));

            //Scoped
            services.AddScoped<ILoginDetailsRepository, LoginDetailsRepository> ();

            //MVC
            services.AddControllers ();

            //Swagger
            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new Microsoft.OpenApi.Models.OpenApiInfo {
                    Title = "Invoice Manager WebAPI",
                        Description = "FSD 24 ",
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

            app.UseSwagger ();
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "Invoice Manager V1");
            });
        }
    }
}