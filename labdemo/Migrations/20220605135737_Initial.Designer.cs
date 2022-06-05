﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using labdemo.Models;

#nullable disable

namespace labdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220605135737_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("labdemo.Models.DiemSV", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Diem")
                        .HasColumnType("float");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HinhThucID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonHocID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayKiemTra")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanXet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SinhVienID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("HinhThucID");

                    b.HasIndex("LopID");

                    b.HasIndex("MonHocID");

                    b.HasIndex("SinhVienID");

                    b.ToTable("Diem_SinhVien");
                });

            modelBuilder.Entity("labdemo.Models.HinhThuc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHinhThuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HinhThuc_Thi_KiemTra");
                });

            modelBuilder.Entity("labdemo.Models.KhoaHoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NienKhoaHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhoaHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KhoaHoc");
                });

            modelBuilder.Entity("labdemo.Models.Lop_MonHoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonHocID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("SoTiet")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("LopID");

                    b.HasIndex("MonHocID");

                    b.ToTable("Lop_MonHoc");
                });

            modelBuilder.Entity("labdemo.Models.Lop_SinhVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SinhVienID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("LopID");

                    b.HasIndex("SinhVienID");

                    b.ToTable("Lop_SinhVien");
                });

            modelBuilder.Entity("labdemo.Models.Lophoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GiangVienID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhoaHocID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GiangVienID");

                    b.HasIndex("KhoaHocID");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("labdemo.Models.MonHoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("labdemo.Models.Permission", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Permission_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("labdemo.Models.Thi_KiemTra", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HinhThucID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MonHocID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayKiemTra")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ThoiLuong")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("HinhThucID");

                    b.HasIndex("LopID");

                    b.HasIndex("MonHocID");

                    b.ToTable("Thi_KiemTra");
                });

            modelBuilder.Entity("labdemo.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PermissionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PermissionID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("labdemo.Models.DiemSV", b =>
                {
                    b.HasOne("labdemo.Models.HinhThuc", "HinhThuc")
                        .WithMany()
                        .HasForeignKey("HinhThucID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.Lophoc", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.User", "SinhVien")
                        .WithMany()
                        .HasForeignKey("SinhVienID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HinhThuc");

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("labdemo.Models.Lop_MonHoc", b =>
                {
                    b.HasOne("labdemo.Models.Lophoc", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("labdemo.Models.Lop_SinhVien", b =>
                {
                    b.HasOne("labdemo.Models.Lophoc", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.User", "SinhVien")
                        .WithMany()
                        .HasForeignKey("SinhVienID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Lop");

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("labdemo.Models.Lophoc", b =>
                {
                    b.HasOne("labdemo.Models.User", "GiangVien")
                        .WithMany()
                        .HasForeignKey("GiangVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.KhoaHoc", "KhoaHoc")
                        .WithMany()
                        .HasForeignKey("KhoaHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("labdemo.Models.Thi_KiemTra", b =>
                {
                    b.HasOne("labdemo.Models.HinhThuc", "HinhThuc")
                        .WithMany()
                        .HasForeignKey("HinhThucID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.Lophoc", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("labdemo.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhThuc");

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("labdemo.Models.User", b =>
                {
                    b.HasOne("labdemo.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");
                });
#pragma warning restore 612, 618
        }
    }
}