using Microsoft.AspNetCore.Components;

namespace webchatBlazor.Blazor.Shared
{
    public partial class ProcuraItemComponent
    {
        private string filter;

        [Parameter]
        public EventCallback<string> OnSearch { get; set; }

        [Parameter]
        public string TituloBotao{ get; set; }

        private void HandleSearch()
        {
            OnSearch.InvokeAsync(filter);
        }
    }
}
