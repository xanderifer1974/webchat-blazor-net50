using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Shared
{
    public partial class AlertComponent
    {
        [Parameter]
        public Alert Model { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
      

        private void CloseModal()
        {
            Model.ModalClasse = string.Empty;
            Model.Display = "none";
            Model.Show = false;
            if (!string.IsNullOrEmpty(Model.UrlRedirect))       
                NavigationManager.NavigateTo(Model.UrlRedirect);
            
        }
     



    }
}
