using System.Collections.Generic;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas
{
    public class ProcuraConversa : IProcuraConversa
    {
        private readonly IWebChatRepositorio _webChatRepositorio;

        public ProcuraConversa(IWebChatRepositorio webChatRepositorio)
        {
            _webChatRepositorio = webChatRepositorio;    
        }
        IEnumerable<WebChat> IProcuraConversa.ProcuraConversa(string filter)
        {
            return _webChatRepositorio.BuscarConversas(filter);
        }
    }
}
