using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Interface.Managers
{
    public interface IClienteManager
    {
        bool AdicionarCliente(Cliente cliente);
        bool AtualizarCliente(Cliente clienteAtualizado);
        bool DeletarCliente(int id);
        Cliente BuscarClientePorCPF(string cpf);
        Cliente BuscarClientePorId(int id);
        IEnumerable<Cliente> ListarClientes(string filter = null);

    }
}
