using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace webchatBlazor.Blazor.Shared
{
    public partial class ComboxList
    {
        [Parameter]
        public List<string> Itens { get; set; }

        [Parameter]
        public string  Bind { get; set; }


    }
}
