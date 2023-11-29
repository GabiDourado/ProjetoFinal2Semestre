using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinal2Semestre.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuário")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
