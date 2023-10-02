using Microsoft.AspNetCore.Components;

namespace webchatBlazor.Blazor.Shared.WebChat
{
    public partial class ProcuraConversaComponent
    {
        private string filter;

        [Parameter]
        public EventCallback<string> OnSearch { get; set; }

        private void HandleSearch()
        {
            OnSearch.InvokeAsync(filter);
        }
    }
}
