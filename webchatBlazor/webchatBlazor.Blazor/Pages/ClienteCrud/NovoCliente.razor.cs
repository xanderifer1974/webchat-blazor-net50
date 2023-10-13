using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ClienteCrud
{
    public partial class NovoCliente
    {
        public Cliente Cliente { get; set; }

        public List<EnunStatus> Status { get; set; } = new List<EnunStatus>();

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        IClienteService ClienteService { get; set; }
       


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Cliente = new Cliente();
            Status.Add(EnunStatus.Ativo);
            Status.Add(EnunStatus.Inativo);          
                      
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
