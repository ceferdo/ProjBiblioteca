using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Infrastructure.Data.Context;
using ProjBiblioteca.Infrastructure.IoC;
using ProjBiblioteca.WebApi.Filters;

namespace ProjBiblioteca.WebApi
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
            services.AddControllers();

            services.AddMvc(opt =>
            {
                opt.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<LivroInputModelValidator>());

            //Add using Microsoft.EntityFrameworkCore; para aparecer a opção Use
            string conn = Configuration.GetConnectionString("DefaultConnection");
                
            services.AddDbContext<BibliotecaDBContext>(Options => 
                Options.UseNpgsql(conn));

            DependencyContainer.RegisterMappers(services);
            DependencyContainer.RegisterContexts(services, conn);    
            DependencyContainer.RegisterServices(services);

            // Adicionar no final do método:
            services.AddControllers().AddNewtonsoftJson(options=>
                options.SerializerSettings.ReferenceLoopHandling=
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
