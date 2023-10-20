using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Nome do jogo obrigatorio")]
        [Column(TypeName = "VARCHAR(100)")]

        public string? Nome { get; set; }


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao do jogo")]

        public string? Descricao { get; set; }


        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de lancamento obrigatoria")]
        public DateTime DataLancamento { get; set; }


        [Column(TypeName = "DECIMAL(4,2)")]
        public decimal? Preco { get; set; }

        public Guid IdEstudio { get; set; }


        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }
    }
}
