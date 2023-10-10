using System;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas
{
    public class ConversaManager : IConversaManager
    {
        private readonly IConversaManager _conversaManager;

        public ConversaManager(IConversaManager conversaManager)
        {
                _conversaManager = conversaManager;
        }
        public bool AdicionarConversa(WebChat conversa)
        {
           return _conversaManager.AdicionarConversa(conversa);
        }

        public bool AtualizarConversa(WebChat conversaAtualizada)
        {
            return _conversaManager.AdicionarConversa(conversaAtualizada);
        }

        public bool DeletarConversa(int id)
        {
            return _conversaManager.DeletarConversa(id);
        }
    }
}
