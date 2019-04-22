using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePersuit.Core
{
    public class Startup
    {
  

        public Startup()
        {

        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters();
            

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
