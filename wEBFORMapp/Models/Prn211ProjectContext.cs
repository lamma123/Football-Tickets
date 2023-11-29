using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace wEBFORMapp.Models;

public partial class Prn211ProjectContext : DbContext
{
    public Prn211ProjectContext()
    {
    }

    public Prn211ProjectContext(DbContextOptions<Prn211ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ConfirmCode> ConfirmCodes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =MSI; database = PRN211_Project;uid=sa;pwd=123456; Integrated security = True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(150);
        });

        modelBuilder.Entity<ConfirmCode>(entity =>
        {
            entity.ToTable("ConfirmCode");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");

            entity.HasOne(d => d.Ticket).WithMany(p => p.ConfirmCodes)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_ConfirmCode_Tickets");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.ConfirmCodes)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("FK_ConfirmCode_Accounts");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("orderID");
            entity.Property(e => e.Code)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Orderdate)
                .HasColumnType("date")
                .HasColumnName("orderdate");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Username)
                .HasConstraintName("FK_Orders_Accounts");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("orderID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Order).WithOne(p => p.OrderDetail)
                .HasForeignKey<OrderDetail>(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Orders");

            entity.HasOne(d => d.Ticket).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_OrderDetails_Tickets");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.TenTranDau).HasMaxLength(150);
            entity.Property(e => e.Time).HasColumnType("date");

            entity.HasOne(d => d.Category).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Tickets_Category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
