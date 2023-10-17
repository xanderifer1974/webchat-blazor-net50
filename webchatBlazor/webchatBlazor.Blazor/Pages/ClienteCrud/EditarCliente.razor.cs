using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;
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

        protected override void OnInitialized()
        {
            //Cliente = ClienteService
        }


    }
}
