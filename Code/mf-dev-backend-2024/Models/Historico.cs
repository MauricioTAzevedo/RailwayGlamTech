using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Historico")]
    public class Historico
    {
        [Key]

        public int IdHistorico {  get; set; }
        public int StatusFinal { get; set; }

        public string Comentario { get; set; }

        public int idAgendamentos { get; set; }

        [ForeignKey("idAgendamentos")]
        public virtual Agendamento Agendamento { get; set; }
    }
}
