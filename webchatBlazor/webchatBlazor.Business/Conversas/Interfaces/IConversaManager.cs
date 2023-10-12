using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas.Interfaces
{
    public interface IConversaManager
    {
        bool AdicionarConversa(WebChat conversa);
        bool AtualizarConversa(WebChat conversaAtualizada);
        bool DeletarConversa(int id);

        WebChat RealizaPergunta(string pergunta);
        IEnumerable<WebChat> ProcuraConversa(string filter = null);

        List<string> ListarNomesClientes();
    }
}
