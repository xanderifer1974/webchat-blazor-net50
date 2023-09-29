using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Clientes
{
    public interface IExibeClientePorCpf
    {
        Cliente BuscarClientePorCPF(long cpf);
    }
}
