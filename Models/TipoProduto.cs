using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("TipoProdutoNome")]
        [Display(Name = "Tipo do Produto")]
        public string TipoProdutoNome { get; set; } = string.Empty;
    }
}
