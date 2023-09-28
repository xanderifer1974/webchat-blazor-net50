using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Conversas.Interfaces
{
    public interface IExibeConversa
    {
        WebChat RealizaPergunta(string pergunta);
    }
}
