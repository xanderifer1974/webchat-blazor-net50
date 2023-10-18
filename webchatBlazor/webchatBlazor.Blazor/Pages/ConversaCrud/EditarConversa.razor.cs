using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ConversaCrud
{
    public partial class EditarConversa
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IWebChatService ConversaService { get; set; }

        public List<string> NomesClientes { get; set; }

        [Parameter]
        public int Id { get; set; }

        public WebChat Conversa { get; set; }

        public List<EnunStatus> Status { get; set; } = new List<EnunStatus>();

        protected override void OnInitialized()
        {
            Conversa = ConversaService.BuscarConversaPorId(Id);
            NomesClientes = ConversaService.ListarNomesClientes();
            Status.Add(EnunStatus.Ativo);
            Status.Add(EnunStatus.Inativo);
        }

        public void AtualizarConversa()
        {
            bool atualizacaoBemSucedida = ConversaService.AtualizarConversa(Conversa);

            if (atualizacaoBemSucedida)
            {
                Conversa.Alert.Mensagem = $"Conversa Id: {Conversa.IdChat} referente a pergunta:{Conversa.Pergunta} atualizada com sucesso!";
                Conversa.Alert.Tipo = EnumAlert.Success;
                Conversa.Alert.UrlRedirect = "/conversa";
                Conversa.Alert.Titulo = "Sucesso";
            }
            else
            {
                Conversa.Alert.Mensagem = "Ocorreu um erro ao atualizar a conversa";
                Conversa.Alert.Tipo = EnumAlert.Danger;
                Conversa.Alert.UrlRedirect = "/conversa";
                Conversa.Alert.Titulo = "Erro";

            }

            Conversa.Alert.ShowModal();
            StateHasChanged();
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/conversa");
        }


    }
}
