using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Service.Interface
{
    public interface IClienteService
    {
        IEnumerable<Cliente> ListarClientes(string filter = null);
        Cliente BuscarClientePorCPF(long cpf);       
        bool AdicionarCliente(Cliente cliente);
        bool AtualizarCliente(Cliente clienteAtualizado);
        bool DeletarCliente(int id);
    }
}
