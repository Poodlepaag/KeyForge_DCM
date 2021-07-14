using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KeyForgeDCM_API.Models
{
    public partial class KeyForgeDCMContext : DbContext
    {
        public KeyForgeDCMContext()
        {
        }

        public KeyForgeDCMContext(DbContextOptions<KeyForgeDCMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Deck> Decks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=KeyForgeDCM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.DeckId, "IX_Cards");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardName).HasMaxLength(50);

                entity.Property(e => e.CardText).HasMaxLength(50);

                entity.Property(e => e.CardType).HasMaxLength(50);

                entity.Property(e => e.DeckId).HasColumnName("DeckID");

                entity.HasOne(d => d.Deck)
                    .WithMany()
                    .HasForeignKey(d => d.DeckId)
                    .HasConstraintName("FK_Cards_Decks");
            });

            modelBuilder.Entity<Deck>(entity =>
            {
                entity.Property(e => e.DeckId).HasColumnName("DeckID");

                entity.Property(e => e.DeckName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
