using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do Produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade no Estoque")]
        public int ProdutoEstoque { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo do Produto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor do Produto")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
