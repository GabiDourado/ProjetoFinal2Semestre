using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome do Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "Estado")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
