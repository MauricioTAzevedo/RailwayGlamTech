using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    public enum StatusAgendamento
    {
        Pendente = 1,
        Concluído = 2,
        Cancelado = 3
    }

    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int IdAgendamento { get; set; }

        public StatusAgendamento Status { get; set; }

        public void NotificarAgendamento() { }
        public void DispararLembrete() { }


    }
}
