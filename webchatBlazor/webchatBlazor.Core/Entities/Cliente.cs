using webchatBlazor.Core.Enuns;

namespace webchatBlazor.Core.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public long Cpf { get; set; }
        public string NomeCompleto { get; set; }
        public string Nome { get; set; }
        public EnunStatus Ativo { get; set; }

        public Cliente(int idCliente, long cpf, string nomeCompleto, string nome, EnunStatus ativo)
        {
            IdCliente = idCliente;
            Cpf = cpf;
            NomeCompleto = nomeCompleto;
            Nome = nome;
            Ativo = ativo;
        }

        public Cliente()
        {

        }       

        public string CPFFormatado
        {
            get
            {
                return string.Format("{0:000\\.000\\.000\\-00}", Cpf);
            }
        }        
    }
}
