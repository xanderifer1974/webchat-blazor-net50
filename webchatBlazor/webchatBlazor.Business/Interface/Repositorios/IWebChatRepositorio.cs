using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Interface.Repositorios
{
    public interface IWebChatRepositorio
    {
        IEnumerable<WebChat> BuscarConversas(string filter = null);       
        WebChat BuscarConversaPorPergunta(string pergunta);
    }
}
