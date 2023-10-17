using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ConversaCrud
{
    public partial class NovaConversa
    {
        public WebChat Conversa { get; set; }

        public List<string> NomesClientes { get; set; }    

        public List<EnunStatus> ListaStatus { get; set; } = new List<EnunStatus>();

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        IWebChatService WebChatService { get; set; }
       

        [Inject]
        protected IWebChatService ConversaService { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Conversa = new WebChat();
            NomesClientes = ConversaService.ListarNomesClientes();           
            ListaStatus.Add(EnunStatus.Ativo);
            ListaStatus.Add(EnunStatus.Inativo);
        }

        protected void CriaConversa()
        {
           WebChatService.AdicionarConversa(Conversa);
           NavigationManager.NavigateTo("/conversa");

        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/conversa");
        }

        /* TODO - 13/10/2023 >
         * 1 . Fazer a validação do formulário de inserção - OK
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
