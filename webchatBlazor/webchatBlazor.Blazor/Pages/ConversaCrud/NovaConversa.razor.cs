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
            //Colocar a lógica de criação da conversa aqui.
            // TODO >> Precisa fazer uma lógica para pegar o último id da conversa, e na hora de adicionar na lista deve ser somado + 1
            // Em relação ao Status, fazer uma combox que aparece Ativo e Inativo, mas que grave na classe true ou false
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/conversa");
        }
    }
}
