using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatório!")]
        [EmailAddress(ErrorMessage = "Invalid email addres")]

        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatório!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve conter de 6 a 20 caracteres")]
        public string Senha { get; set; }
    }
}
