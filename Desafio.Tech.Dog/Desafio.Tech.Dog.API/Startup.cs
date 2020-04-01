using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Desafio.Tech.Dog.Repository.CrossCutting;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Tech.Dog.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.InvokeD();
            //services.ConfigEntityFramework();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ControleDeAgendamento.API", Version = "v1" });
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.DocumentFilterDescriptors.AsReadOnly();
                c.CustomSchemaIds(i => i.FullName);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("v1/swagger.json", "Desafio Tech Dog");
                    c.DefaultModelExpandDepth(0);
                    c.DefaultModelsExpandDepth(-1);
                });

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
    }
}
