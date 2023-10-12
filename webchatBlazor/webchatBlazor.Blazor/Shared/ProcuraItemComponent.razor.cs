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
        public string TituloBotao1{ get; set; }

        [Parameter]
        public string NomeBotaoLink { get; set; }

        [Parameter]
        public string NomeLink { get; set; }

        private void HandleSearch()
        {
            OnSearch.InvokeAsync(filter);
        }       
    }
}
