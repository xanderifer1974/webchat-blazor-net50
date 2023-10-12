using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ConversaCrud
{
    public partial class NovaConversa
    {
        public WebChat Conversa { get; set; }

        public List<string> NomesClientes { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }
       

        [Inject]
        protected IWebChatService ConversaService { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Conversa = new WebChat();
            NomesClientes = ConversaService.ListarNomesClientes();
        }

        protected void CriaConversa()
        {
            //Colocar a lógica de criação da conversa aqui.
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/conversa");
        }
    }
}
