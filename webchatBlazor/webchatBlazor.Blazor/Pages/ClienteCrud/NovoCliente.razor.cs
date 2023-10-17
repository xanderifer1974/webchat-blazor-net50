using Microsoft.AspNetCore.Components;
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
           
                ClienteService.AdicionarCliente(Cliente);
                NavigationManager.NavigateTo("/cliente");           
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/cliente");
        }

        /* TODO - 13/10/2023 >
        * 1 . Fazer a validação do formulário de inserção - OK > 16/10
        * 2 . Criar o formulário de edição
         * 3 . Criar método para pesquisar conversa por id
         * 4 . Linkar o formulário de edição com o ícone da lista
         * 5 . Criar o método de edição
         * 6.  Fazer a validação da edição
         * 7.  Fazer o método de exclusão
         * 8.  Fazer a validação da exclusão
         * 9.  Criar pergunta se vai excluir
         * 10.  Testar tudo para liberar a POC
         * 
         */
    }
}
