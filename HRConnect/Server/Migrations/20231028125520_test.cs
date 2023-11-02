using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRConnect.Server.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Citta_CittaId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Contratti_ContrattoId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_TitoliDiStudio_TitoloDiStudioId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Citta_Sedi_SedeId",
                table: "Citta");

            migrationBuilder.DropForeignKey(
                name: "FK_Colloqui_Candidati_CandidatoId",
                table: "Colloqui");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeID",
                table: "Contratti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Contratti_ContrattoId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_LivelliContrattuali_LivelliContrattualiID",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Mansioni_MansioneId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Sedi_SedeId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_EsperienzeLavorative_Candidati_CandidatoId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropForeignKey(
                name: "FK_EsperienzeLavorative_Contratti_ContrattoId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropForeignKey(
                name: "FK_EsperienzeLavorative_Mansioni_MansioneId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropTable(
                name: "HardSkillLivelloContrattuale");

            migrationBuilder.DropTable(
                name: "LivelloContrattualeSoftSkill");

            migrationBuilder.DropIndex(
                name: "IX_EsperienzeLavorative_ContrattoId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropIndex(
                name: "IX_EsperienzeLavorative_MansioneId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropIndex(
                name: "IX_Dipendenti_LivelliContrattualiID",
                table: "Dipendenti");

            migrationBuilder.DropIndex(
                name: "IX_Colloqui_CandidatoId",
                table: "Colloqui");

            migrationBuilder.DropIndex(
                name: "IX_Citta_SedeId",
                table: "Citta");

            migrationBuilder.DropIndex(
                name: "IX_Candidati_TitoloDiStudioId",
                table: "Candidati");

            migrationBuilder.DropColumn(
                name: "ContrattoId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropColumn(
                name: "MansioneId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropColumn(
                name: "LivelliContrattualiID",
                table: "Dipendenti");

            migrationBuilder.DropColumn(
                name: "CandidatiID",
                table: "Colloqui");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Colloqui");

            migrationBuilder.DropColumn(
                name: "TitoloDiStudioId",
                table: "Candidati");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "LivelliContrattuali",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LivelloContrattualeID",
                table: "Contratti",
                newName: "LivelloContrattualeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contratti_LivelloContrattualeID",
                table: "Contratti",
                newName: "IX_Contratti_LivelloContrattualeId");

            migrationBuilder.AddColumn<int>(
                name: "LivelloContrattualeId",
                table: "SoftSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Recapito",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Indirizzo",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Mansioni",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "LivelloContrattualeId",
                table: "HardSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "EsperienzeLavorative",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contratto",
                table: "EsperienzeLavorative",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mansione",
                table: "EsperienzeLavorative",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipologiaDocumento",
                table: "Documenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Dipendenti",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MansioneId",
                table: "Dipendenti",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContrattoId",
                table: "Dipendenti",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivelloContrattualeId",
                table: "Dipendenti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "LivelloContrattualeId",
                table: "Contratti",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Colloqui",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HRId",
                table: "Colloqui",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Citta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidati",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ContrattoId",
                table: "Candidati",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CittaId",
                table: "Candidati",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColloquioId",
                table: "Candidati",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CandidatoTitoloDiStudio",
                columns: table => new
                {
                    CandidatiId = table.Column<int>(type: "int", nullable: false),
                    TitoloDiStudioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoTitoloDiStudio", x => new { x.CandidatiId, x.TitoloDiStudioId });
                    table.ForeignKey(
                        name: "FK_CandidatoTitoloDiStudio_Candidati_CandidatiId",
                        column: x => x.CandidatiId,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoTitoloDiStudio_TitoliDiStudio_TitoloDiStudioId",
                        column: x => x.TitoloDiStudioId,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContrattoHardSkill",
                columns: table => new
                {
                    ContrattiId = table.Column<int>(type: "int", nullable: false),
                    HardSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContrattoHardSkill", x => new { x.ContrattiId, x.HardSkillsId });
                    table.ForeignKey(
                        name: "FK_ContrattoHardSkill_Contratti_ContrattiId",
                        column: x => x.ContrattiId,
                        principalTable: "Contratti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContrattoHardSkill_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContrattoSoftSkill",
                columns: table => new
                {
                    ContrattiId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContrattoSoftSkill", x => new { x.ContrattiId, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_ContrattoSoftSkill_Contratti_ContrattiId",
                        column: x => x.ContrattiId,
                        principalTable: "Contratti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContrattoSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkills_LivelloContrattualeId",
                table: "SoftSkills",
                column: "LivelloContrattualeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HardSkills_LivelloContrattualeId",
                table: "HardSkills",
                column: "LivelloContrattualeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_LivelloContrattualeId",
                table: "Dipendenti",
                column: "LivelloContrattualeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citta_SedeId",
                table: "Citta",
                column: "SedeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_ColloquioId",
                table: "Candidati",
                column: "ColloquioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoTitoloDiStudio_TitoloDiStudioId",
                table: "CandidatoTitoloDiStudio",
                column: "TitoloDiStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_ContrattoHardSkill_HardSkillsId",
                table: "ContrattoHardSkill",
                column: "HardSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContrattoSoftSkill_SoftSkillsId",
                table: "ContrattoSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Citta_CittaId",
                table: "Candidati",
                column: "CittaId",
                principalTable: "Citta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Colloqui_ColloquioId",
                table: "Candidati",
                column: "ColloquioId",
                principalTable: "Colloqui",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Contratti_ContrattoId",
                table: "Candidati",
                column: "ContrattoId",
                principalTable: "Contratti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citta_Sedi_SedeId",
                table: "Citta",
                column: "SedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeId",
                table: "Contratti",
                column: "LivelloContrattualeId",
                principalTable: "LivelliContrattuali",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Contratti_ContrattoId",
                table: "Dipendenti",
                column: "ContrattoId",
                principalTable: "Contratti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_LivelliContrattuali_LivelloContrattualeId",
                table: "Dipendenti",
                column: "LivelloContrattualeId",
                principalTable: "LivelliContrattuali",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Mansioni_MansioneId",
                table: "Dipendenti",
                column: "MansioneId",
                principalTable: "Mansioni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Sedi_SedeId",
                table: "Dipendenti",
                column: "SedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EsperienzeLavorative_Candidati_CandidatoId",
                table: "EsperienzeLavorative",
                column: "CandidatoId",
                principalTable: "Candidati",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HardSkills_LivelliContrattuali_LivelloContrattualeId",
                table: "HardSkills",
                column: "LivelloContrattualeId",
                principalTable: "LivelliContrattuali",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftSkills_LivelliContrattuali_LivelloContrattualeId",
                table: "SoftSkills",
                column: "LivelloContrattualeId",
                principalTable: "LivelliContrattuali",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Citta_CittaId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Colloqui_ColloquioId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Contratti_ContrattoId",
                table: "Candidati");

            migrationBuilder.DropForeignKey(
                name: "FK_Citta_Sedi_SedeId",
                table: "Citta");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeId",
                table: "Contratti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Contratti_ContrattoId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_LivelliContrattuali_LivelloContrattualeId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Mansioni_MansioneId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Dipendenti_Sedi_SedeId",
                table: "Dipendenti");

            migrationBuilder.DropForeignKey(
                name: "FK_EsperienzeLavorative_Candidati_CandidatoId",
                table: "EsperienzeLavorative");

            migrationBuilder.DropForeignKey(
                name: "FK_HardSkills_LivelliContrattuali_LivelloContrattualeId",
                table: "HardSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftSkills_LivelliContrattuali_LivelloContrattualeId",
                table: "SoftSkills");

            migrationBuilder.DropTable(
                name: "CandidatoTitoloDiStudio");

            migrationBuilder.DropTable(
                name: "ContrattoHardSkill");

            migrationBuilder.DropTable(
                name: "ContrattoSoftSkill");

            migrationBuilder.DropIndex(
                name: "IX_SoftSkills_LivelloContrattualeId",
                table: "SoftSkills");

            migrationBuilder.DropIndex(
                name: "IX_HardSkills_LivelloContrattualeId",
                table: "HardSkills");

            migrationBuilder.DropIndex(
                name: "IX_Dipendenti_LivelloContrattualeId",
                table: "Dipendenti");

            migrationBuilder.DropIndex(
                name: "IX_Citta_SedeId",
                table: "Citta");

            migrationBuilder.DropIndex(
                name: "IX_Candidati_ColloquioId",
                table: "Candidati");

            migrationBuilder.DropColumn(
                name: "LivelloContrattualeId",
                table: "SoftSkills");

            migrationBuilder.DropColumn(
                name: "LivelloContrattualeId",
                table: "HardSkills");

            migrationBuilder.DropColumn(
                name: "Contratto",
                table: "EsperienzeLavorative");

            migrationBuilder.DropColumn(
                name: "Mansione",
                table: "EsperienzeLavorative");

            migrationBuilder.DropColumn(
                name: "TipologiaDocumento",
                table: "Documenti");

            migrationBuilder.DropColumn(
                name: "LivelloContrattualeId",
                table: "Dipendenti");

            migrationBuilder.DropColumn(
                name: "ColloquioId",
                table: "Candidati");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LivelliContrattuali",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LivelloContrattualeId",
                table: "Contratti",
                newName: "LivelloContrattualeID");

            migrationBuilder.RenameIndex(
                name: "IX_Contratti_LivelloContrattualeId",
                table: "Contratti",
                newName: "IX_Contratti_LivelloContrattualeID");

            migrationBuilder.AlterColumn<string>(
                name: "Recapito",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Indirizzo",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Sedi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Mansioni",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CandidatoId",
                table: "EsperienzeLavorative",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContrattoId",
                table: "EsperienzeLavorative",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MansioneId",
                table: "EsperienzeLavorative",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Dipendenti",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MansioneId",
                table: "Dipendenti",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContrattoId",
                table: "Dipendenti",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LivelliContrattualiID",
                table: "Dipendenti",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LivelloContrattualeID",
                table: "Contratti",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Colloqui",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HRId",
                table: "Colloqui",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CandidatiID",
                table: "Colloqui",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Colloqui",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SedeId",
                table: "Citta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidati",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContrattoId",
                table: "Candidati",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CittaId",
                table: "Candidati",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TitoloDiStudioId",
                table: "Candidati",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HardSkillLivelloContrattuale",
                columns: table => new
                {
                    HardSkillsId = table.Column<int>(type: "int", nullable: false),
                    LivelliContrattualiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkillLivelloContrattuale", x => new { x.HardSkillsId, x.LivelliContrattualiID });
                    table.ForeignKey(
                        name: "FK_HardSkillLivelloContrattuale_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardSkillLivelloContrattuale_LivelliContrattuali_LivelliContrattualiID",
                        column: x => x.LivelliContrattualiID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivelloContrattualeSoftSkill",
                columns: table => new
                {
                    DescrizioneLavoriID = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelloContrattualeSoftSkill", x => new { x.DescrizioneLavoriID, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_LivelloContrattualeSoftSkill_LivelliContrattuali_DescrizioneLavoriID",
                        column: x => x.DescrizioneLavoriID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivelloContrattualeSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_ContrattoId",
                table: "EsperienzeLavorative",
                column: "ContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_MansioneId",
                table: "EsperienzeLavorative",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_LivelliContrattualiID",
                table: "Dipendenti",
                column: "LivelliContrattualiID");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_CandidatoId",
                table: "Colloqui",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citta_SedeId",
                table: "Citta",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TitoloDiStudioId",
                table: "Candidati",
                column: "TitoloDiStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_HardSkillLivelloContrattuale_LivelliContrattualiID",
                table: "HardSkillLivelloContrattuale",
                column: "LivelliContrattualiID");

            migrationBuilder.CreateIndex(
                name: "IX_LivelloContrattualeSoftSkill_SoftSkillsId",
                table: "LivelloContrattualeSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Citta_CittaId",
                table: "Candidati",
                column: "CittaId",
                principalTable: "Citta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Contratti_ContrattoId",
                table: "Candidati",
                column: "ContrattoId",
                principalTable: "Contratti",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_TitoliDiStudio_TitoloDiStudioId",
                table: "Candidati",
                column: "TitoloDiStudioId",
                principalTable: "TitoliDiStudio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Citta_Sedi_SedeId",
                table: "Citta",
                column: "SedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colloqui_Candidati_CandidatoId",
                table: "Colloqui",
                column: "CandidatoId",
                principalTable: "Candidati",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeID",
                table: "Contratti",
                column: "LivelloContrattualeID",
                principalTable: "LivelliContrattuali",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Contratti_ContrattoId",
                table: "Dipendenti",
                column: "ContrattoId",
                principalTable: "Contratti",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_LivelliContrattuali_LivelliContrattualiID",
                table: "Dipendenti",
                column: "LivelliContrattualiID",
                principalTable: "LivelliContrattuali",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Mansioni_MansioneId",
                table: "Dipendenti",
                column: "MansioneId",
                principalTable: "Mansioni",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Sedi_SedeId",
                table: "Dipendenti",
                column: "SedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EsperienzeLavorative_Candidati_CandidatoId",
                table: "EsperienzeLavorative",
                column: "CandidatoId",
                principalTable: "Candidati",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EsperienzeLavorative_Contratti_ContrattoId",
                table: "EsperienzeLavorative",
                column: "ContrattoId",
                principalTable: "Contratti",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EsperienzeLavorative_Mansioni_MansioneId",
                table: "EsperienzeLavorative",
                column: "MansioneId",
                principalTable: "Mansioni",
                principalColumn: "Id");
        }
    }
}
