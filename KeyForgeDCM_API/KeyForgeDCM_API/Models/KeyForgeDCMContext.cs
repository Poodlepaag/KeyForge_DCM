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
                entity.Property(e => e.DeckId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeckID");

                entity.Property(e => e.DeckName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
