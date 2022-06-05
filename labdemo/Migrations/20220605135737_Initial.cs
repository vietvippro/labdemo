using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labdemo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HinhThuc_Thi_KiemTra",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHinhThuc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThuc_Thi_KiemTra", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NienKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permission_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiangVienID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoaHocID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_KhoaHoc_KhoaHocID",
                        column: x => x.KhoaHocID,
                        principalTable: "KhoaHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_User_GiangVienID",
                        column: x => x.GiangVienID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem_SinhVien",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayKiemTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LopID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonHocID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HinhThucID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diem = table.Column<double>(type: "float", nullable: false),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem_SinhVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Diem_SinhVien_HinhThuc_Thi_KiemTra_HinhThucID",
                        column: x => x.HinhThucID,
                        principalTable: "HinhThuc_Thi_KiemTra",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_SinhVien_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_SinhVien_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_SinhVien_User_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Lop_MonHoc",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonHocID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTiet = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_MonHoc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_MonHoc_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_MonHoc_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop_SinhVien",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinhVienID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_SinhVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_SinhVien_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_SinhVien_User_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Thi_KiemTra",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayKiemTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonHocID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhThucID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiLuong = table.Column<long>(type: "bigint", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thi_KiemTra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Thi_KiemTra_HinhThuc_Thi_KiemTra_HinhThucID",
                        column: x => x.HinhThucID,
                        principalTable: "HinhThuc_Thi_KiemTra",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thi_KiemTra_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thi_KiemTra_MonHoc_MonHocID",
                        column: x => x.MonHocID,
                        principalTable: "MonHoc",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVien_HinhThucID",
                table: "Diem_SinhVien",
                column: "HinhThucID");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVien_LopID",
                table: "Diem_SinhVien",
                column: "LopID");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVien_MonHocID",
                table: "Diem_SinhVien",
                column: "MonHocID");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_SinhVien_SinhVienID",
                table: "Diem_SinhVien",
                column: "SinhVienID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_GiangVienID",
                table: "Lop",
                column: "GiangVienID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_KhoaHocID",
                table: "Lop",
                column: "KhoaHocID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHoc_LopID",
                table: "Lop_MonHoc",
                column: "LopID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHoc_MonHocID",
                table: "Lop_MonHoc",
                column: "MonHocID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_SinhVien_LopID",
                table: "Lop_SinhVien",
                column: "LopID");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_SinhVien_SinhVienID",
                table: "Lop_SinhVien",
                column: "SinhVienID");

            migrationBuilder.CreateIndex(
                name: "IX_Thi_KiemTra_HinhThucID",
                table: "Thi_KiemTra",
                column: "HinhThucID");

            migrationBuilder.CreateIndex(
                name: "IX_Thi_KiemTra_LopID",
                table: "Thi_KiemTra",
                column: "LopID");

            migrationBuilder.CreateIndex(
                name: "IX_Thi_KiemTra_MonHocID",
                table: "Thi_KiemTra",
                column: "MonHocID");

            migrationBuilder.CreateIndex(
                name: "IX_User_PermissionID",
                table: "User",
                column: "PermissionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diem_SinhVien");

            migrationBuilder.DropTable(
                name: "Lop_MonHoc");

            migrationBuilder.DropTable(
                name: "Lop_SinhVien");

            migrationBuilder.DropTable(
                name: "Thi_KiemTra");

            migrationBuilder.DropTable(
                name: "HinhThuc_Thi_KiemTra");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Permission");
        }
    }
}
