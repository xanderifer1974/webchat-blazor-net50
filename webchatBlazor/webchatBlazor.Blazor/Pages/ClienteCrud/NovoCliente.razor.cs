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
        * 2 . Criar o formulário de edição - OK
         * 3 . Criar método para pesquisar conversa por id - OK
         * 4 . Linkar o formulário de edição com o ícone da lista OK
         * 5 . Criar o método de edição - OK
         * 6.  Fazer a validação da edição - OK
         * 7.  Criar a modal de edição - OK
         * 8.  Fazer o método de exclusão
         * 9.  Fazer a validação da exclusão
         * 10.  Criar pergunta se vai excluir
         * 11.  Testar tudo para liberar a POC
         * -------
         * Exemplo para a modal de exclusão
         * https://getbootstrap.com/docs/5.0/components/modal/
         * Vai precisar alterar o componente modal, para colocar o botão com o método de exclusão.
         */
    }
}
