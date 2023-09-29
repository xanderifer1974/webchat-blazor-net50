using System.Collections.Generic;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes
{
    public class ListaClientes : IListaClientes
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ListaClientes(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IEnumerable<Cliente> ListarClientes(string filter = null)
        {
            return _clienteRepositorio.ListarClientes(filter);
        }
    }
}
