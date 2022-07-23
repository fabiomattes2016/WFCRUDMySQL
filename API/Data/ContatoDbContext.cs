using Microsoft.EntityFrameworkCore;
using WFCRUDMySQL.Model;

namespace API.Data
{
    public class ContatoDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public DbSet<Contato> Contatos { get; set; }

        public ContatoDbContext(IConfiguration config) => _config = config;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.EnableSensitiveDataLogging();
            options.UseMySql(_config.GetConnectionString("MySql"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.38"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().HasKey(c => c.Id);

            modelBuilder.Entity<Contato>()
                .Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("varchar(150)");
            modelBuilder.Entity<Contato>()
                .Property(c => c.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("varchar(150)");
            modelBuilder.Entity<Contato>()
                .Property(c => c.Telefone)
                .IsRequired()
                .HasColumnName("telefone")
                .HasColumnType("varchar(25)");

            modelBuilder.Entity<Contato>().ToTable("contatos");

            base.OnModelCreating(modelBuilder);
        }
    }
}
