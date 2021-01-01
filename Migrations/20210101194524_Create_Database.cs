using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProje.Migrations
{
    public partial class Create_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsiTakvimi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asi_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asi_tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    asi_durumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsiTakvimi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BarinakBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barinak_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barinak_hakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefon_numarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarinakBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BeslenmeProgrami",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    beslenme_programi_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sabah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ogle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aksam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gece = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeslenmeProgrami", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cinsiyet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinsiyet", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HayvanTurleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hayvan_turu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayvanTurleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRolu",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRolu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SaglikDurumu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikDurumu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SahiplenebilirlikDurumu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahiplenebilirlikDurumu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SahiplenmeBasvuruDurumlari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    durum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahiplenmeBasvuruDurumlari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CalismaSaatleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    durum = table.Column<bool>(type: "bit", nullable: false),
                    acilis_saati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kapanis_saati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barinakid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSaatleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_CalismaSaatleri_BarinakBilgileri_barinakid",
                        column: x => x.barinakid,
                        principalTable: "BarinakBilgileri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HayvanCinsleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hayvan_cinsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cinsin_genel_ozellikleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hayvan_turuid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayvanCinsleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_HayvanCinsleri_HayvanTurleri_hayvan_turuid",
                        column: x => x.hayvan_turuid,
                        principalTable: "HayvanTurleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kullanici_roluid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_KullaniciRolu_kullanici_roluid",
                        column: x => x.kullanici_roluid,
                        principalTable: "KullaniciRolu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KayitliHayvanlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yas = table.Column<int>(type: "int", nullable: false),
                    hakkinda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cinsiid = table.Column<int>(type: "int", nullable: true),
                    cinsiyetiid = table.Column<int>(type: "int", nullable: true),
                    saglik_durumuid = table.Column<int>(type: "int", nullable: true),
                    sahiplenebilirlik_durumuid = table.Column<int>(type: "int", nullable: true),
                    beslenme_programiid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitliHayvanlar", x => x.id);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_AsiTakvimi_id",
                        column: x => x.id,
                        principalTable: "AsiTakvimi",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_BeslenmeProgrami_beslenme_programiid",
                        column: x => x.beslenme_programiid,
                        principalTable: "BeslenmeProgrami",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_Cinsiyet_cinsiyetiid",
                        column: x => x.cinsiyetiid,
                        principalTable: "Cinsiyet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_HayvanCinsleri_cinsiid",
                        column: x => x.cinsiid,
                        principalTable: "HayvanCinsleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_SaglikDurumu_saglik_durumuid",
                        column: x => x.saglik_durumuid,
                        principalTable: "SaglikDurumu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KayitliHayvanlar_SahiplenebilirlikDurumu_sahiplenebilirlik_durumuid",
                        column: x => x.sahiplenebilirlik_durumuid,
                        principalTable: "SahiplenebilirlikDurumu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HayvanFotograflari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fotograf_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hayvanid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayvanFotograflari", x => x.id);
                    table.ForeignKey(
                        name: "FK_HayvanFotograflari_KayitliHayvanlar_hayvanid",
                        column: x => x.hayvanid,
                        principalTable: "KayitliHayvanlar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SahiplenmeTalepleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    basvuran_kullaniciid = table.Column<int>(type: "int", nullable: true),
                    basvurulan_hayvanid = table.Column<int>(type: "int", nullable: true),
                    basvuru_durumuid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SahiplenmeTalepleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_SahiplenmeTalepleri_KayitliHayvanlar_basvurulan_hayvanid",
                        column: x => x.basvurulan_hayvanid,
                        principalTable: "KayitliHayvanlar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SahiplenmeTalepleri_Kullanicilar_basvuran_kullaniciid",
                        column: x => x.basvuran_kullaniciid,
                        principalTable: "Kullanicilar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SahiplenmeTalepleri_SahiplenmeBasvuruDurumlari_basvuru_durumuid",
                        column: x => x.basvuru_durumuid,
                        principalTable: "SahiplenmeBasvuruDurumlari",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSaatleri_barinakid",
                table: "CalismaSaatleri",
                column: "barinakid");

            migrationBuilder.CreateIndex(
                name: "IX_HayvanCinsleri_hayvan_turuid",
                table: "HayvanCinsleri",
                column: "hayvan_turuid");

            migrationBuilder.CreateIndex(
                name: "IX_HayvanFotograflari_hayvanid",
                table: "HayvanFotograflari",
                column: "hayvanid");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliHayvanlar_beslenme_programiid",
                table: "KayitliHayvanlar",
                column: "beslenme_programiid");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliHayvanlar_cinsiid",
                table: "KayitliHayvanlar",
                column: "cinsiid");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliHayvanlar_cinsiyetiid",
                table: "KayitliHayvanlar",
                column: "cinsiyetiid");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliHayvanlar_saglik_durumuid",
                table: "KayitliHayvanlar",
                column: "saglik_durumuid");

            migrationBuilder.CreateIndex(
                name: "IX_KayitliHayvanlar_sahiplenebilirlik_durumuid",
                table: "KayitliHayvanlar",
                column: "sahiplenebilirlik_durumuid");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_kullanici_roluid",
                table: "Kullanicilar",
                column: "kullanici_roluid");

            migrationBuilder.CreateIndex(
                name: "IX_SahiplenmeTalepleri_basvuran_kullaniciid",
                table: "SahiplenmeTalepleri",
                column: "basvuran_kullaniciid");

            migrationBuilder.CreateIndex(
                name: "IX_SahiplenmeTalepleri_basvuru_durumuid",
                table: "SahiplenmeTalepleri",
                column: "basvuru_durumuid");

            migrationBuilder.CreateIndex(
                name: "IX_SahiplenmeTalepleri_basvurulan_hayvanid",
                table: "SahiplenmeTalepleri",
                column: "basvurulan_hayvanid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalismaSaatleri");

            migrationBuilder.DropTable(
                name: "HayvanFotograflari");

            migrationBuilder.DropTable(
                name: "SahiplenmeTalepleri");

            migrationBuilder.DropTable(
                name: "BarinakBilgileri");

            migrationBuilder.DropTable(
                name: "KayitliHayvanlar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "SahiplenmeBasvuruDurumlari");

            migrationBuilder.DropTable(
                name: "AsiTakvimi");

            migrationBuilder.DropTable(
                name: "BeslenmeProgrami");

            migrationBuilder.DropTable(
                name: "Cinsiyet");

            migrationBuilder.DropTable(
                name: "HayvanCinsleri");

            migrationBuilder.DropTable(
                name: "SaglikDurumu");

            migrationBuilder.DropTable(
                name: "SahiplenebilirlikDurumu");

            migrationBuilder.DropTable(
                name: "KullaniciRolu");

            migrationBuilder.DropTable(
                name: "HayvanTurleri");
        }
    }
}
