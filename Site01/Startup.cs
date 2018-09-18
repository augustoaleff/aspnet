using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site01.Database;

namespace Site01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //Adiciona o MVC no projeto
            services.AddDbContext<DatabaseContext>(options =>
            {
                //Providers - Bibliotecas Conexão de Banco de Dados - My SQL, SQl Server, oracle ... 
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=site01;Integrated Security=True");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
              app.UseStaticFiles(); //Adiciona para usarmos arquivos estáticos no projeto, como imagens e doctos.
            app.UseMvcWithDefaultRoute(); //Configura o MVC, devemos adicionar as pastas Controllers, Models e Views

           /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
