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
         * 1 . Fazer a validação do formulário de inserção
         * 2 . Criar o formulário de edição
         * 3 . Linkar o formulário de edição com o ícone da lista
         * 4 . Criar o método de edição
         * 5.  Fazer a validação da edição
         * 6.  Fazer o método de exclusão
         * 7.  Fazer a validação da exclusão
         * 8.  Criar pergunta se vai excluir
         * 9.  Testar tudo para liberar a POC
         * 
         */
    }
}
