using Microsoft.AspNetCore.Components;

namespace webchatBlazor.Blazor.Shared
{
    public partial class BotaoLink
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Link { get; set; }

        [Parameter]
        public string NomeBotao { get; set; }

        public void Navegar()
        {
            NavigationManager.NavigateTo(Link);
        }
    }
}
