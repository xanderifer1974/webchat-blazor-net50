using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes
{
    public interface IListaClientes
    {
        IEnumerable<Cliente> ListarClientes(string filter = null);
    }
}
