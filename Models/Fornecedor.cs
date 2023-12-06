using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do Fornecedos")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "Email do Fornecedos")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnpj")]
        [Display(Name = "Cnpj do Fornecedos")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
