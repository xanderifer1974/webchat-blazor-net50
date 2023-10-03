using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Shared.WebChatComponents
{
    public partial class MensagemRespostaComponent
    {
        [Parameter]
        public WebChat conversa { get; set; }
    }
}
