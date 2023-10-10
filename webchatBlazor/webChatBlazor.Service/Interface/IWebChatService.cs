using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Service.Interface
{
    public interface IWebChatService
    {
        IEnumerable<WebChat> BuscarConversas(string filter = null);
        WebChat BuscarConversaPorPergunta(string pergunta);

        bool AdicionarConversa(WebChat conversa);
        bool AtualizarConversa(WebChat conversaAtualizada);
        bool DeletarConversa(int id);
    }
}
