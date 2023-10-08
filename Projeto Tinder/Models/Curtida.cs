using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Tinder.Models
{
    [Table("Curtidas")]
    public class Curtida
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdRemetente")]
        public int IdRemetente { get; set; }
        public Pessoa Remetente { get; set; }

        [ForeignKey("IdDestinatario")]
        public int IdDestinatario { get; set; }
        public Pessoa Destinatario { get; set; }

        public bool DeuMatch { get; set; }
    }
}
