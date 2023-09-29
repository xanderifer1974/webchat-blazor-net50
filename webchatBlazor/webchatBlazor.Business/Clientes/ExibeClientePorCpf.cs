using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes
{
    public class ExibeClientePorCpf : IExibeClientePorCpf
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ExibeClientePorCpf(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public Cliente BuscarClientePorCPF(long cpf)
        {
            return _clienteRepositorio.BuscarClientePorCPF(cpf);
        }
    }
}
