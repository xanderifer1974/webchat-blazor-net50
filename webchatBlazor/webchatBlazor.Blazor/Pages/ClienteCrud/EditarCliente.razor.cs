using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages.ClienteCrud
{
    public partial class EditarCliente
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IClienteService ClienteService { get; set; }

        [Parameter]
        public int Id{ get; set; }

        public Cliente Cliente { get; set; }

        public List<EnunStatus> Status { get; set; } = new List<EnunStatus>();      

        protected override void OnInitialized()
        {
            Cliente = ClienteService.BuscarClientePorId(Id);
            Status.Add(EnunStatus.Ativo);
            Status.Add(EnunStatus.Inativo);
        }

        public void AtualizarCliente()
        {
            bool atualizacaoBemSucedida = ClienteService.AtualizarCliente(Cliente);

            if (atualizacaoBemSucedida)
            {
                Cliente.Alert.Mensagem = $"Cliente {Cliente.IdCliente} - {Cliente.Nome} Atualizado com sucesso!";
                Cliente.Alert.Tipo = EnumAlert.Success;
                Cliente.Alert.UrlRedirect = "/cliente";
                Cliente.Alert.Titulo = "Sucesso";               
            }
            else  
            {
                Cliente.Alert.Mensagem = "Ocorreu um erro ao atualizar o cliente";
                Cliente.Alert.Tipo = EnumAlert.Danger;
                Cliente.Alert.UrlRedirect = "/cliente";
                Cliente.Alert.Titulo = "Erro";               
               
            }

            Cliente.Alert.ShowModal();
            StateHasChanged();
        }       

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/cliente");
        }

    }
}
