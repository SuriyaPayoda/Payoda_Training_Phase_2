﻿// <auto-generated />
using System;
using JWTAuth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JWTAuth.Migrations
{
    [DbContext(typeof(EmployeeMgmtContext))]
    [Migration("20230816114226_addUserTable")]
    partial class addUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JWTAuth.Models.Dept", b =>
                {
                    b.Property<int>("Deptno")
                        .HasColumnType("int")
                        .HasColumnName("deptno");

                    b.Property<string>("Dname")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("dname");

                    b.HasKey("Deptno")
                        .HasName("pk_dept");

                    b.ToTable("Dept", (string)null);
                });

            modelBuilder.Entity("JWTAuth.Models.Emp", b =>
                {
                    b.Property<int>("Empno")
                        .HasColumnType("int")
                        .HasColumnName("empno");

                    b.Property<string>("Address")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasColumnName("address");

                    b.Property<int?>("Deptno")
                        .HasColumnType("int")
                        .HasColumnName("deptno");

                    b.Property<string>("Ename")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("ename");

                    b.HasKey("Empno")
                        .HasName("pk_emp");

                    b.HasIndex("Deptno");

                    b.ToTable("Emp", (string)null);
                });

            modelBuilder.Entity("JWTAuth.Models.Emp", b =>
                {
                    b.HasOne("JWTAuth.Models.Dept", "DeptnoNavigation")
                        .WithMany("Emps")
                        .HasForeignKey("Deptno")
                        .HasConstraintName("fk_deptno");

                    b.Navigation("DeptnoNavigation");
                });

            modelBuilder.Entity("JWTAuth.Models.Dept", b =>
                {
                    b.Navigation("Emps");
                });
#pragma warning restore 612, 618
        }
    }
}