using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        public int Id { get; set; }

        [Column("TipoSaida")]
        [Display(Name = "Tipo de Saída")]
        public string TipoSaida { get; set; } = string.Empty;
    }
}
