using System.ComponentModel.DataAnnotations;

namespace Api_OData1.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        public int Nota { get; set; }
        public int EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
