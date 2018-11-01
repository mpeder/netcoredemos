using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace aspnetlinuxdocker
{
    public class Startup
    {
        string responseHTML = "<!DOCTYPE html>\r\n<html>\r\n        <head>\r\n                <style>\r\n                 body {\r\n                   background-color: powderblue;\r\n                 }\r\n                 h1  {\r\n                   color: blue;\r\n                 }\r\n                 p  {\r\n                   color: red;\r\n                   font-family: \"Courier New\", Times, serif;\r\n                 }\r\n                </style>\r\n               </head>\r\n<body>\r\n\r\n<p>\r\n    <pre>\r\n    \"Hey there I am Clippy served from .NET Core :-)\"\r\n       \\\r\n        \\\r\n           __\r\n          /  \\\r\n          |  |\r\n          @  @\r\n          |  |\r\n          || |/\r\n          || ||\r\n          |\\_/|\r\n          \\___/\r\n        </pre>\r\n</p>\r\n</body>\r\n</html>";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(responseHTML);
            });
        }
    }
}
