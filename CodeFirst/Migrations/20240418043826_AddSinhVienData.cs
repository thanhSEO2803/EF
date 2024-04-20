using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddSinhVienData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    MaKhoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSinhVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    LopMaLop = table.Column<int>(type: "int", nullable: false),
                    KhoaMaKhoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSinhVien);
                    table.ForeignKey(
                        name: "FK_SinhViens_Khoas_KhoaMaKhoa",
                        column: x => x.KhoaMaKhoa,
                        principalTable: "Khoas",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhViens_Lops_LopMaLop",
                        column: x => x.LopMaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "MaKhoa", "TenKhoa" },
                values: new object[,]
                {
                    { 1, "CNTT" },
                    { 2, "DT" },
                    { 3, "CK" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "MaLop", "TenLop" },
                values: new object[,]
                {
                    { 1, "21T3" },
                    { 2, "22T3" },
                    { 3, "22DT3" },
                    { 4, "23CK1" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "MaSinhVien", "Age", "HoTen", "KhoaMaKhoa", "LopMaLop" },
                values: new object[,]
                {
                    { 1, 20, "Nguyen Van A", 1, 1 },
                    { 2, 19, "Nguyen Van E", 1, 2 },
                    { 3, 22, "Nguyen Van C", 1, 1 },
                    { 4, 21, "Tran Van B", 2, 2 },
                    { 5, 21, "Tran Van D", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_KhoaMaKhoa",
                table: "SinhViens",
                column: "KhoaMaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_LopMaLop",
                table: "SinhViens",
                column: "LopMaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "Khoas");

            migrationBuilder.DropTable(
                name: "Lops");
        }
    }
}
