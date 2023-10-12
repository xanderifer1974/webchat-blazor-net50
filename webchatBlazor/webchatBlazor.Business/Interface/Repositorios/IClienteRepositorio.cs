using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Interface.Repositorios
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> ListarClientes(string filter = null);
        Cliente BuscarClientePorCPF(long cpf);
        List<string> ListarNomesClientes();
        bool AdicionarCliente(Cliente cliente);
        bool AtualizarCliente(Cliente cliente);
        bool DeletarCliente(int id);
    }
}
