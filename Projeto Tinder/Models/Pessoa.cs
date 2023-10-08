using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Tinder.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório!")]
        public int Genero { get; set; }

        [Required(ErrorMessage = "A orientação sexual é obrigatória!")]
        public int OrientacaoSexual { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória!")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Informe um número de telefone válido")]
        public string Telefone { get; set; }
    }
}
