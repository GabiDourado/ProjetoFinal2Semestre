using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento do CLiente")]
        public DateTime DataNascimento { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "CPF do Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone do Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço do Cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Número da casa do Cliente")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("ClienteBairro")]
        [Display(Name = "Bairro do Cliente")]
        public string ClienteBairro { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
