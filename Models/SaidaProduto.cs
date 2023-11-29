using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("SaidaProdutoId")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("QuantidadeDeSaida")]
        [Display(Name = "Quantidade")]
        public int QuantidadeDeEntrada { get; set; }

        [Column("DataSaida")]
        [Display(Name = "Data de Saída")]
        public DateTime DataEntrada { get; set; }
    }
}
