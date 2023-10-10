using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes.Interfaces
{
    public interface IClienteManager
    {
        bool AdicionarCliente(Cliente cliente);
        bool AtualizarCliente(Cliente clienteAtualizado);
        bool DeletarCliente(int id);

    }
}
