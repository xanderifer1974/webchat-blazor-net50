using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas
{
    public class ExibeConversa : IExibeConversa
    {
        private readonly IWebChatRepositorio _webChatRepositorio;

        public ExibeConversa(IWebChatRepositorio webChatRepositorio)
        {
            _webChatRepositorio = webChatRepositorio;
        }
        public WebChat RealizaPergunta(string pergunta)
        {
            return _webChatRepositorio.BuscarConversaPorPergunta(pergunta);
        }
    }
}
