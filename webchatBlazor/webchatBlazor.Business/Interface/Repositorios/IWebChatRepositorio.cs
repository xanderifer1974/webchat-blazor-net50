using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Interface.Repositorios
{
    public interface IWebChatRepositorio
    {
        IEnumerable<WebChat> BuscarConversas(string filter = null);       
        WebChat BuscarConversaPorPergunta(string pergunta);
        void AdicionarConversa(WebChat conversa);
        void AtualizarConversa(WebChat conversa);
        void DeletarConversa(int id);
    }
}
