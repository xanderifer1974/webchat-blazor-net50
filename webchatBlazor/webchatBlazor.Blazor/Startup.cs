using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using webchatBlazor.Business.Clientes;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Conversas;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Data.Repository;
using webchatBlazor.Service;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddTransient<IWebChatService, WebChatService>();
            services.AddTransient<IExibeConversa, ExibeConversa>();
            services.AddTransient<IClienteManager, ClienteManager>();
            services.AddTransient<IConversaManager, ConversaManager>();
            services.AddTransient<IProcuraConversa, ProcuraConversa>();
            services.AddTransient<IClienteService,ClienteService>();
            services.AddTransient<IExibeClientePorCpf,ExibeClientePorCpf>();
            services.AddTransient<IListaClientes, ListaClientes>();
            services.AddTransient<IWebChatRepositorio,WebChatRepositorio>();
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
