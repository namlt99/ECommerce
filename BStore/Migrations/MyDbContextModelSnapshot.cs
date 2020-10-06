﻿// <auto-generated />
using System;
using BStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BStore.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BStore.Models.BannerQuangCao", b =>
                {
                    b.Property<int>("MaBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentBanner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkBanner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleBanner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBanner");

                    b.ToTable("BannerQuangCao");
                });

            modelBuilder.Entity("BStore.Models.ChiTietGioHang", b =>
                {
                    b.Property<int>("MaCtgioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaGioHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaThucDon")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaCtgioHang");

                    b.HasIndex("MaGioHang");

                    b.HasIndex("MaThucDon");

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("BStore.Models.DanhGia", b =>
                {
                    b.Property<int>("MaDanhGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoiNhanXet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<int?>("MaThucDon")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDanhGia")
                        .HasColumnType("datetime2");

                    b.HasKey("MaDanhGia");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("BStore.Models.DungTich", b =>
                {
                    b.Property<int>("MaDungTich")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DungTichValue")
                        .HasColumnType("int");

                    b.HasKey("MaDungTich");

                    b.ToTable("DungTich");
                });

            modelBuilder.Entity("BStore.Models.GioHang", b =>
                {
                    b.Property<int>("MaGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TongCong")
                        .HasColumnType("float");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaGioHang");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("BStore.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaTaiKhoan")
                        .HasColumnType("int");

                    b.Property<int?>("MaTinhThanh")
                        .HasColumnType("int");

                    b.Property<string>("SoDt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.HasIndex("MaTaiKhoan");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BStore.Models.LoaiThucDon", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiThucDon");
                });

            modelBuilder.Entity("BStore.Models.NongDo", b =>
                {
                    b.Property<int>("MaNongDo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("NongDoValue")
                        .HasColumnType("float");

                    b.HasKey("MaNongDo");

                    b.ToTable("NongDo");
                });

            modelBuilder.Entity("BStore.Models.PhanQuyen", b =>
                {
                    b.Property<string>("MaPhanQuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("QuyenHan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhanQuyen");

                    b.ToTable("PhanQuyen");
                });

            modelBuilder.Entity("BStore.Models.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDaiDien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DangHoatDong")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPhanQuyen")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("MaPhanQuyen");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("BStore.Models.ThucDon", b =>
                {
                    b.Property<int>("MaThucDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KhuyenMai")
                        .HasColumnType("int");

                    b.Property<int?>("LuotMua")
                        .HasColumnType("int");

                    b.Property<int?>("LuotXem")
                        .HasColumnType("int");

                    b.Property<int?>("MaDungTich")
                        .HasColumnType("int");

                    b.Property<int?>("MaLoai")
                        .HasColumnType("int");

                    b.Property<int?>("MaNongDo")
                        .HasColumnType("int");

                    b.Property<int?>("MaTH")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenThucDon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaThucDon");

                    b.HasIndex("MaDungTich");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNongDo");

                    b.HasIndex("MaTH");

                    b.ToTable("ThucDon");
                });

            modelBuilder.Entity("BStore.Models.ThuongHieu", b =>
                {
                    b.Property<int>("MaTH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTH")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTH");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("BStore.Models.TinhThanh", b =>
                {
                    b.Property<int>("MaTinhThanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTinhThanh");

                    b.ToTable("TinhThanh");
                });

            modelBuilder.Entity("BStore.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("BStore.Models.GioHang", "MaGioHangNavigation")
                        .WithMany("ChiTietGioHang")
                        .HasForeignKey("MaGioHang");

                    b.HasOne("BStore.Models.ThucDon", "MaThucDonNavigation")
                        .WithMany("ChiTietGioHang")
                        .HasForeignKey("MaThucDon");
                });

            modelBuilder.Entity("BStore.Models.GioHang", b =>
                {
                    b.HasOne("BStore.Models.KhachHang", "MaKhachHangNavigation")
                        .WithMany("GioHang")
                        .HasForeignKey("MaKhachHang");
                });

            modelBuilder.Entity("BStore.Models.KhachHang", b =>
                {
                    b.HasOne("BStore.Models.TaiKhoan", "MaTaiKhoanNavigation")
                        .WithMany("KhachHang")
                        .HasForeignKey("MaTaiKhoan");
                });

            modelBuilder.Entity("BStore.Models.TaiKhoan", b =>
                {
                    b.HasOne("BStore.Models.PhanQuyen", "MaPhanQuyenNavigation")
                        .WithMany("TaiKhoan")
                        .HasForeignKey("MaPhanQuyen");
                });

            modelBuilder.Entity("BStore.Models.ThucDon", b =>
                {
                    b.HasOne("BStore.Models.DungTich", "DungTichNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaDungTich");

                    b.HasOne("BStore.Models.LoaiThucDon", "MaLoaiNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaLoai");

                    b.HasOne("BStore.Models.NongDo", "NongDoNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaNongDo");

                    b.HasOne("BStore.Models.ThuongHieu", "MaTHNavigation")
                        .WithMany("ThucDon")
                        .HasForeignKey("MaTH");
                });
#pragma warning restore 612, 618
        }
    }
}
