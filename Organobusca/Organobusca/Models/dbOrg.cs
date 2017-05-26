namespace Organobusca.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbOrg : DbContext
    {
        public dbOrg()
            : base("name=dbOrg")
        {
        }

        public virtual DbSet<avaliacao> avaliacao { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<diadasemana> diadasemana { get; set; }
        public virtual DbSet<estoque> estoque { get; set; }
        public virtual DbSet<Feira> Feira { get; set; }
        public virtual DbSet<feirante> feirante { get; set; }
        public virtual DbSet<preferencia> preferencia { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<avaliacao>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.url_foto)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.avaliacao)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.Cliente_id);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.preferencia)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.Cliente_id);

            modelBuilder.Entity<Feira>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .Property(e => e.rua)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<Feira>()
                .HasMany(e => e.diadasemana)
                .WithRequired(e => e.Feira)
                .HasForeignKey(e => e.Feira_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feira>()
                .HasMany(e => e.feirante)
                .WithOptional(e => e.Feira)
                .HasForeignKey(e => e.Feira_id);

            modelBuilder.Entity<feirante>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<feirante>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<feirante>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<feirante>()
                .Property(e => e.site)
                .IsUnicode(false);

            modelBuilder.Entity<feirante>()
                .Property(e => e.url_foto)
                .IsUnicode(false);

            modelBuilder.Entity<feirante>()
                .HasMany(e => e.avaliacao)
                .WithOptional(e => e.feirante)
                .HasForeignKey(e => e.Feirante_id);

            modelBuilder.Entity<feirante>()
                .HasMany(e => e.estoque)
                .WithOptional(e => e.feirante)
                .HasForeignKey(e => e.Feirante_id);

            modelBuilder.Entity<produto>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.estoque)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.Produto_id);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.preferencia)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.Produto_id);
        }
    }
}
