using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Projeto_Tinder.Models
{
    [Table("Denuncia")]
    public class Denuncia
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Denunciante")]
        public int DenuncianteId { get; set; }
        public Pessoa Denunciante { get; set; }

        [ForeignKey("Denunciado")]
        public int DenunciadoId { get; set; }
        public Pessoa Denunciado { get; set; }

        public int Motivo { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }

        [ForeignKey("IdConteudo")]
        public int IdConteudo { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
