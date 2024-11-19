using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Clientes")] 
    public class Cliente:Usuario
    {
        public int idCliente { get; set; }
        public void RealizarAgendamento() { }
        public void CancelarAgendamento() { }
        public void ReagendarAgendamento() { }
        public void AvaliarProfissional() { }
    }
}
