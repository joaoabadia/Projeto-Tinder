using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Projeto_Tinder.Models
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int Pessoa1 { get; set; }
        public int Pessoa2 { get; set; }
        public DateTime? DataMatch { get; set; }

        [ForeignKey("Pessoa1")]
        public Pessoa Pessoa1Info { get; set; }

        [ForeignKey("Pessoa2")]
        public Pessoa Pessoa2Info { get; set; }
    }
}
