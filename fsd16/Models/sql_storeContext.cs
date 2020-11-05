using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fsd16.Models {
    public partial class sql_storeContext : DbContext {
        public sql_storeContext () { }

        public sql_storeContext (DbContextOptions<sql_storeContext> options) : base (options) { }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OrderItemNotes> OrderItemNotes { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }

        internal IEnumerable<Customers> join (Func<object, object> p1, Func<object, object> p2, Func<object, object, object> p3) {
            throw new NotImplementedException ();
        }

        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL ("Server=localhost;Database=sql_store;Uid=root;Pwd=spa0808c#;");
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customers> (entity => {
                entity.HasKey (e => e.CustomerId)
                    .HasName ("PRIMARY");

                entity.ToTable ("customers");

                entity.Property (e => e.CustomerId).HasColumnName ("customer_id");

                entity.Property (e => e.Address)
                    .IsRequired ()
                    .HasColumnName ("address")
                    .HasMaxLength (50);

                entity.Property (e => e.BirthDate)
                    .HasColumnName ("birth_date")
                    .HasColumnType ("date");

                entity.Property (e => e.City)
                    .IsRequired ()
                    .HasColumnName ("city")
                    .HasMaxLength (50);

                entity.Property (e => e.FirstName)
                    .IsRequired ()
                    .HasColumnName ("first_name")
                    .HasMaxLength (50);

                entity.Property (e => e.LastName)
                    .IsRequired ()
                    .HasColumnName ("last_name")
                    .HasMaxLength (50);

                entity.Property (e => e.Phone)
                    .HasColumnName ("phone")
                    .HasMaxLength (50);

                entity.Property (e => e.Points).HasColumnName ("points");

                entity.Property (e => e.State)
                    .IsRequired ()
                    .HasColumnName ("state")
                    .HasMaxLength (2)
                    .IsFixedLength ();
            });

            modelBuilder.Entity<OrderItemNotes> (entity => {
                entity.HasKey (e => e.NoteId)
                    .HasName ("PRIMARY");

                entity.ToTable ("order_item_notes");

                entity.Property (e => e.NoteId).HasColumnName ("note_id");

                entity.Property (e => e.Note)
                    .IsRequired ()
                    .HasColumnName ("note")
                    .HasMaxLength (255);

                entity.Property (e => e.OrderId).HasColumnName ("order_Id");

                entity.Property (e => e.ProductId).HasColumnName ("product_id");
            });

            modelBuilder.Entity<OrderItems> (entity => {
                entity.HasKey (e => new { e.OrderId, e.ProductId })
                    .HasName ("PRIMARY");

                entity.ToTable ("order_items");

                entity.HasIndex (e => e.ProductId)
                    .HasName ("fk_order_items_products_idx");

                entity.Property (e => e.OrderId)
                    .HasColumnName ("order_id")
                    .ValueGeneratedOnAdd ();

                entity.Property (e => e.ProductId).HasColumnName ("product_id");

                entity.Property (e => e.Quantity).HasColumnName ("quantity");

                entity.Property (e => e.UnitPrice)
                    .HasColumnName ("unit_price")
                    .HasColumnType ("decimal(4,2)");

                entity.HasOne (d => d.Order)
                    .WithMany (p => p.OrderItems)
                    .HasForeignKey (d => d.OrderId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_order_items_orders");

                entity.HasOne (d => d.Product)
                    .WithMany (p => p.OrderItems)
                    .HasForeignKey (d => d.ProductId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_order_items_products");
            });

            modelBuilder.Entity<OrderStatuses> (entity => {
                entity.HasKey (e => e.OrderStatusId)
                    .HasName ("PRIMARY");

                entity.ToTable ("order_statuses");

                entity.Property (e => e.OrderStatusId).HasColumnName ("order_status_id");

                entity.Property (e => e.Name)
                    .IsRequired ()
                    .HasColumnName ("name")
                    .HasMaxLength (50);
            });

            modelBuilder.Entity<Orders> (entity => {
                entity.HasKey (e => e.OrderId)
                    .HasName ("PRIMARY");

                entity.ToTable ("orders");

                entity.HasIndex (e => e.CustomerId)
                    .HasName ("fk_orders_customers_idx");

                entity.HasIndex (e => e.ShipperId)
                    .HasName ("fk_orders_shippers_idx");

                entity.HasIndex (e => e.Status)
                    .HasName ("fk_orders_order_statuses_idx");

                entity.Property (e => e.OrderId).HasColumnName ("order_id");

                entity.Property (e => e.Comments)
                    .HasColumnName ("comments")
                    .HasMaxLength (2000);

                entity.Property (e => e.CustomerId).HasColumnName ("customer_id");

                entity.Property (e => e.OrderDate)
                    .HasColumnName ("order_date")
                    .HasColumnType ("date");

                entity.Property (e => e.ShippedDate)
                    .HasColumnName ("shipped_date")
                    .HasColumnType ("date");

                entity.Property (e => e.ShipperId).HasColumnName ("shipper_id");

                entity.Property (e => e.Status)
                    .HasColumnName ("status")
                    .HasDefaultValueSql ("'1'");

                entity.HasOne (d => d.Customer)
                    .WithMany (p => p.Orders)
                    .HasForeignKey (d => d.CustomerId)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_orders_customers");

                entity.HasOne (d => d.Shipper)
                    .WithMany (p => p.Orders)
                    .HasForeignKey (d => d.ShipperId)
                    .HasConstraintName ("fk_orders_shippers");

                entity.HasOne (d => d.StatusNavigation)
                    .WithMany (p => p.Orders)
                    .HasForeignKey (d => d.Status)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("fk_orders_order_statuses");
            });

            modelBuilder.Entity<Products> (entity => {
                entity.HasKey (e => e.ProductId)
                    .HasName ("PRIMARY");

                entity.ToTable ("products");

                entity.Property (e => e.ProductId).HasColumnName ("product_id");

                entity.Property (e => e.Name)
                    .IsRequired ()
                    .HasColumnName ("name")
                    .HasMaxLength (50);

                entity.Property (e => e.QuantityInStock).HasColumnName ("quantity_in_stock");

                entity.Property (e => e.UnitPrice)
                    .HasColumnName ("unit_price")
                    .HasColumnType ("decimal(4,2)");
            });

            modelBuilder.Entity<Shippers> (entity => {
                entity.HasKey (e => e.ShipperId)
                    .HasName ("PRIMARY");

                entity.ToTable ("shippers");

                entity.Property (e => e.ShipperId).HasColumnName ("shipper_id");

                entity.Property (e => e.Name)
                    .IsRequired ()
                    .HasColumnName ("name")
                    .HasMaxLength (50);
            });

            OnModelCreatingPartial (modelBuilder);
        }

        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}