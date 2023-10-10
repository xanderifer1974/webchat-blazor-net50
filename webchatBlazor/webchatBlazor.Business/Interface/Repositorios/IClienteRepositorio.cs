﻿using System.Collections.Generic;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Business.Interface.Repositorios
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> ListarClientes(string filter = null);
        Cliente BuscarClientePorCPF(long cpf);
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void DeletarCliente(int id);
    }
}
