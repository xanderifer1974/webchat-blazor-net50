using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteManager(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;  
        }
        public bool AdicionarCliente(Cliente cliente)
        {
            return _clienteRepositorio.AdicionarCliente(cliente);
        }

        public bool AtualizarCliente(Cliente clienteAtualizado)
        {
            return _clienteRepositorio.AtualizarCliente(clienteAtualizado);
        }

        public bool DeletarCliente(int id)
        {
            return _clienteRepositorio.DeletarCliente(id);
        }
    }
}
