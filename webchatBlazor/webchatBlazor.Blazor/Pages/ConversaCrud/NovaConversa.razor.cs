using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Pages.ConversaCrud
{
    public partial class NovaConversa
    {
        public WebChat Conversa { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        public NovaConversa()
        {
            Conversa = new WebChat();
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
