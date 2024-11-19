using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Profissionais")] 
    public class Profissional:Usuario
    {
        public int IdProfissional { get; set; }

        public void AtualizarPerfil() { }
        public void GerenciarAgenda() { }
        public void VisualizarPagamentos() { }
        public void EmitirRelatorioFinanceiro() { }
        public void AvaliarCliente() { }
    }
}
