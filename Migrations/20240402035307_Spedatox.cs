using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Odev_BP.Migrations
{
    /// <inheritdoc />
    public partial class Spedatox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calisan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yetki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "OtelOda",
                columns: table => new
                {
                    OdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdaTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdaFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdaDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtelOda", x => x.OdaID);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyon",
                columns: table => new
                {
                    RezervasyonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    OdaID = table.Column<int>(type: "int", nullable: false),
                    RezervasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckinTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyon", x => x.RezervasyonID);
                    table.ForeignKey(
                        name: "FK_Rezervasyon_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyon_OtelOda_OdaID",
                        column: x => x.OdaID,
                        principalTable: "OtelOda",
                        principalColumn: "OdaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odeme",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervasyonID = table.Column<int>(type: "int", nullable: false),
                    OdemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OdemeMiktari = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odeme", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Odeme_Rezervasyon_RezervasyonID",
                        column: x => x.RezervasyonID,
                        principalTable: "Rezervasyon",
                        principalColumn: "RezervasyonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odeme_RezervasyonID",
                table: "Odeme",
                column: "RezervasyonID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyon_MusteriID",
                table: "Rezervasyon",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyon_OdaID",
                table: "Rezervasyon",
                column: "OdaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisan");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Odeme");

            migrationBuilder.DropTable(
                name: "Rezervasyon");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "OtelOda");
        }
    }
}
