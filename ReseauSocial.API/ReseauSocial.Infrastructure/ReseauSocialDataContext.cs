using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReseauSocial.Domaine.Models
{
    public partial class ReseauSocialDataContext : DbContext
    {
        public ReseauSocialDataContext()
        {
        }

        public ReseauSocialDataContext(DbContextOptions<ReseauSocialDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbonnementDto> Abonnement { get; set; }
        public virtual DbSet<AbonnéDto> Abonné { get; set; }
        public virtual DbSet<CommentaireDto> Commentaire { get; set; }
        public virtual DbSet<ConversationDto> Conversation { get; set; }
        public virtual DbSet<MessageDto> Message { get; set; }
        public virtual DbSet<PostDto> Post { get; set; }
        public virtual DbSet<UtilisateurDto> Utilisateur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ReseauSocialData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbonnementDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbonnéDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateAbo).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentaireDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contenu).IsUnicode(false);

                entity.Property(e => e.DateCom).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConversationDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateConv).HasColumnType("datetime");
            });

            modelBuilder.Entity<MessageDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contenu).IsUnicode(false);

                entity.Property(e => e.DateEnvoi).HasColumnType("datetime");
            });

            modelBuilder.Entity<PostDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contenu).IsUnicode(false);

                entity.Property(e => e.DatePost).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Thème).IsUnicode(false);
            });

            modelBuilder.Entity<UtilisateurDto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCon).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Nom).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Prenom).IsUnicode(false);

                entity.Property(e => e.UserType).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
