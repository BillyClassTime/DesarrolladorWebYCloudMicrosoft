using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ErrorHandlingExample.Services;
using Microsoft.AspNetCore.Http.Extensions;

namespace ErrorHandlingExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<ICounter, Counter>();
            services.AddSingleton<IDivisionCalculator, DivisionCalculator>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ICounter cnt)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/error.html");
            }
            else
            {
                //app.UseExceptionHandler("/error.html");
                app.UseStatusCodePagesWithRedirects("/Error/Http?statusCode={0}");
            }

            app.UseStaticFiles();

            app.Use(async (context, next) =>
            {
                cnt.IncrementRequestPathCount(context.Request.GetDisplayUrl());
                await next.Invoke();
            });

            //app.UseStatusCodePages("text/html","We're <b>really</b> sorry, but something went wrong. Message code:{0}");

            app.UseMvcWithDefaultRoute();

            app.UseStatusCodePagesWithRedirects("/Error/Http?statusCode={0}");

            //app.Run(async (context) => {await context.Response.WriteAsync("/error.htlm"); });
        }
    }
}
