using Microsoft.AspNetCore.Components;

namespace webchatBlazor.Blazor.Shared
{
    public partial class ProcuraItemComponent
    {
        private string filter;
        private string link;

        [Parameter]
        public EventCallback<string> OnSearch { get; set; }

        [Parameter] 
        public EventCallback<string> OnInserir { get; set; }

        [Parameter]
        public string TituloBotao1{ get; set; }

        [Parameter]
        public string TituloBotao2 { get; set; }

        private void HandleSearch()
        {
            OnSearch.InvokeAsync(filter);
        }

        private void BotaoLink()
        {
          OnInserir.InvokeAsync(link);
        }
    }
}
