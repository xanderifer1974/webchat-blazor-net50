using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages
{
    public partial class ProcurarPorCliente
    {
        [Inject]
        public IClienteService ClienteService { get; set; }

        private IEnumerable<Cliente> Clientes { get; set;}


        protected override void OnInitialized()
        {
            base.OnInitialized();
            //Clientes = ClienteService.ListarClientes();
        }

        private void HandlerSearch(string filter)
        {
            Clientes = ClienteService.ListarClientes(filter);
        }
    }
}
