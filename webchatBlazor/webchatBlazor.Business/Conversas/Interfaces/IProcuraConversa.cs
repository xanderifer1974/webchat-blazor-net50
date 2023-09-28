using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas.Interfaces
{
    public interface IProcuraConversa
    {
        IEnumerable<WebChat> ProcuraConversa(string filter = null);
    }
}
