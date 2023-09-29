using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes.Interfaces
{
    public interface IExibeClientePorCpf
    {
        Cliente BuscarClientePorCPF(long cpf);
    }
}
