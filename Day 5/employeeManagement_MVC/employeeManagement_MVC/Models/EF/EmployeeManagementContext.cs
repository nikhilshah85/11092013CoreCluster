using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace employeeManagement_MVC.Models.EF;

public partial class EmployeeManagementContext : DbContext
{
    public EmployeeManagementContext()
    {
    }

    public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeDetailsNikhil> EmployeeDetailsNikhils { get; set; }

    public virtual DbSet<EmployeeDetailsTraining> EmployeeDetailsTrainings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:trainingserverdotnet.database.windows.net,1433;Initial Catalog=EmployeeManagement;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeDetailsNikhil>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__employee__AFB335924F1189A6");

            entity.ToTable("employeeDetails_nikhil");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("empNo");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        modelBuilder.Entity<EmployeeDetailsTraining>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeDetails_training");

            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermanent).HasColumnName("empIsPermanent");
            entity.Property(e => e.EmpName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpNo).HasColumnName("empNo");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
