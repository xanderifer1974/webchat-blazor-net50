using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ConversaCrud
{
    public partial class DeletarConversar
    {
        [Inject]
        public IWebChatService ConversaService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Parameter]
        public int id { get; set; }

        public WebChat Conversa { get; set; }

        protected override void OnInitialized()
        {
            Conversa = ConversaService.BuscarConversaPorId(id);

        }

        protected void ExcluirConversa()
        {
            if (Conversa != null)
            {
                ConversaService.DeletarConversa(id);
                Conversa.Alert.Mensagem = $"Conversa Id: {Conversa.IdChat} -  Pergunta :{Conversa.Pergunta} excluida com sucesso!";
                Conversa.Alert.Tipo = EnumAlert.Success;
                Conversa.Alert.UrlRedirect = "/conversa";
                Conversa.Alert.Titulo = "Conversa Excluída";
            }
            else
            {
                Conversa.Alert.Mensagem = $"Não foi possível excluir a conversa id: {id}!";
                Conversa.Alert.Tipo = EnumAlert.Danger;
                Conversa.Alert.UrlRedirect = "/conversa";
                Conversa.Alert.Titulo = "Erro ao Excluir Conversa";
            }

            Conversa.Alert.ShowModal();
            StateHasChanged();
        }

        protected void Cancela()
        {
            Navigation.NavigateTo("/conversa");
        }

    }
}
