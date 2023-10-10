using System.Collections.Generic;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IExibeClientePorCpf _exibeClientePorCpf;
        private readonly IListaClientes _listaClientes;
        private readonly IClienteManager _clienteManager;
        

        public ClienteService(IExibeClientePorCpf exibeClientePorCpf, IListaClientes listaClientes, IClienteManager clienteManager)
        {
            _exibeClientePorCpf = exibeClientePorCpf;
            _listaClientes = listaClientes;
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
            return _exibeClientePorCpf.BuscarClientePorCPF(cpf);
        }

        public bool DeletarCliente(int id)
        {
            return _clienteManager.DeletarCliente(id);
        }

        public IEnumerable<Cliente> ListarClientes(string filter = null)
        {
            return _listaClientes.ListarClientes(filter);
        }
    }
}
