﻿// <auto-generated />
using System;
using HRConnect.Server.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRConnect.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231028125520_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BenefitDipendente", b =>
                {
                    b.Property<int>("BenefitsId")
                        .HasColumnType("int");

                    b.Property<int>("DipendentiId")
                        .HasColumnType("int");

                    b.HasKey("BenefitsId", "DipendentiId");

                    b.HasIndex("DipendentiId");

                    b.ToTable("BenefitDipendente");
                });

            modelBuilder.Entity("CandidatoHardSkill", b =>
                {
                    b.Property<int>("CandidatiId")
                        .HasColumnType("int");

                    b.Property<int>("HardSkillsId")
                        .HasColumnType("int");

                    b.HasKey("CandidatiId", "HardSkillsId");

                    b.HasIndex("HardSkillsId");

                    b.ToTable("CandidatoHardSkill");
                });

            modelBuilder.Entity("CandidatoSoftSkill", b =>
                {
                    b.Property<int>("CandidatiId")
                        .HasColumnType("int");

                    b.Property<int>("SoftSkillsId")
                        .HasColumnType("int");

                    b.HasKey("CandidatiId", "SoftSkillsId");

                    b.HasIndex("SoftSkillsId");

                    b.ToTable("CandidatoSoftSkill");
                });

            modelBuilder.Entity("CandidatoTitoloDiStudio", b =>
                {
                    b.Property<int>("CandidatiId")
                        .HasColumnType("int");

                    b.Property<int>("TitoloDiStudioId")
                        .HasColumnType("int");

                    b.HasKey("CandidatiId", "TitoloDiStudioId");

                    b.HasIndex("TitoloDiStudioId");

                    b.ToTable("CandidatoTitoloDiStudio");
                });

            modelBuilder.Entity("ContrattoHardSkill", b =>
                {
                    b.Property<int>("ContrattiId")
                        .HasColumnType("int");

                    b.Property<int>("HardSkillsId")
                        .HasColumnType("int");

                    b.HasKey("ContrattiId", "HardSkillsId");

                    b.HasIndex("HardSkillsId");

                    b.ToTable("ContrattoHardSkill");
                });

            modelBuilder.Entity("ContrattoSoftSkill", b =>
                {
                    b.Property<int>("ContrattiId")
                        .HasColumnType("int");

                    b.Property<int>("SoftSkillsId")
                        .HasColumnType("int");

                    b.HasKey("ContrattiId", "SoftSkillsId");

                    b.HasIndex("SoftSkillsId");

                    b.ToTable("ContrattoSoftSkill");
                });

            modelBuilder.Entity("DipendenteHardSkill", b =>
                {
                    b.Property<int>("DipendentiId")
                        .HasColumnType("int");

                    b.Property<int>("HardSkillsId")
                        .HasColumnType("int");

                    b.HasKey("DipendentiId", "HardSkillsId");

                    b.HasIndex("HardSkillsId");

                    b.ToTable("DipendenteHardSkill");
                });

            modelBuilder.Entity("DipendenteSoftSkill", b =>
                {
                    b.Property<int>("DipendentiId")
                        .HasColumnType("int");

                    b.Property<int>("SoftSkillsId")
                        .HasColumnType("int");

                    b.HasKey("DipendentiId", "SoftSkillsId");

                    b.HasIndex("SoftSkillsId");

                    b.ToTable("DipendenteSoftSkill");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Benefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CittaId")
                        .HasColumnType("int");

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColloquioId")
                        .HasColumnType("int");

                    b.Property<string>("ComuneDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContrattoId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentoID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinciaDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatoDiNascita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CittaId");

                    b.HasIndex("ColloquioId")
                        .IsUnique();

                    b.HasIndex("ContrattoId");

                    b.HasIndex("DocumentoID")
                        .IsUnique();

                    b.ToTable("Candidati");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Citta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SedeId")
                        .IsUnique();

                    b.ToTable("Citta");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Colloquio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataColloquio")
                        .HasColumnType("datetime2");

                    b.Property<int>("HRId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.Property<string>("Valutazione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HRId");

                    b.HasIndex("SedeId");

                    b.ToTable("Colloqui");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Contratto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<int>("LivelloContrattualeId")
                        .HasColumnType("int");

                    b.Property<string>("TipoContratto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivelloContrattualeId");

                    b.ToTable("Contratti");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Dipendente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContrattoId")
                        .HasColumnType("int");

                    b.Property<int>("LivelloContrattualeId")
                        .HasColumnType("int");

                    b.Property<int>("MansioneId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContrattoId");

                    b.HasIndex("LivelloContrattualeId")
                        .IsUnique();

                    b.HasIndex("MansioneId");

                    b.HasIndex("SedeId");

                    b.ToTable("Dipendenti");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("TipologiaDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documenti");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.EsperienzaLavorativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Azienda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<string>("Contratto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataFine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInizio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mansione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("EsperienzeLavorative");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.HR", b =>
                {
                    b.Property<int>("HRId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HRId"));

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HRId");

                    b.ToTable("HRs");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.HardSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<int>("LivelloContrattualeId")
                        .HasColumnType("int");

                    b.Property<string>("TipologiaSkill")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivelloContrattualeId")
                        .IsUnique();

                    b.ToTable("HardSkills");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.LivelloContrattuale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<int>("Livello")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LivelliContrattuali");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Mansione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mansioni");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Sede", b =>
                {
                    b.Property<int>("SedeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedeId"));

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HRId")
                        .HasColumnType("int");

                    b.Property<string>("Indirizzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recapito")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SedeId");

                    b.HasIndex("HRId")
                        .IsUnique();

                    b.ToTable("Sedi");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.SoftSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<int>("LivelloContrattualeId")
                        .HasColumnType("int");

                    b.Property<string>("TipologiaSkill")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivelloContrattualeId")
                        .IsUnique();

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.TitoloDiStudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("TipologiaTitolo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TitoliDiStudio");
                });

            modelBuilder.Entity("BenefitDipendente", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Benefit", null)
                        .WithMany()
                        .HasForeignKey("BenefitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Dipendente", null)
                        .WithMany()
                        .HasForeignKey("DipendentiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandidatoHardSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Candidato", null)
                        .WithMany()
                        .HasForeignKey("CandidatiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.HardSkill", null)
                        .WithMany()
                        .HasForeignKey("HardSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandidatoSoftSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Candidato", null)
                        .WithMany()
                        .HasForeignKey("CandidatiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.SoftSkill", null)
                        .WithMany()
                        .HasForeignKey("SoftSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandidatoTitoloDiStudio", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Candidato", null)
                        .WithMany()
                        .HasForeignKey("CandidatiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.TitoloDiStudio", null)
                        .WithMany()
                        .HasForeignKey("TitoloDiStudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContrattoHardSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Contratto", null)
                        .WithMany()
                        .HasForeignKey("ContrattiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.HardSkill", null)
                        .WithMany()
                        .HasForeignKey("HardSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContrattoSoftSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Contratto", null)
                        .WithMany()
                        .HasForeignKey("ContrattiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.SoftSkill", null)
                        .WithMany()
                        .HasForeignKey("SoftSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DipendenteHardSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Dipendente", null)
                        .WithMany()
                        .HasForeignKey("DipendentiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.HardSkill", null)
                        .WithMany()
                        .HasForeignKey("HardSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DipendenteSoftSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Dipendente", null)
                        .WithMany()
                        .HasForeignKey("DipendentiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.SoftSkill", null)
                        .WithMany()
                        .HasForeignKey("SoftSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Candidato", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Citta", "Citta")
                        .WithMany("Candidati")
                        .HasForeignKey("CittaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Colloquio", "Colloquio")
                        .WithOne("Candidato")
                        .HasForeignKey("HRConnect.Shared.Models.Candidato", "ColloquioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Contratto", "Contratto")
                        .WithMany("Candidato")
                        .HasForeignKey("ContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Documento", "Documento")
                        .WithOne("Candidato")
                        .HasForeignKey("HRConnect.Shared.Models.Candidato", "DocumentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citta");

                    b.Navigation("Colloquio");

                    b.Navigation("Contratto");

                    b.Navigation("Documento");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Citta", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Sede", "Sede")
                        .WithOne("Cittas")
                        .HasForeignKey("HRConnect.Shared.Models.Citta", "SedeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Colloquio", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.HR", "HR")
                        .WithMany("Colloqui")
                        .HasForeignKey("HRId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Sede", "Sede")
                        .WithMany("Colloqui")
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HR");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Contratto", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.LivelloContrattuale", "LivelloContrattuale")
                        .WithMany("Contratti")
                        .HasForeignKey("LivelloContrattualeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LivelloContrattuale");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Dipendente", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Contratto", "Contratto")
                        .WithMany("Dipendentes")
                        .HasForeignKey("ContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.LivelloContrattuale", "LivelliContrattuali")
                        .WithOne("Dipendente")
                        .HasForeignKey("HRConnect.Shared.Models.Dipendente", "LivelloContrattualeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Mansione", "Mansione")
                        .WithMany("Dipendenti")
                        .HasForeignKey("MansioneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRConnect.Shared.Models.Sede", "Sede")
                        .WithMany("Dipendenti")
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contratto");

                    b.Navigation("LivelliContrattuali");

                    b.Navigation("Mansione");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.EsperienzaLavorativa", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.Candidato", "Candidato")
                        .WithMany("EsperienzeLavorative")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.HardSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.LivelloContrattuale", "LivelliContrattuali")
                        .WithOne("HardSkill")
                        .HasForeignKey("HRConnect.Shared.Models.HardSkill", "LivelloContrattualeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LivelliContrattuali");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Sede", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.HR", "HR")
                        .WithOne("Sede")
                        .HasForeignKey("HRConnect.Shared.Models.Sede", "HRId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HR");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.SoftSkill", b =>
                {
                    b.HasOne("HRConnect.Shared.Models.LivelloContrattuale", "LivelloContrattuale")
                        .WithOne("SoftSkill")
                        .HasForeignKey("HRConnect.Shared.Models.SoftSkill", "LivelloContrattualeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LivelloContrattuale");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Candidato", b =>
                {
                    b.Navigation("EsperienzeLavorative");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Citta", b =>
                {
                    b.Navigation("Candidati");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Colloquio", b =>
                {
                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Contratto", b =>
                {
                    b.Navigation("Candidato");

                    b.Navigation("Dipendentes");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Documento", b =>
                {
                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.HR", b =>
                {
                    b.Navigation("Colloqui");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.LivelloContrattuale", b =>
                {
                    b.Navigation("Contratti");

                    b.Navigation("Dipendente");

                    b.Navigation("HardSkill");

                    b.Navigation("SoftSkill");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Mansione", b =>
                {
                    b.Navigation("Dipendenti");
                });

            modelBuilder.Entity("HRConnect.Shared.Models.Sede", b =>
                {
                    b.Navigation("Cittas");

                    b.Navigation("Colloqui");

                    b.Navigation("Dipendenti");
                });
#pragma warning restore 612, 618
        }
    }
}
