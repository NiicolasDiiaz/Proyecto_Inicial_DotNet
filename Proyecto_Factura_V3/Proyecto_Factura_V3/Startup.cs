using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Proyecto_Factura_V3", 
                    Version = "v1",

                    //Info adicional a la estandar:
                    Description = "API para una factura",
                    TermsOfService = new Uri("https://google.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Nicolas Diaz",
                        Email = "nicolas.diaz@teaminternational.com",
                        Url = new Uri("https://google.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "License type ",
                        Url = new Uri("https://google.com")
                    }
                });
            });

            //Adding local database:
            services.AddDbContext<DDBBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );

            //Database injection:
            services.AddTransient<IDDBBContext, DDBBContext>();

            //Respos injection:
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ITaxRateRepository, TaxRateRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IBranchRepository, BranchRepository>();

            //Services injection:
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ITaxRateService, TaxRateService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IBranchService, BranchService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proyecto_Factura_V3 v1"));
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
