using System.Collections.Generic;
using System.Linq;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;
using webchatBlazor.Core.Enuns;

namespace webchatBlazor.Data.Repository
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly List<Cliente> Clientes;

        public ClienteRepositorio()
        {
            Clientes = new List<Cliente>();

            Cliente Cliente1 = new(1, 21201141028, "Antonio Figueiredo de Oliveira", "Antonio", EnunStatus.Ativo);
            Cliente Cliente2 = new(2, 28698103006, "Graziela Lopes Nunes", "Graziela", EnunStatus.Ativo);
            Cliente Cliente3 = new(3, 31554257093, "Paulo Roberto Silva Santos", "Paulo Roberto", EnunStatus.Ativo);
            Cliente Cliente4 = new(4, 72407118030, "João Paulo Martins", "João Paulo", EnunStatus.Ativo);
            Cliente Cliente5 = new(5, 28432913057, "Amanda Bitencourt de Azevedo", "Amanda", EnunStatus.Ativo);
            Cliente Cliente6 = new(6, 44831758078, "Simone Cury Machado", "Simone", EnunStatus.Ativo);
            Cliente Cliente7 = new(7, 99588085012, "Gabriel Marcos Limeira", "Gabriel Marcos", EnunStatus.Ativo);
            Cliente Cliente8 = new(8, 07982351018, "Rafael Pedreira de Souza", "Rafael", EnunStatus.Ativo);
            Cliente Cliente9 = new(9, 03647631086, "Lucia das Neves Ferreira", "Lucia", EnunStatus.Ativo);
            Cliente Cliente10 = new(10, 33391558016, "Ezequiel Medeiros Mendonza", "Ezequiel", EnunStatus.Ativo);

            Clientes.Add(Cliente1);
            Clientes.Add(Cliente2);
            Clientes.Add(Cliente3);
            Clientes.Add(Cliente4);
            Clientes.Add(Cliente5);
            Clientes.Add(Cliente6);
            Clientes.Add(Cliente7);
            Clientes.Add(Cliente8);
            Clientes.Add(Cliente9);
            Clientes.Add(Cliente10);

        }

        public bool AdicionarCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                cliente.IdCliente = Util.Util.ObtemProximoId(Clientes, x => x.IdCliente);

                Clientes.Add(cliente);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarCliente(Cliente clienteAtualizado)
        {
            if (clienteAtualizado == null)
            {
                return false;
            }

            Cliente clienteExistente = Clientes.FirstOrDefault(c => c.IdCliente == clienteAtualizado.IdCliente);

            if (clienteExistente != null)
            {
                clienteExistente.Nome = clienteAtualizado.Nome;
                clienteExistente.Cpf = clienteAtualizado.Cpf;
                clienteExistente.Ativo = clienteAtualizado.Ativo;

                return true;
            }
            else
            {
                return false;
            }
        }

        public Cliente BuscarClientePorCPF(long cpf)
        {
            return Clientes.FirstOrDefault(c => c.Cpf == cpf);
        }

        public Cliente BuscarClientePorId(int id)
        {
            return Clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public bool DeletarCliente(int id)
        {
            Cliente clienteParaDeletar = Clientes.Find(c => c.IdCliente == id);

            if (clienteParaDeletar != null)
            {

                Clientes.Remove(clienteParaDeletar);
                return true;
            }
            else
            {

                return false;
            }
        }

        public IEnumerable<Cliente> ListarClientes(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return Clientes;

            return Clientes.Where(x => x.NomeCompleto.ToLower().Contains(filter.ToLower()));
        }

        public List<string> ListarNomesClientes()
        {
            List<string> nomes  = new List<string>();
            nomes = Clientes.Select(c => c.Nome).ToList();
            return nomes;
        }
    }
}
