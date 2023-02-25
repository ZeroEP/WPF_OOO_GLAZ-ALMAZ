using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WPF_OOO_GLAZ_ALMAZ.Entitys
{
    public partial class EfModel : DbContext
    { 
        private static EfModel instance { get; set; }
        public static EfModel Init()
        {
            if(instance == null)
                instance = new EfModel();
            return instance;
        }
        public EfModel()
        {

        }

        public EfModel(DbContextOptions<EfModel> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categorys { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Seller> Sellers { get; set; } = null!;
        public virtual DbSet<Supply> Supplies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("database=ISPr22-32_ShalimoKA_;password=ISPr22-32_ShalimoKA;port=3306;server=cfif31.ru;user id=ISPr22-32_ShalimoKA", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.Category1)
                    .HasMaxLength(45)
                    .HasColumnName("Category");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.CliewntId)
                    .HasName("PRIMARY");

                entity.Property(e => e.CliewntId).HasColumnName("Cliewnt_Id");

                entity.Property(e => e.Fio)
                    .HasMaxLength(45)
                    .HasColumnName("FIO");

                entity.Property(e => e.Login).HasMaxLength(45);

                entity.Property(e => e.PhoneNomber)
                    .HasMaxLength(45)
                    .HasColumnName("Phone_nomber");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.SellersId)
                    .HasName("PRIMARY");

                entity.Property(e => e.SellersId).HasColumnName("Sellers_Id");

                entity.Property(e => e.SellersAdress).HasColumnName("Sellers_Adress");

                entity.Property(e => e.SellersName)
                    .HasMaxLength(45)
                    .HasColumnName("Sellers_Name");

                entity.Property(e => e.SellersPhone)
                    .HasMaxLength(45)
                    .HasColumnName("Sellers_Phone");
            });

            modelBuilder.Entity<Supply>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "CategoryPk_idx");

                entity.HasIndex(e => e.SellersId, "Sellers_Pk_idx");

                entity.Property(e => e.SupplyId).HasColumnName("Supply_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.SellersId).HasColumnName("Sellers_id");

                entity.Property(e => e.Suppliescol).HasColumnType("blob");

                entity.Property(e => e.SupplyCost)
                    .HasMaxLength(45)
                    .HasColumnName("Supply_Cost");

                entity.Property(e => e.SupplyDescription).HasColumnName("Supply_Description");

                entity.Property(e => e.SupplyName)
                    .HasMaxLength(45)
                    .HasColumnName("Supply_Name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Supplies)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("CategoryPk");

                entity.HasOne(d => d.Sellers)
                    .WithMany(p => p.Supplies)
                    .HasForeignKey(d => d.SellersId)
                    .HasConstraintName("Sellers_Pk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(45)
                    .HasColumnName("User_login");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(45)
                    .HasColumnName("User_Password");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(45)
                    .HasColumnName("User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
