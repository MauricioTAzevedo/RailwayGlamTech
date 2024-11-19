using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2024.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<ServicosAgendados> ServicosAgendados { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
    }
}
