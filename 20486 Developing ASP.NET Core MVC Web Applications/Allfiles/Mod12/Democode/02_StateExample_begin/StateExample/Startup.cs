﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace StateExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession(); //Añadimos
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseSession(); // Usamos :)
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
