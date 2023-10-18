using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ClienteCrud
{
    public partial class DeletarCliente
    {
        [Inject]
        public IClienteService ClienteService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Parameter]
        public int id { get; set; }

        public Cliente Cliente { get; set; }

        protected override void OnInitialized()
        {
            Cliente = ClienteService.BuscarClientePorId(id);

        }

        protected void ExcluirCliente()
        {
            if (Cliente != null)
            {
                ClienteService.DeletarCliente(id);
                Cliente.Alert.Mensagem = $"Cliente Id: {Cliente.IdCliente} -  Nome :{Cliente.NomeCompleto} excluido com sucesso!";
                Cliente.Alert.Tipo = EnumAlert.Success;
                Cliente.Alert.UrlRedirect = "/cliente";
                Cliente.Alert.Titulo = "Cliente Excluído";
            }
            else
            {
                Cliente.Alert.Mensagem = $"Não foi possível excluir o cliente id: {id}!";
                Cliente.Alert.Tipo = EnumAlert.Danger;
                Cliente.Alert.UrlRedirect = "/cliente";
                Cliente.Alert.Titulo = "Erro ao Excluir Cliente";
            }

            Cliente.Alert.ShowModal();
            StateHasChanged();
        }

        protected void Cancela()
        {
            Navigation.NavigateTo("/cliente");
        }


    }
}
