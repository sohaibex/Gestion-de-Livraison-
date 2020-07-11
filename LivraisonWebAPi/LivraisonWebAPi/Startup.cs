﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivraisonWebAPi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LivraisonWebAPi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        
            services.AddDbContext<gestion_livraisonContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GestionLivraisonDB")));

            services.AddCors();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(
                Options => Options.WithOrigins("http://localhost:4200")
                 .AllowAnyMethod()
                 .AllowAnyOrigin()
                 .AllowCredentials()
                 
                       .AllowAnyHeader());


            app.UseMvc();
        }
    }
}
