using System.Collections.Generic;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas
{
    public class ConversaManager : IConversaManager
    {
        private readonly IWebChatRepositorio  _conversaRepositorio;

        public ConversaManager(IWebChatRepositorio conversaRepositorio)
        {
            _conversaRepositorio = conversaRepositorio;
        }
        public bool AdicionarConversa(WebChat conversa)
        {
           return _conversaRepositorio.AdicionarConversa(conversa);
        }

        public bool AtualizarConversa(WebChat conversaAtualizada)
        {
            return _conversaRepositorio.AdicionarConversa(conversaAtualizada);
        }

        public bool DeletarConversa(int id)
        {
            return _conversaRepositorio.DeletarConversa(id);
        }

        public IEnumerable<WebChat> ProcuraConversa(string filter = null)
        {
            return _conversaRepositorio.BuscarConversas(filter);
        }

        public WebChat RealizaPergunta(string pergunta)
        {
            return _conversaRepositorio.BuscarConversaPorPergunta(pergunta);
        }
    }
}
