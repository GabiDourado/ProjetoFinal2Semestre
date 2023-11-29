using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("QuantidadeDeEntrada")]
        [Display(Name = "Quantidade")]
        public int QuantidadeDeEntrada { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }
    }
}
