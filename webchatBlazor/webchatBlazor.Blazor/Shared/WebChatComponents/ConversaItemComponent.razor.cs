using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Shared.WebChatComponents
{
    public partial class ConversaItemComponent
    {
        [Parameter]
        public WebChat Conversa { get; set; }
    }
}
