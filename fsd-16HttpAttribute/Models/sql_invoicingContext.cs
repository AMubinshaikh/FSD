using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fsd_16HttpAttribute.Models {
    public partial class sql_invoicingContext : DbContext {
        public sql_invoicingContext () { }

        public sql_invoicingContext (DbContextOptions<sql_invoicingContext> options) : base (options) { }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL ("Server=localhost;Database=sql_invoicing;Uid=root;Pwd=spa0808c#;");
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Clients> (entity => {
                entity.HasKey (e => e.ClientId)
                    .HasName ("PRIMARY");

                entity.ToTable ("clients");

                entity.Property (e => e.ClientId).HasColumnName ("client_id");

                entity.Property (e => e.Address)
                    .IsRequired ()
                    .HasColumnName ("address")
                    .HasMaxLength (50);

                entity.Property (e => e.City)
                    .IsRequired ()
                    .HasColumnName ("city")
                    .HasMaxLength (50);

                entity.Property (e => e.Name)
                    .IsRequired ()
                    .HasColumnName ("name")
                    .HasMaxLength (50);

                entity.Property (e => e.Phone)
                    .HasColumnName ("phone")
                    .HasMaxLength (50);

                entity.Property (e => e.State)
                    .IsRequired ()
                    .HasColumnName ("state")
                    .HasMaxLength (2)
                    .IsFixedLength ();
            });

            modelBuilder.Entity<Invoices> (entity => {
                entity.HasKey (e => e.InvoiceId)
                    .HasName ("PRIMARY");

                entity.ToTable ("invoices");

                entity.HasIndex (e => e.ClientId)
                    .HasName ("FK_client_id");

                entity.Property (e => e.InvoiceId).HasColumnName ("invoice_id");

                entity.Property (e => e.ClientId).HasColumnName ("client_id");

                entity.Property (e => e.DueDate)
                    .HasColumnName ("due_date")
                    .HasColumnType ("date");

                entity.Property (e => e.InvoiceDate)
                    .HasColumnName ("invoice_date")
                    .HasColumnType ("date");

                entity.Property (e => e.InvoiceTotal)
                    .HasColumnName ("invoice_total")
                    .HasColumnType ("decimal(9,2)");

                entity.Property (e => e.Number)
                    .IsRequired ()
                    .HasColumnName ("number")
                    .HasMaxLength (50);

                entity.Property (e => e.PaymentDate)
                    .HasColumnName ("payment_date")
                    .HasColumnType ("date");

                entity.Property (e => e.PaymentTotal)
                    .HasColumnName ("payment_total")
                    .HasColumnType ("decimal(9,2)");

                entity.HasOne (d => d.Client)
                    .WithMany (p => p.Invoices)
                    .HasForeignKey (d => d.ClientId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("FK_client_id");
            });

            modelBuilder.Entity<PaymentMethods> (entity => {
                entity.HasKey (e => e.PaymentMethodId)
                    .HasName ("PRIMARY");

                entity.ToTable ("payment_methods");

                entity.Property (e => e.PaymentMethodId)
                    .HasColumnName ("payment_method_id")
                    .ValueGeneratedOnAdd ();

                entity.Property (e => e.Name)
                    .IsRequired ()
                    .HasColumnName ("name")
                    .HasMaxLength (50);
            });

            modelBuilder.Entity<Payments> (entity => {
                entity.HasKey (e => e.PaymentId)
                    .HasName ("PRIMARY");

                entity.ToTable ("payments");

                entity.HasIndex (e => e.ClientId)
                    .HasName ("fk_client_id_idx");

                entity.HasIndex (e => e.InvoiceId)
                    .HasName ("fk_invoice_id_idx");

                entity.HasIndex (e => e.PaymentMethod)
                    .HasName ("fk_payment_payment_method_idx");

                entity.Property (e => e.PaymentId).HasColumnName ("payment_id");

                entity.Property (e => e.Amount)
                    .HasColumnName ("amount")
                    .HasColumnType ("decimal(9,2)");

                entity.Property (e => e.ClientId).HasColumnName ("client_id");

                entity.Property (e => e.Date)
                    .HasColumnName ("date")
                    .HasColumnType ("date");

                entity.Property (e => e.InvoiceId).HasColumnName ("invoice_id");

                entity.Property (e => e.PaymentMethod).HasColumnName ("payment_method");

                entity.HasOne (d => d.Client)
                    .WithMany (p => p.Payments)
                    .HasForeignKey (d => d.ClientId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_payment_client");

                entity.HasOne (d => d.Invoice)
                    .WithMany (p => p.Payments)
                    .HasForeignKey (d => d.InvoiceId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_payment_invoice");

                entity.HasOne (d => d.PaymentMethodNavigation)
                    .WithMany (p => p.Payments)
                    .HasForeignKey (d => d.PaymentMethod)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_payment_payment_method");
            });

            OnModelCreatingPartial (modelBuilder);
        }

        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}