using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ClienteCrud
{
    public partial class NovoCliente
    {
        public Cliente Cliente { get; set; }

        public Dictionary<bool,string> Status { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        IClienteService ClienteService { get; set; }
       


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Cliente = new Cliente();
            Status = new Dictionary<bool, string>();
            Status.Add(true, "Ativo");
            Status.Add(false, "Inativo");           
           
            
        }

        protected void CriarCliente()
        {
            //Colocar a lógica de criação do cliente
            if(Cliente == null)
            {
                Console.WriteLine("O cliente está nulo");
            }
            else
            {
                ClienteService.AdicionarCliente(Cliente);
                NavigationManager.NavigateTo("/cliente");

            }
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/cliente");
        }
    }
}
