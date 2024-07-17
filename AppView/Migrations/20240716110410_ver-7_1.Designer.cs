﻿// <auto-generated />
using System;
using AppView.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppView.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240716110410_ver-7_1")]
    partial class ver7_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppView.Models.DanhMucSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenDM")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("danhMucSanPhams");
                });

            modelBuilder.Entity("AppView.Models.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdKH")
                        .IsUnique()
                        .HasFilter("[IdKH] IS NOT NULL");

                    b.ToTable("gioHangs");
                });

            modelBuilder.Entity("AppView.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GioHangsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SanPhamsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GioHangsId");

                    b.HasIndex("SanPhamsId");

                    b.ToTable("gioHangChiTiets");
                });

            modelBuilder.Entity("AppView.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangsId");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("AppView.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Gia")
                        .HasColumnType("float");

                    b.Property<Guid?>("HoaDonsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SanPhamsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<Guid?>("ThanhToansId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonsId");

                    b.HasIndex("SanPhamsId");

                    b.HasIndex("ThanhToansId");

                    b.ToTable("hoaDonChiTiets");
                });

            modelBuilder.Entity("AppView.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("AppView.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanhMucSanPhamsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdDMSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DanhMucSanPhamsId");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("AppView.Models.ThanhToan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhuongThuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ThanhToan");
                });

            modelBuilder.Entity("AppView.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("khachHangs");
                });

            modelBuilder.Entity("AppView.Models.GioHang", b =>
                {
                    b.HasOne("AppView.Models.User", "User")
                        .WithOne("GioHangs")
                        .HasForeignKey("AppView.Models.GioHang", "IdKH");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppView.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("AppView.Models.GioHang", "GioHangs")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("GioHangsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppView.Models.SanPham", "SanPhams")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("SanPhamsId");

                    b.Navigation("GioHangs");

                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("AppView.Models.HoaDon", b =>
                {
                    b.HasOne("AppView.Models.User", "KhachHangs")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangsId");

                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("AppView.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("AppView.Models.HoaDon", "HoaDons")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("HoaDonsId");

                    b.HasOne("AppView.Models.SanPham", "SanPhams")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("SanPhamsId");

                    b.HasOne("AppView.Models.ThanhToan", "ThanhToans")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("ThanhToansId");

                    b.Navigation("HoaDons");

                    b.Navigation("SanPhams");

                    b.Navigation("ThanhToans");
                });

            modelBuilder.Entity("AppView.Models.SanPham", b =>
                {
                    b.HasOne("AppView.Models.DanhMucSanPham", "DanhMucSanPhams")
                        .WithMany()
                        .HasForeignKey("DanhMucSanPhamsId");

                    b.Navigation("DanhMucSanPhams");
                });

            modelBuilder.Entity("AppView.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("AppView.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppView.Models.SanPham", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppView.Models.ThanhToan", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppView.Models.User", b =>
                {
                    b.Navigation("GioHangs")
                        .IsRequired();

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
