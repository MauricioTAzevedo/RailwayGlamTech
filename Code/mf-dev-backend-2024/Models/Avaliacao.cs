using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mf_dev_backend_2024.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int IdAvaliacao { get; set; }

        public string Comentario { get; set; }
        [Required(ErrorMessage = "O comentario é obrigatório.")]
       

        public int Nota { get; set; }
        [Required(ErrorMessage = "A nota é obrigatório.")]

        public int idAgendamentos { get; set; }

        [ForeignKey("idAgendamentos")]
        public virtual Agendamento Agendamento { get; set; }
    }
}
