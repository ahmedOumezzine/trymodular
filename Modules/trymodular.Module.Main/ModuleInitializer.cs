using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using trymodular.Core;
using trymodular.Module.Main.Models;

namespace trymodular.Module.Main
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<SignInManager<User>, SignInManager<User>>();
        }

     
        public void Configure(ApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
