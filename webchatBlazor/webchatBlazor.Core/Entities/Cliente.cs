using System.ComponentModel.DataAnnotations;
using webchatBlazor.Core.Enuns;

namespace webchatBlazor.Core.Entities
{
    public class Cliente: EntityBase
    {
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo CPF deve ser preenchido.")]
        [RegularExpression(@"^(0*[1-9][0-9]{10})$", ErrorMessage = "CPF inválido")]
        public long Cpf { get; set; }

        [Required(ErrorMessage = "O Nome completo deve ser preenchido.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O Nome deve ser preenchido.")]
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
