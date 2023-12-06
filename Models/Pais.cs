using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name ="Nome do País")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
