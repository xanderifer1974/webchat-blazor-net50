using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Pages.ClienteCrud
{
    public partial class NovoCliente
    {
        public Cliente Cliente { get; set; }       

        [Inject]
        NavigationManager NavigationManager { get; set; }
       


        protected override void OnInitialized()
        {
            base.OnInitialized();
            Cliente = new Cliente();
            
        }

        protected void CriarCliente()
        {
            //Colocar a lógica de criação do cliente
            // TODO >> Precisa fazer uma lógica para pegar o último id do, e na hora de adicionar na lista deve ser somado + 1
            // Em relação ao Status, fazer uma combox que aparece Ativo e Inativo, mas que grave na classe true ou false
        }

        protected void Cancela()
        {
            NavigationManager.NavigateTo("/cliente");
        }
    }
}
