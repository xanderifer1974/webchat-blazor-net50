using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IExibeClientePorCpf _exibeClientePorCpf;
        private readonly IListaClientes _listaClientes;

        public ClienteService(IExibeClientePorCpf exibeClientePorCpf, IListaClientes listaClientes)
        {
            _exibeClientePorCpf = exibeClientePorCpf;
            _listaClientes = listaClientes;
        }
        public Cliente BuscarClientePorCPF(long cpf)
        {
            return _exibeClientePorCpf.BuscarClientePorCPF(cpf);
        }

        public IEnumerable<Cliente> ListarClientes(string filter = null)
        {
            return _listaClientes.ListarClientes(filter);
        }
    }
}
