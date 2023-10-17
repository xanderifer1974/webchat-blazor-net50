using System.Collections.Generic;
using webchatBlazor.Business.Interface.Managers;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Service
{
    public class ClienteService : IClienteService
    {
        
        private readonly IClienteManager _clienteManager;
        

        public ClienteService( IClienteManager clienteManager)
        {           
            _clienteManager = clienteManager;
        }

        public bool AdicionarCliente(Cliente cliente)
        {
            return _clienteManager.AdicionarCliente(cliente);
        }

        public bool AtualizarCliente(Cliente clienteAtualizado)
        {
            return _clienteManager.AtualizarCliente(clienteAtualizado);
        }

        public Cliente BuscarClientePorCPF(long cpf)
        {
            return _clienteManager.BuscarClientePorCPF(cpf);
        }

        public Cliente BuscarClientePorId(int id)
        {
            return _clienteManager.BuscarClientePorId(id);
        }

        public bool DeletarCliente(int id)
        {
            return _clienteManager.DeletarCliente(id);
        }

        public IEnumerable<Cliente> ListarClientes(string filter = null)
        {
            return _clienteManager.ListarClientes(filter);
        }
    }
}
