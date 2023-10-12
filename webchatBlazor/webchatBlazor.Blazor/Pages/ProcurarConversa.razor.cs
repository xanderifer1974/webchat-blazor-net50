using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Pages
{
    public partial class ProcurarConversa
    {
        

        [Inject]
        protected IWebChatService WebChatService {get;set;}

        [Inject]
        protected NavigationManager NavigationManager { get;set;}

        private IEnumerable<WebChat> Conversas { get; set;}

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Conversas = WebChatService.BuscarConversas();
        }

        private void HandlerSearch(string filter)
        {
            Conversas = WebChatService.BuscarConversas(filter);
        }      

    }
}
