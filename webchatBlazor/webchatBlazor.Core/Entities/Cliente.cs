using System.ComponentModel.DataAnnotations;
using webchatBlazor.Core.Enuns;

namespace webchatBlazor.Core.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo CPF deve ser preenchido.")]
        [RegularExpression(@"^\d{10}|\d{11}$", ErrorMessage = "CPF inválido")]
        public long Cpf { get; set; }

        [Required(ErrorMessage = "O campo Nome Completo deve ser preenchido.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O campo Nome Completo deve ser preenchido.")]
        public string Nome { get; set; }
        public EnunStatus Ativo { get; set; } = EnunStatus.Ativo;

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
