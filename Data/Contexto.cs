using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<UsuariosModel> Usuario { get; set; }
        public DbSet<ObjetosModel> Objeto { get; set; }
        public DbSet<ObservacoesModel> Observacoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ObjetoMap());
            modelBuilder.ApplyConfiguration(new ObservacaoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
