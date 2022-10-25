using Businese_Layer.Service;
using DataLayer.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_web_Api
{
    public class Startup
    {
     

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionStrs = Configuration.GetConnectionString("sqlConnection");
            services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionStrs));
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddTransient<Iarticle, ArticleRepsot>();
            services.AddTransient<Iproduct, ProductRepost>();
            services.AddTransient<Isize, SizeRepost>();
            services.AddTransient<Icolour, ColorRepost>();
            services.AddTransient<ArticleService, ArticleService>();
            services.AddTransient<ProductService, ProductService>();
            services.AddTransient<SizeService, SizeService>();
            services.AddTransient<ColourService, ColourService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie API"));

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
