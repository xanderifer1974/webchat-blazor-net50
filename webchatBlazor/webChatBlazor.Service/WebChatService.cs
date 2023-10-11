using System.Collections.Generic;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;
using webchatBlazor.Util;

namespace webchatBlazor.Service
{
    public class WebChatService : IWebChatService
    {
       
        private readonly IConversaManager _conversaManager;
       

        public WebChatService( IConversaManager conversaManager)
        {                
            _conversaManager = conversaManager;          

        }

        public bool AdicionarConversa(WebChat conversa)
        {
            return _conversaManager.AdicionarConversa(conversa);
        }

        public bool AtualizarConversa(WebChat conversaAtualizada)
        {
            return _conversaManager.AtualizarConversa(conversaAtualizada);
        }

        public WebChat BuscarConversaPorPergunta(string pergunta)
        {
           return _conversaManager.RealizaPergunta(pergunta);
        }

        public IEnumerable<WebChat> BuscarConversas(string filter = null)
        {
           return _conversaManager.ProcuraConversa(filter);
        }

        public bool DeletarConversa(int id)
        {
           return _conversaManager.DeletarConversa(id);
        }
    }
}
