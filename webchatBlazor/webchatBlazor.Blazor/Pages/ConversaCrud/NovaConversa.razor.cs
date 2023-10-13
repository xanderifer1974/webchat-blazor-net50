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
    }
}
