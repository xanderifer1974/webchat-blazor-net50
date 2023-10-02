using Microsoft.AspNetCore.Components;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Blazor.Shared.ClienteComponents
{
    public partial class ClienteItemComponent
    {
        [Parameter]
        public Cliente Cliente { get; set; }
    }
}
