using System;
using System.Collections.Generic;
using DxBlazorApplicationScheduler.Models;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorApplicationScheduler.TempModels;

public partial class TempDbContext : DbContext
{
    public TempDbContext()
    {
    }

    public TempDbContext(DbContextOptions<TempDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgruSt> AgruSts { get; set; }

    public virtual DbSet<AnalyseDte> AnalyseDtes { get; set; }

    public virtual DbSet<AnalyseKbw> AnalyseKbws { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<ArtiIm> ArtiIms { get; set; }

    public virtual DbSet<ArtiSt> ArtiSts { get; set; }

    public virtual DbSet<BarcSt> BarcSts { get; set; }

    public virtual DbSet<BartSt> BartSts { get; set; }

    public virtual DbSet<BewAst> BewAsts { get; set; }

    public virtual DbSet<BewDbw> BewDbws { get; set; }

    public virtual DbSet<BewDte> BewDtes { get; set; }

    public virtual DbSet<BewKbw> BewKbws { get; set; }

    public virtual DbSet<BewVer> BewVers { get; set; }

    public virtual DbSet<BewaSy> BewaSies { get; set; }

    public virtual DbSet<Bewimp> Bewimps { get; set; }

    public virtual DbSet<BewimpTemp> BewimpTemps { get; set; }

    public virtual DbSet<Errorlog> Errorlogs { get; set; }

    public virtual DbSet<ErzeSt> ErzeSts { get; set; }

    public virtual DbSet<EtiaSt> EtiaSts { get; set; }

    public virtual DbSet<ExpoBw> ExpoBws { get; set; }

    public virtual DbSet<FaktBw> FaktBws { get; set; }

    public virtual DbSet<FigrSt> FigrSts { get; set; }

    public virtual DbSet<FiliSt> FiliSts { get; set; }

    public virtual DbSet<Firmendaten> Firmendatens { get; set; }

    public virtual DbSet<GeFil> GeFils { get; set; }

    public virtual DbSet<GegrSy> GegrSies { get; set; }

    public virtual DbSet<Gegrst> Gegrsts { get; set; }

    public virtual DbSet<GeraSt> GeraSts { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GrupCv> GrupCvs { get; set; }

    public virtual DbSet<HagrSt> HagrSts { get; set; }

    public virtual DbSet<Id> Ids { get; set; }

    public virtual DbSet<KaMpst> KaMpsts { get; set; }

    public virtual DbSet<KaPfSt> KaPfSts { get; set; }

    public virtual DbSet<KawgSt> KawgSts { get; set; }

    public virtual DbSet<KunAst> KunAsts { get; set; }

    public virtual DbSet<KundSt> KundSts { get; set; }

    public virtual DbSet<LageSt> LageSts { get; set; }

    public virtual DbSet<LevoSy> LevoSies { get; set; }

    public virtual DbSet<LiFil> LiFils { get; set; }

    public virtual DbSet<LiefCv> LiefCvs { get; set; }

    public virtual DbSet<LiefSt> LiefSts { get; set; }

    public virtual DbSet<LireSt> LireSts { get; set; }

    public virtual DbSet<Lstdbw> Lstdbws { get; set; }

    public virtual DbSet<Lstkbw> Lstkbws { get; set; }

    public virtual DbSet<Mmcntrl> Mmcntrls { get; set; }

    public virtual DbSet<Mmsecure> Mmsecures { get; set; }

    public virtual DbSet<MpGast> MpGasts { get; set; }

    public virtual DbSet<MpgrSt> MpgrSts { get; set; }

    public virtual DbSet<RadeSt> RadeSts { get; set; }

    public virtual DbSet<RagrSt> RagrSts { get; set; }

    public virtual DbSet<RastSt> RastSts { get; set; }

    public virtual DbSet<RechBw> RechBws { get; set; }

    public virtual DbSet<RepoSt> RepoSts { get; set; }

    public virtual DbSet<RepoSy> RepoSies { get; set; }

    public virtual DbSet<Repolist> Repolists { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<Setsst> Setssts { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<SteuSt> SteuSts { get; set; }

    public virtual DbSet<TJournalarchiv> TJournalarchivs { get; set; }

    public virtual DbSet<TKjournal> TKjournals { get; set; }

    public virtual DbSet<Tljournal> Tljournals { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usgrlink> Usgrlinks { get; set; }

    public virtual DbSet<VaFil> VaFils { get; set; }

    public virtual DbSet<VaLie> VaLies { get; set; }

    public virtual DbSet<VariSt> VariSts { get; set; }

    public virtual DbSet<VteAst> VteAsts { get; set; }

    public virtual DbSet<VteDst> VteDsts { get; set; }

    public virtual DbSet<VteKst> VteKsts { get; set; }

    public virtual DbSet<VtedIm> VtedIms { get; set; }

    public virtual DbSet<VtekIm> VtekIms { get; set; }

    public virtual DbSet<WagrSt> WagrSts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=luki_db;User Id=user;Password=Password1234?;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgruSt>(entity =>
        {
            entity.HasKey(e => e.AgrustId)
                .HasName("PRIMARY7")
                .IsClustered(false);

            entity.ToTable("AgruST");

            entity.HasIndex(e => e.Agrunr, "AGRUNR");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.Property(e => e.AgrustId).HasColumnName("AGRUST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Agrunr)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("AGRUNR");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.LNonielsen)
                .HasDefaultValue(false)
                .HasColumnName("lNONIELSEN");
            entity.Property(e => e.Sollspanne)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("SOLLSPANNE");
        });

        modelBuilder.Entity<AnalyseDte>(entity =>
        {
            entity.HasKey(e => e.BewdteId)
                .HasName("PRIMARY038")
                .IsClustered(false);

            entity.ToTable("AnalyseDTE");

            entity.Property(e => e.BewdteId).HasColumnName("BEWDTE_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.BarcstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BARCST_ID");
            entity.Property(e => e.Bedienerid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEDIENERID");
            entity.Property(e => e.BewdbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWDBW_ID");
            entity.Property(e => e.BewkbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWKBW_ID");
            entity.Property(e => e.Datum01).HasColumnName("DATUM01");
            entity.Property(e => e.Datum02).HasColumnName("DATUM02");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Extbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEK");
            entity.Property(e => e.Extbekkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEKKORR");
            entity.Property(e => e.Extekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKP");
            entity.Property(e => e.Extekpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKPKORR");
            entity.Property(e => e.Extmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENGE");
            entity.Property(e => e.Extmenkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENKORR");
            entity.Property(e => e.Extvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKP");
            entity.Property(e => e.Extvkpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKPKORR");
            entity.Property(e => e.Faktorlag).HasColumnName("FAKTORLAG");
            entity.Property(e => e.Faktorums).HasColumnName("FAKTORUMS");
            entity.Property(e => e.FilistId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FILIST_ID");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG02");
            entity.Property(e => e.GeFilId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GE_FIL_ID");
            entity.Property(e => e.Intbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEK");
            entity.Property(e => e.Intbekeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEKEINZ");
            entity.Property(e => e.Intekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKP");
            entity.Property(e => e.Intekpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKPEINZ");
            entity.Property(e => e.Intvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKP");
            entity.Property(e => e.Intvkpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPEINZ");
            entity.Property(e => e.Intvkpnet)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPNET");
            entity.Property(e => e.Kassierid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KASSIERID");
            entity.Property(e => e.LFestpreis)
                .HasDefaultValue(true)
                .HasColumnName("lFESTPREIS");
            entity.Property(e => e.LFolgebew).HasColumnName("lFOLGEBEW");
            entity.Property(e => e.LLagerabs).HasColumnName("lLAGERABS");
            entity.Property(e => e.LLagerbew).HasColumnName("lLAGERBEW");
            entity.Property(e => e.LLagfehler).HasColumnName("lLAGFEHLER");
            entity.Property(e => e.LUmsatz).HasColumnName("lUMSATZ");
            entity.Property(e => e.LUnterdr).HasColumnName("lUNTERDR");
            entity.Property(e => e.Lagerabs)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERABS");
            entity.Property(e => e.Lagerbew)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERBEW");
            entity.Property(e => e.LagestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.LiefstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_IDB");
            entity.Property(e => e.Num01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM01");
            entity.Property(e => e.Num02)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM02");
            entity.Property(e => e.Num03)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM03");
            entity.Property(e => e.Num04)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM04");
            entity.Property(e => e.Num05)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM05");
            entity.Property(e => e.Num06)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM06");
            entity.Property(e => e.Num07)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM07");
            entity.Property(e => e.Num08)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM08");
            entity.Property(e => e.Num09)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM09");
            entity.Property(e => e.Num10)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM10");
            entity.Property(e => e.Refmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("REFMENGE");
            entity.Property(e => e.VaLieId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VA_LIE_ID");
            entity.Property(e => e.VaristId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VARIST_ID");
            entity.Property(e => e.Vkstk00)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK00");
            entity.Property(e => e.Vkstk01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK01");
            entity.Property(e => e.Vkstk02)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK02");
            entity.Property(e => e.Vkstk03)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK03");
            entity.Property(e => e.Vkstk04)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK04");
            entity.Property(e => e.Vkstk05)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK05");
            entity.Property(e => e.Vkstk06)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK06");
            entity.Property(e => e.Vkstk07)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK07");
            entity.Property(e => e.Vkstk08)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK08");
            entity.Property(e => e.Vkstk09)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK09");
            entity.Property(e => e.Vkstk10)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK10");
            entity.Property(e => e.Vkstk11)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK11");
            entity.Property(e => e.Vkstk12)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK12");

            entity.HasOne(d => d.Barcst).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.BarcstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_0288");

            entity.HasOne(d => d.Bewdbw).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.BewdbwId)
                .HasConstraintName("Relation_0308");

            entity.HasOne(d => d.Bewkbw).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.BewkbwId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_0283");

            entity.HasOne(d => d.Filist).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_0281");

            entity.HasOne(d => d.GeFil).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.GeFilId)
                .HasConstraintName("Relation_0285");

            entity.HasOne(d => d.Lagest).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.LagestId)
                .HasConstraintName("Relation_0286");

            entity.HasOne(d => d.Liefst).WithMany(p => p.AnalyseDteLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_0284");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.AnalyseDteLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_0305");

            entity.HasOne(d => d.VaLie).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.VaLieId)
                .HasConstraintName("Relation_0287");

            entity.HasOne(d => d.Varist).WithMany(p => p.AnalyseDtes)
                .HasForeignKey(d => d.VaristId)
                .HasConstraintName("Relation_0282");
        });

        modelBuilder.Entity<AnalyseKbw>(entity =>
        {
            entity.HasKey(e => e.BewkbwId)
                .HasName("PRIMARY034")
                .IsClustered(false);

            entity.ToTable("AnalyseKBW");

            entity.Property(e => e.BewkbwId).HasColumnName("BEWKBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bearbstat)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("BEARBSTAT");
            entity.Property(e => e.Bedienerid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEDIENERID");
            entity.Property(e => e.BewastId).HasColumnName("BEWAST_ID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Datbuchung)
                .HasColumnType("datetime")
                .HasColumnName("DATBUCHUNG");
            entity.Property(e => e.Datorgdok).HasColumnName("DATORGDOK");
            entity.Property(e => e.Datum01).HasColumnName("DATUM01");
            entity.Property(e => e.Datum02).HasColumnName("DATUM02");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Datzeit01)
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT01");
            entity.Property(e => e.Datzeit02)
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT02");
            entity.Property(e => e.Extid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EXTID");
            entity.Property(e => e.FaktbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FAKTBW_ID");
            entity.Property(e => e.FilistId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FILIST_ID");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG02");
            entity.Property(e => e.Flag03)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG03");
            entity.Property(e => e.Flag04)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG04");
            entity.Property(e => e.Flag05)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG05");
            entity.Property(e => e.GeFilId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GE_FIL_ID");
            entity.Property(e => e.Kassierid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KASSIERID");
            entity.Property(e => e.KundstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("KUNDST_ID");
            entity.Property(e => e.LErl0meng).HasColumnName("lERL0MENG");
            entity.Property(e => e.LFolgebew).HasColumnName("lFOLGEBEW");
            entity.Property(e => e.LFolgegebu).HasColumnName("lFOLGEGEBU");
            entity.Property(e => e.LIntemp).HasColumnName("lINTEMP");
            entity.Property(e => e.LVlieinf).HasColumnName("lVLIEINF");
            entity.Property(e => e.LagestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.LiefstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_IDB");
            entity.Property(e => e.Num01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM01");
            entity.Property(e => e.Num02)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM02");
            entity.Property(e => e.Num03)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM03");
            entity.Property(e => e.Num04)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM04");
            entity.Property(e => e.Num05)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM05");
            entity.Property(e => e.Num06)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM06");
            entity.Property(e => e.Num07)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM07");
            entity.Property(e => e.Num08)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM08");
            entity.Property(e => e.Num09)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM09");
            entity.Property(e => e.Num10)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM10");
            entity.Property(e => e.RechbwId).HasColumnName("RECHBW_ID");

            entity.HasOne(d => d.Bewast).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.BewastId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_0256");

            entity.HasOne(d => d.Faktbw).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.FaktbwId)
                .HasConstraintName("Relation_0295");

            entity.HasOne(d => d.Filist).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_0270");

            entity.HasOne(d => d.GeFil).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.GeFilId)
                .HasConstraintName("Relation_0268");

            entity.HasOne(d => d.Kundst).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.KundstId)
                .HasConstraintName("Relation_0293");

            entity.HasOne(d => d.Lagest).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.LagestId)
                .HasConstraintName("Relation_0279");

            entity.HasOne(d => d.Liefst).WithMany(p => p.AnalyseKbwLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_0278");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.AnalyseKbwLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_0306");

            entity.HasOne(d => d.Rechbw).WithMany(p => p.AnalyseKbws)
                .HasForeignKey(d => d.RechbwId)
                .HasConstraintName("Relation_0310");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.Property(e => e.AppointmentType).HasMaxLength(50);
            entity.Property(e => e.Caption).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Recurrence).HasMaxLength(50);
            entity.Property(e => e.Resources).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Resource).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointments_Resources");
        });

        modelBuilder.Entity<ArtiIm>(entity =>
        {
            entity.HasKey(e => e.ArtiimId)
                .HasName("PRIMARY28")
                .IsClustered(false);

            entity.ToTable("ArtiIM");

            entity.HasIndex(e => e.AgrustId, "AgruST");

            entity.HasIndex(e => e.ErzestId, "ErzeST");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.HagrstId, "HagrST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.SteustId, "SteuST");

            entity.HasIndex(e => e.WagrstId, "WagrST");

            entity.Property(e => e.ArtiimId).HasColumnName("ARTIIM_ID");
            entity.Property(e => e.Abdatum)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ABDATUM");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.AgrustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("AGRUST_ID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Anzeti1)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI1");
            entity.Property(e => e.Anzeti2)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI2");
            entity.Property(e => e.Anzeti3)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI3");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BARCODE");
            entity.Property(e => e.Bek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BEK");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Datumbis).HasColumnName("DATUMBIS");
            entity.Property(e => e.Datumvon).HasColumnName("DATUMVON");
            entity.Property(e => e.Ek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EK");
            entity.Property(e => e.Ekuerzel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EKUERZEL");
            entity.Property(e => e.ErzestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ERZEST_ID");
            entity.Property(e => e.Faktor)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("FAKTOR");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Gewichtnet)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("GEWICHTNET");
            entity.Property(e => e.Ghe)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("GHE");
            entity.Property(e => e.Ghebez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GHEBEZ");
            entity.Property(e => e.Ghstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GHSTATUS");
            entity.Property(e => e.Gpeinheit)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("GPEINHEIT");
            entity.Property(e => e.HagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("HAGRST_ID");
            entity.Property(e => e.Isurspland)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ISURSPLAND");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.Laktiv)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAKTIV");
            entity.Property(e => e.Lanalysiert).HasColumnName("LANALYSIERT");
            entity.Property(e => e.LgagrustId).HasColumnName("LGAGRUST_ID");
            entity.Property(e => e.Lgaktiv).HasColumnName("LGAKTIV");
            entity.Property(e => e.Lganzeti1).HasColumnName("LGANZETI1");
            entity.Property(e => e.Lganzeti2).HasColumnName("LGANZETI2");
            entity.Property(e => e.Lganzeti3).HasColumnName("LGANZETI3");
            entity.Property(e => e.Lgbarcode).HasColumnName("LGBARCODE");
            entity.Property(e => e.Lgbek).HasColumnName("LGBEK");
            entity.Property(e => e.Lgbezeichn).HasColumnName("LGBEZEICHN");
            entity.Property(e => e.Lgek).HasColumnName("LGEK");
            entity.Property(e => e.LgerzestId).HasColumnName("LGERZEST_ID");
            entity.Property(e => e.Lgfaktor).HasColumnName("LGFAKTOR");
            entity.Property(e => e.Lggewichtnet).HasColumnName("LGGEWICHTNET");
            entity.Property(e => e.Lgghbez).HasColumnName("LGGHBEZ");
            entity.Property(e => e.Lgghe).HasColumnName("LGGHE");
            entity.Property(e => e.Lgghebez).HasColumnName("LGGHEBEZ");
            entity.Property(e => e.Lgghstatus).HasColumnName("LGGHSTATUS");
            entity.Property(e => e.Lggpeinheit).HasColumnName("LGGPEINHEIT");
            entity.Property(e => e.LghagrstId).HasColumnName("LGHAGRST_ID");
            entity.Property(e => e.Lginaktion).HasColumnName("LGINAKTION");
            entity.Property(e => e.Lgisurspland).HasColumnName("LGISURSPLAND");
            entity.Property(e => e.Lgkabezeichn).HasColumnName("LGKABEZEICHN");
            entity.Property(e => e.Lglaktiv).HasColumnName("LGLAKTIV");
            entity.Property(e => e.Lglwiegeart).HasColumnName("LGLWIEGEART");
            entity.Property(e => e.Lgmatchcode).HasColumnName("LGMATCHCODE");
            entity.Property(e => e.Lgmerkmal01).HasColumnName("LGMERKMAL01");
            entity.Property(e => e.Lgmerkmal02).HasColumnName("LGMERKMAL02");
            entity.Property(e => e.Lgnetinh).HasColumnName("LGNETINH");
            entity.Property(e => e.Lgnetinhbez).HasColumnName("LGNETINHBEZ");
            entity.Property(e => e.LgsteustId).HasColumnName("LGSTEUST_ID");
            entity.Property(e => e.Lgvk).HasColumnName("LGVK");
            entity.Property(e => e.LgwagrstId).HasColumnName("LGWAGRST_ID");
            entity.Property(e => e.Lgzbezeichn).HasColumnName("LGZBEZEICHN");
            entity.Property(e => e.Liefartnr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LIEFARTNR");
            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");
            entity.Property(e => e.Linaktion).HasColumnName("LINAKTION");
            entity.Property(e => e.Lwiegeart)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LWIEGEART");
            entity.Property(e => e.Matchcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MATCHCODE");
            entity.Property(e => e.Merkmal01)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MERKMAL01");
            entity.Property(e => e.Merkmal02)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MERKMAL02");
            entity.Property(e => e.Netinh)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("NETINH");
            entity.Property(e => e.Netinhbez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("NETINHBEZ");
            entity.Property(e => e.Neuspanne)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NEUSPANNE");
            entity.Property(e => e.Stammbek)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("STAMMBEK");
            entity.Property(e => e.Stammekp)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("STAMMEKP");
            entity.Property(e => e.Stammspanne)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("STAMMSPANNE");
            entity.Property(e => e.Stammvkp)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("STAMMVKP");
            entity.Property(e => e.SteustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("STEUST_ID");
            entity.Property(e => e.Suslief)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUSLIEF");
            entity.Property(e => e.Tempbezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TEMPBEZEICHN");
            entity.Property(e => e.Updstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UPDSTATUS");
            entity.Property(e => e.Vk)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK");
            entity.Property(e => e.WagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("WAGRST_ID");
            entity.Property(e => e.Zbezeichn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ZBEZEICHN");

            entity.HasOne(d => d.Agrust).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.AgrustId)
                .HasConstraintName("Relation_2430");

            entity.HasOne(d => d.Erzest).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.ErzestId)
                .HasConstraintName("Relation_319");

            entity.HasOne(d => d.Filist).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_317");

            entity.HasOne(d => d.Hagrst).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.HagrstId)
                .HasConstraintName("Relation_2420");

            entity.HasOne(d => d.Liefst).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.LiefstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_2410");

            entity.HasOne(d => d.Steust).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.SteustId)
                .HasConstraintName("Relation_246");

            entity.HasOne(d => d.Wagrst).WithMany(p => p.ArtiIms)
                .HasForeignKey(d => d.WagrstId)
                .HasConstraintName("Relation_245");
        });

        modelBuilder.Entity<ArtiSt>(entity =>
        {
            entity.HasKey(e => e.ArtistId)
                .HasName("PRIMARY")
                .IsClustered(false);

            entity.ToTable("ArtiST");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.RaststId, "RastST");

            entity.Property(e => e.ArtistId).HasColumnName("ARTIST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.LSetarti)
                .HasDefaultValue(false)
                .HasColumnName("lSETARTI");
            entity.Property(e => e.RaststId).HasColumnName("RASTST_ID");

            entity.HasOne(d => d.Rastst).WithMany(p => p.ArtiSts)
                .HasForeignKey(d => d.RaststId)
                .HasConstraintName("Relation_241");
        });

        modelBuilder.Entity<BarcSt>(entity =>
        {
            entity.HasKey(e => e.BarcstId)
                .HasName("PRIMARY1")
                .IsClustered(false);

            entity.ToTable("BarcST");

            entity.HasIndex(e => e.Barcode, "BARCODE");

            entity.HasIndex(e => e.GegrstId, "GegrST");

            entity.HasIndex(e => e.VaristId, "VARIST_ID");

            entity.Property(e => e.BarcstId).HasColumnName("BARCST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BARCODE");
            entity.Property(e => e.Faktor)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("FAKTOR");
            entity.Property(e => e.GegrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GEGRST_ID");
            entity.Property(e => e.LIntausz).HasColumnName("lINTAUSZ");
            entity.Property(e => e.Letztvk).HasColumnName("LETZTVK");
            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");
            entity.Property(e => e.Vkkorrbetr)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKKORRBETR");
            entity.Property(e => e.Vkkorrfakt)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("VKKORRFAKT");

            entity.HasOne(d => d.Gegrst).WithMany(p => p.BarcSts)
                .HasForeignKey(d => d.GegrstId)
                .HasConstraintName("Relation_313");

            entity.HasOne(d => d.Varist).WithMany(p => p.BarcSts)
                .HasForeignKey(d => d.VaristId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_206");
        });

        modelBuilder.Entity<BartSt>(entity =>
        {
            entity.HasKey(e => e.BartstId)
                .HasName("PRIMARY22")
                .IsClustered(false);

            entity.ToTable("BartST");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.HasIndex(e => e.Prefix, "PREFIX");

            entity.Property(e => e.BartstId)
                .ValueGeneratedNever()
                .HasColumnName("BARTST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Codekonv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODEKONV");
            entity.Property(e => e.Codelen)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("CODELEN");
            entity.Property(e => e.Codemaske)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODEMASKE");
            entity.Property(e => e.Codetype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CODETYPE");
            entity.Property(e => e.Kalktype)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("KALKTYPE");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Nachkomma)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("NACHKOMMA");
            entity.Property(e => e.Prefix)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
            entity.Property(e => e.Prefixlen)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("PREFIXLEN");
        });

        modelBuilder.Entity<BewAst>(entity =>
        {
            entity.HasKey(e => e.BewastId)
                .HasName("PRIMARY33")
                .IsClustered(false);

            entity.ToTable("BewAST");

            entity.HasIndex(e => e.BewastIdl, "BewAST");

            entity.HasIndex(e => e.BewasyId, "BewaSY");

            entity.Property(e => e.BewastId).HasColumnName("BEWAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.BewastIdl)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWAST_IDL");
            entity.Property(e => e.BewasyId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWASY_ID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Faktorlag)
                .HasDefaultValue(1)
                .HasColumnName("FAKTORLAG");
            entity.Property(e => e.Faktorums)
                .HasDefaultValue(1)
                .HasColumnName("FAKTORUMS");
            entity.Property(e => e.LErl0menaw).HasColumnName("lERL0MENAW");
            entity.Property(e => e.LErl0meng).HasColumnName("lERL0MENG");
            entity.Property(e => e.LErlliefb).HasColumnName("lERLLIEFB");
            entity.Property(e => e.LErlliefst).HasColumnName("lERLLIEFST");
            entity.Property(e => e.LErlmanneu).HasColumnName("lERLMANNEU");
            entity.Property(e => e.LErlmanupd).HasColumnName("lERLMANUPD");
            entity.Property(e => e.LLagerabs).HasColumnName("lLAGERABS");
            entity.Property(e => e.LLagerbew).HasColumnName("lLAGERBEW");
            entity.Property(e => e.LUmsatz).HasColumnName("lUMSATZ");
            entity.Property(e => e.LVlieinf).HasColumnName("lVLIEINF");
            entity.Property(e => e.LVlieinfaw).HasColumnName("lVLIEINFAW");
            entity.Property(e => e.LZuautbest).HasColumnName("lZUAUTBEST");
            entity.Property(e => e.LZurefbest).HasColumnName("lZUREFBEST");
            entity.Property(e => e.LZwafilist)
                .HasDefaultValue(true)
                .HasColumnName("lZWAFILIST");
            entity.Property(e => e.LZwaliefb).HasColumnName("lZWALIEFB");
            entity.Property(e => e.LZwaliefst).HasColumnName("lZWALIEFST");
            entity.Property(e => e.Reihung)
                .HasDefaultValue(1)
                .HasColumnName("REIHUNG");

            entity.HasOne(d => d.BewastIdlNavigation).WithMany(p => p.InverseBewastIdlNavigation)
                .HasForeignKey(d => d.BewastIdl)
                .HasConstraintName("Relation_307");

            entity.HasOne(d => d.Bewasy).WithMany(p => p.BewAsts)
                .HasForeignKey(d => d.BewasyId)
                .HasConstraintName("Relation_289");
        });

        modelBuilder.Entity<BewDbw>(entity =>
        {
            entity.HasKey(e => e.BewdbwId)
                .HasName("PRIMARY35")
                .IsClustered(false);

            entity.ToTable("BewDBW");

            entity.HasIndex(e => e.AgrustId, "AgruST");

            entity.HasIndex(e => e.BarcstId, "BarcST");

            entity.HasIndex(e => e.BewdbwIdl, "BewDBW");

            entity.HasIndex(e => e.BewkbwId, "BewKBW");

            entity.HasIndex(e => e.Datzeit, "DATZEIT");

            entity.HasIndex(e => e.FilistId, "FiliSTU");

            entity.HasIndex(e => e.GeFilId, "GE_FIL");

            entity.HasIndex(e => e.HagrstId, "HagrST");

            entity.HasIndex(e => e.LagestId, "LageST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.LiefstIdb, "LiefST0");

            entity.HasIndex(e => e.MpgrstId, "MpgrST");

            entity.HasIndex(e => e.SteustId, "SteuST");

            entity.HasIndex(e => e.VaLieId, "VA_LIE");

            entity.HasIndex(e => e.VtedstId, "VTeDST");

            entity.HasIndex(e => e.VtekstId, "VTeKST");

            entity.HasIndex(e => e.VaristId, "VariST");

            entity.HasIndex(e => e.WagrstId, "WagrST");

            entity.Property(e => e.BewdbwId).HasColumnName("BEWDBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.AgrustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("AGRUST_ID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.BarcstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BARCST_ID");
            entity.Property(e => e.Bedienerid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEDIENERID");
            entity.Property(e => e.BewdbwIdl)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWDBW_IDL");
            entity.Property(e => e.BewkbwId).HasColumnName("BEWKBW_ID");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Extbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEK");
            entity.Property(e => e.Extbekkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEKKORR");
            entity.Property(e => e.Extekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKP");
            entity.Property(e => e.Extekpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKPKORR");
            entity.Property(e => e.Extmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENGE");
            entity.Property(e => e.Extmenkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENKORR");
            entity.Property(e => e.Extvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKP");
            entity.Property(e => e.Extvkpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKPKORR");
            entity.Property(e => e.Faktorlag).HasColumnName("FAKTORLAG");
            entity.Property(e => e.Faktorums).HasColumnName("FAKTORUMS");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG02");
            entity.Property(e => e.GeFilId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GE_FIL_ID");
            entity.Property(e => e.HagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("HAGRST_ID");
            entity.Property(e => e.Intbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEK");
            entity.Property(e => e.Intbekeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEKEINZ");
            entity.Property(e => e.Intekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKP");
            entity.Property(e => e.Intekpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKPEINZ");
            entity.Property(e => e.Intvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKP");
            entity.Property(e => e.Intvkpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPEINZ");
            entity.Property(e => e.Intvkpnet)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPNET");
            entity.Property(e => e.Kassierid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KASSIERID");
            entity.Property(e => e.LFestpreis)
                .HasDefaultValue(true)
                .HasColumnName("lFESTPREIS");
            entity.Property(e => e.LFolgebew).HasColumnName("lFOLGEBEW");
            entity.Property(e => e.LLagerabs).HasColumnName("lLAGERABS");
            entity.Property(e => e.LLagerbew).HasColumnName("lLAGERBEW");
            entity.Property(e => e.LLagfehler).HasColumnName("lLAGFEHLER");
            entity.Property(e => e.LUmsatz).HasColumnName("lUMSATZ");
            entity.Property(e => e.Lagekbew)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEKBEW");
            entity.Property(e => e.Lagerabs)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERABS");
            entity.Property(e => e.Lagerbew)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERBEW");
            entity.Property(e => e.LagestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.LiefstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_IDB");
            entity.Property(e => e.MpgrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MPGRST_ID");
            entity.Property(e => e.Refmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("REFMENGE");
            entity.Property(e => e.SteustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("STEUST_ID");
            entity.Property(e => e.VaLieId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VA_LIE_ID");
            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");
            entity.Property(e => e.VtedstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VTEDST_ID");
            entity.Property(e => e.VtekstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VTEKST_ID");
            entity.Property(e => e.WagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("WAGRST_ID");

            entity.HasOne(d => d.Agrust).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.AgrustId)
                .HasConstraintName("Relation_258");

            entity.HasOne(d => d.Barcst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.BarcstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_265");

            entity.HasOne(d => d.BewdbwIdlNavigation).WithMany(p => p.InverseBewdbwIdlNavigation)
                .HasForeignKey(d => d.BewdbwIdl)
                .HasConstraintName("Relation_266");

            entity.HasOne(d => d.Bewkbw).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.BewkbwId)
                .HasConstraintName("Relation_255");

            entity.HasOne(d => d.Filist).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_264");

            entity.HasOne(d => d.GeFil).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.GeFilId)
                .HasConstraintName("Relation_269");

            entity.HasOne(d => d.Hagrst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.HagrstId)
                .HasConstraintName("Relation_259");

            entity.HasOne(d => d.Lagest).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.LagestId)
                .HasConstraintName("Relation_277");

            entity.HasOne(d => d.Liefst).WithMany(p => p.BewDbwLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_262");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.BewDbwLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_304");

            entity.HasOne(d => d.Mpgrst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.MpgrstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_261");

            entity.HasOne(d => d.Steust).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.SteustId)
                .HasConstraintName("Relation_267");

            entity.HasOne(d => d.VaLie).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.VaLieId)
                .HasConstraintName("Relation_280");

            entity.HasOne(d => d.Varist).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.VaristId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_272");

            entity.HasOne(d => d.Vtedst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.VtedstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_271");

            entity.HasOne(d => d.Vtekst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.VtekstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_263");

            entity.HasOne(d => d.Wagrst).WithMany(p => p.BewDbws)
                .HasForeignKey(d => d.WagrstId)
                .HasConstraintName("Relation_260");
        });

        modelBuilder.Entity<BewDte>(entity =>
        {
            entity.HasKey(e => e.BewdteId)
                .HasName("PRIMARY38")
                .IsClustered(false);

            entity.ToTable("BewDTE");

            entity.HasIndex(e => e.BarcstId, "BarcST");

            entity.HasIndex(e => e.BewdbwId, "BewDBW");

            entity.HasIndex(e => e.BewkbwId, "BewKBW");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.GeFilId, "GE_FIL");

            entity.HasIndex(e => e.LagestId, "LageST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.LiefstIdb, "LiefST0");

            entity.HasIndex(e => e.VaLieId, "VA_LIE");

            entity.HasIndex(e => e.VaristId, "VariST");

            entity.Property(e => e.BewdteId).HasColumnName("BEWDTE_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.BarcstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BARCST_ID");
            entity.Property(e => e.Bedienerid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEDIENERID");
            entity.Property(e => e.BewdbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWDBW_ID");
            entity.Property(e => e.BewkbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("BEWKBW_ID");
            entity.Property(e => e.Datum01).HasColumnName("DATUM01");
            entity.Property(e => e.Datum02).HasColumnName("DATUM02");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Extbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEK");
            entity.Property(e => e.Extbekkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTBEKKORR");
            entity.Property(e => e.Extekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKP");
            entity.Property(e => e.Extekpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTEKPKORR");
            entity.Property(e => e.Extmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENGE");
            entity.Property(e => e.Extmenkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENKORR");
            entity.Property(e => e.Extvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKP");
            entity.Property(e => e.Extvkpkorr)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTVKPKORR");
            entity.Property(e => e.Faktorlag).HasColumnName("FAKTORLAG");
            entity.Property(e => e.Faktorums).HasColumnName("FAKTORUMS");
            entity.Property(e => e.FilistId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FILIST_ID");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG02");
            entity.Property(e => e.GeFilId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GE_FIL_ID");
            entity.Property(e => e.Intbek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEK");
            entity.Property(e => e.Intbekeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTBEKEINZ");
            entity.Property(e => e.Intekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKP");
            entity.Property(e => e.Intekpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTEKPEINZ");
            entity.Property(e => e.Intvkp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKP");
            entity.Property(e => e.Intvkpeinz)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPEINZ");
            entity.Property(e => e.Intvkpnet)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("INTVKPNET");
            entity.Property(e => e.Kassierid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KASSIERID");
            entity.Property(e => e.LFestpreis)
                .HasDefaultValue(true)
                .HasColumnName("lFESTPREIS");
            entity.Property(e => e.LFolgebew).HasColumnName("lFOLGEBEW");
            entity.Property(e => e.LLagerabs).HasColumnName("lLAGERABS");
            entity.Property(e => e.LLagerbew).HasColumnName("lLAGERBEW");
            entity.Property(e => e.LLagfehler).HasColumnName("lLAGFEHLER");
            entity.Property(e => e.LUmsatz).HasColumnName("lUMSATZ");
            entity.Property(e => e.LUnterdr).HasColumnName("lUNTERDR");
            entity.Property(e => e.Lagerabs)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERABS");
            entity.Property(e => e.Lagerbew)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LAGERBEW");
            entity.Property(e => e.LagestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.LiefstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_IDB");
            entity.Property(e => e.Num01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM01");
            entity.Property(e => e.Num02)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM02");
            entity.Property(e => e.Num03)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM03");
            entity.Property(e => e.Num04)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM04");
            entity.Property(e => e.Num05)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM05");
            entity.Property(e => e.Num06)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM06");
            entity.Property(e => e.Num07)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM07");
            entity.Property(e => e.Num08)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM08");
            entity.Property(e => e.Num09)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM09");
            entity.Property(e => e.Num10)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM10");
            entity.Property(e => e.Refmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("REFMENGE");
            entity.Property(e => e.VaLieId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VA_LIE_ID");
            entity.Property(e => e.VaristId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VARIST_ID");
            entity.Property(e => e.Vkstk00)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK00");
            entity.Property(e => e.Vkstk01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK01");
            entity.Property(e => e.Vkstk02)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK02");
            entity.Property(e => e.Vkstk03)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK03");
            entity.Property(e => e.Vkstk04)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK04");
            entity.Property(e => e.Vkstk05)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK05");
            entity.Property(e => e.Vkstk06)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK06");
            entity.Property(e => e.Vkstk07)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK07");
            entity.Property(e => e.Vkstk08)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK08");
            entity.Property(e => e.Vkstk09)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK09");
            entity.Property(e => e.Vkstk10)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK10");
            entity.Property(e => e.Vkstk11)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK11");
            entity.Property(e => e.Vkstk12)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VKSTK12");

            entity.HasOne(d => d.Barcst).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.BarcstId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Relation_288");

            entity.HasOne(d => d.Bewdbw).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.BewdbwId)
                .HasConstraintName("Relation_308");

            entity.HasOne(d => d.Bewkbw).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.BewkbwId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_283");

            entity.HasOne(d => d.Filist).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_281");

            entity.HasOne(d => d.GeFil).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.GeFilId)
                .HasConstraintName("Relation_285");

            entity.HasOne(d => d.Lagest).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.LagestId)
                .HasConstraintName("Relation_286");

            entity.HasOne(d => d.Liefst).WithMany(p => p.BewDteLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_284");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.BewDteLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_305");

            entity.HasOne(d => d.VaLie).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.VaLieId)
                .HasConstraintName("Relation_287");

            entity.HasOne(d => d.Varist).WithMany(p => p.BewDtes)
                .HasForeignKey(d => d.VaristId)
                .HasConstraintName("Relation_282");
        });

        modelBuilder.Entity<BewKbw>(entity =>
        {
            entity.HasKey(e => e.BewkbwId)
                .HasName("PRIMARY34")
                .IsClustered(false);

            entity.ToTable("BewKBW");

            entity.HasIndex(e => e.BewastId, "BewAST");

            entity.HasIndex(e => e.Datzeit, "DATZEIT");

            entity.HasIndex(e => e.FaktbwId, "FaktBW");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.GeFilId, "GE_FIL");

            entity.HasIndex(e => e.KundstId, "KundST");

            entity.HasIndex(e => e.LagestId, "LageST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.LiefstIdb, "LiefST0");

            entity.HasIndex(e => e.RechbwId, "RechBW");

            entity.HasIndex(e => e.LIntemp, "lINTEMP");

            entity.Property(e => e.BewkbwId).HasColumnName("BEWKBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bearbstat)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("BEARBSTAT");
            entity.Property(e => e.Bedienerid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEDIENERID");
            entity.Property(e => e.BewastId).HasColumnName("BEWAST_ID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Datbuchung)
                .HasColumnType("datetime")
                .HasColumnName("DATBUCHUNG");
            entity.Property(e => e.Datorgdok).HasColumnName("DATORGDOK");
            entity.Property(e => e.Datum01).HasColumnName("DATUM01");
            entity.Property(e => e.Datum02).HasColumnName("DATUM02");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Datzeit01)
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT01");
            entity.Property(e => e.Datzeit02)
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT02");
            entity.Property(e => e.Extid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EXTID");
            entity.Property(e => e.FaktbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FAKTBW_ID");
            entity.Property(e => e.FilistId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("FILIST_ID");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG02");
            entity.Property(e => e.Flag03)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG03");
            entity.Property(e => e.Flag04)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG04");
            entity.Property(e => e.Flag05)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FLAG05");
            entity.Property(e => e.GeFilId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GE_FIL_ID");
            entity.Property(e => e.Kassierid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KASSIERID");
            entity.Property(e => e.KundstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("KUNDST_ID");
            entity.Property(e => e.LErl0meng).HasColumnName("lERL0MENG");
            entity.Property(e => e.LFolgebew).HasColumnName("lFOLGEBEW");
            entity.Property(e => e.LFolgegebu).HasColumnName("lFOLGEGEBU");
            entity.Property(e => e.LIntemp).HasColumnName("lINTEMP");
            entity.Property(e => e.LVlieinf).HasColumnName("lVLIEINF");
            entity.Property(e => e.LagestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.LiefstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIEFST_IDB");
            entity.Property(e => e.Num01)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM01");
            entity.Property(e => e.Num02)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM02");
            entity.Property(e => e.Num03)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM03");
            entity.Property(e => e.Num04)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM04");
            entity.Property(e => e.Num05)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM05");
            entity.Property(e => e.Num06)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM06");
            entity.Property(e => e.Num07)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM07");
            entity.Property(e => e.Num08)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM08");
            entity.Property(e => e.Num09)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM09");
            entity.Property(e => e.Num10)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("NUM10");
            entity.Property(e => e.RechbwId).HasColumnName("RECHBW_ID");

            entity.HasOne(d => d.Bewast).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.BewastId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_256");

            entity.HasOne(d => d.Faktbw).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.FaktbwId)
                .HasConstraintName("Relation_295");

            entity.HasOne(d => d.Filist).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_270");

            entity.HasOne(d => d.GeFil).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.GeFilId)
                .HasConstraintName("Relation_268");

            entity.HasOne(d => d.Kundst).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.KundstId)
                .HasConstraintName("Relation_293");

            entity.HasOne(d => d.Lagest).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.LagestId)
                .HasConstraintName("Relation_279");

            entity.HasOne(d => d.Liefst).WithMany(p => p.BewKbwLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_278");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.BewKbwLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_306");

            entity.HasOne(d => d.Rechbw).WithMany(p => p.BewKbws)
                .HasForeignKey(d => d.RechbwId)
                .HasConstraintName("Relation_310");
        });

        modelBuilder.Entity<BewVer>(entity =>
        {
            entity.HasKey(e => e.BlockId).HasName("PK__BewVer__144215F12F7F1A0D");

            entity.ToTable("BewVer");

            entity.Property(e => e.BlockId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnlDat).HasColumnType("datetime");
            entity.Property(e => e.Beschreibung)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Daten)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Filiale)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<BewaSy>(entity =>
        {
            entity.HasKey(e => e.BewasyId)
                .HasName("PRIMARY39")
                .IsClustered(false);

            entity.ToTable("BewaSY");

            entity.Property(e => e.BewasyId)
                .ValueGeneratedNever()
                .HasColumnName("BEWASY_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
        });

        modelBuilder.Entity<Bewimp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bewimp__3214EC07CC7D3358");

            entity.ToTable("Bewimp");

            entity.Property(e => e.BlockId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("block_id");
            entity.Property(e => e.Datum01).HasColumnName("datum01");
            entity.Property(e => e.Datum02).HasColumnName("datum02");
            entity.Property(e => e.Datum03).HasColumnName("datum03");
            entity.Property(e => e.Datum04).HasColumnName("datum04");
            entity.Property(e => e.Datum05).HasColumnName("datum05");
            entity.Property(e => e.Datzeit01)
                .HasColumnType("datetime")
                .HasColumnName("datzeit01");
            entity.Property(e => e.Datzeit02)
                .HasColumnType("datetime")
                .HasColumnName("datzeit02");
            entity.Property(e => e.Datzeit03)
                .HasColumnType("datetime")
                .HasColumnName("datzeit03");
            entity.Property(e => e.Datzeit04)
                .HasColumnType("datetime")
                .HasColumnName("datzeit04");
            entity.Property(e => e.Datzeit05)
                .HasColumnType("datetime")
                .HasColumnName("datzeit05");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag02");
            entity.Property(e => e.Flag03)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag03");
            entity.Property(e => e.Flag04)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag04");
            entity.Property(e => e.Flag05)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag05");
            entity.Property(e => e.Kennz)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("kennz");
            entity.Property(e => e.Num01)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num01");
            entity.Property(e => e.Num02)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num02");
            entity.Property(e => e.Num03)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num03");
            entity.Property(e => e.Num04)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num04");
            entity.Property(e => e.Num05)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num05");
            entity.Property(e => e.Num06)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num06");
            entity.Property(e => e.Num07)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num07");
            entity.Property(e => e.Num08)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num08");
            entity.Property(e => e.Num09)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num09");
            entity.Property(e => e.Num10)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num10");
            entity.Property(e => e.Num11)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num11");
            entity.Property(e => e.Num12)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num12");
            entity.Property(e => e.Num13)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num13");
            entity.Property(e => e.Num14)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num14");
            entity.Property(e => e.Num15)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num15");
            entity.Property(e => e.Num16)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num16");
            entity.Property(e => e.Num17)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num17");
            entity.Property(e => e.Num18)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num18");
            entity.Property(e => e.Num19)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num19");
            entity.Property(e => e.Num20)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("num20");
            entity.Property(e => e.Satzart)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("satzart");
            entity.Property(e => e.Text01)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text01");
            entity.Property(e => e.Text02)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text02");
            entity.Property(e => e.Text03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text03");
            entity.Property(e => e.Text04)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text04");
            entity.Property(e => e.Text05)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text05");
        });

        modelBuilder.Entity<BewimpTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BewimpTemp");

            entity.Property(e => e.BlockId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("block_id");
            entity.Property(e => e.Datum01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datum01");
            entity.Property(e => e.Datum02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datum02");
            entity.Property(e => e.Datum03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datum03");
            entity.Property(e => e.Datum04)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datum04");
            entity.Property(e => e.Datum05)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datum05");
            entity.Property(e => e.Datzeit01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datzeit01");
            entity.Property(e => e.Datzeit02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datzeit02");
            entity.Property(e => e.Datzeit03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datzeit03");
            entity.Property(e => e.Datzeit04)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datzeit04");
            entity.Property(e => e.Datzeit05)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datzeit05");
            entity.Property(e => e.Flag01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag01");
            entity.Property(e => e.Flag02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag02");
            entity.Property(e => e.Flag03)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag03");
            entity.Property(e => e.Flag04)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag04");
            entity.Property(e => e.Flag05)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flag05");
            entity.Property(e => e.Kennz)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("kennz");
            entity.Property(e => e.Num01)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num01");
            entity.Property(e => e.Num02)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num02");
            entity.Property(e => e.Num03)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num03");
            entity.Property(e => e.Num04)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num04");
            entity.Property(e => e.Num05)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num05");
            entity.Property(e => e.Num06)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num06");
            entity.Property(e => e.Num07)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num07");
            entity.Property(e => e.Num08)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num08");
            entity.Property(e => e.Num09)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num09");
            entity.Property(e => e.Num10)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num10");
            entity.Property(e => e.Num11)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num11");
            entity.Property(e => e.Num12)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num12");
            entity.Property(e => e.Num13)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num13");
            entity.Property(e => e.Num14)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num14");
            entity.Property(e => e.Num15)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num15");
            entity.Property(e => e.Num16)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num16");
            entity.Property(e => e.Num17)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num17");
            entity.Property(e => e.Num18)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num18");
            entity.Property(e => e.Num19)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num19");
            entity.Property(e => e.Num20)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("num20");
            entity.Property(e => e.Satzart)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("satzart");
            entity.Property(e => e.Text01)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text01");
            entity.Property(e => e.Text02)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text02");
            entity.Property(e => e.Text03)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text03");
            entity.Property(e => e.Text04)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text04");
            entity.Property(e => e.Text05)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("text05");
        });

        modelBuilder.Entity<Errorlog>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID4")
                .IsClustered(false);

            entity.ToTable("errorlog");

            entity.HasIndex(e => e.Tdatetime, "TDATETIME");

            entity.Property(e => e.Iid)
                .ValueGeneratedNever()
                .HasColumnName("IID");
            entity.Property(e => e.Caerror1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CAERROR1");
            entity.Property(e => e.Caerror4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CAERROR4");
            entity.Property(e => e.Caerror5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CAERROR5");
            entity.Property(e => e.Caerror6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAERROR6");
            entity.Property(e => e.Caerror7)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CAERROR7");
            entity.Property(e => e.Cuserid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSERID");
            entity.Property(e => e.Maerror2)
                .IsUnicode(false)
                .HasColumnName("MAERROR2");
            entity.Property(e => e.Maerror3)
                .IsUnicode(false)
                .HasColumnName("MAERROR3");
            entity.Property(e => e.Mcallchain)
                .IsUnicode(false)
                .HasColumnName("MCALLCHAIN");
            entity.Property(e => e.Menviron)
                .IsUnicode(false)
                .HasColumnName("MENVIRON");
            entity.Property(e => e.Tdatetime)
                .HasColumnType("datetime")
                .HasColumnName("TDATETIME");
        });

        modelBuilder.Entity<ErzeSt>(entity =>
        {
            entity.HasKey(e => e.ErzestId)
                .HasName("PRIMARY46")
                .IsClustered(false);

            entity.ToTable("ErzeST");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.Property(e => e.ErzestId).HasColumnName("ERZEST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Sollspanne)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("SOLLSPANNE");
        });

        modelBuilder.Entity<EtiaSt>(entity =>
        {
            entity.HasKey(e => e.EtiastId)
                .HasName("PRIMARY41")
                .IsClustered(false);

            entity.ToTable("EtiaST");

            entity.Property(e => e.EtiastId)
                .ValueGeneratedNever()
                .HasColumnName("ETIAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Druckparam)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DRUCKPARAM");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.LStdeinzdr).HasColumnName("lSTDEINZDR");
        });

        modelBuilder.Entity<ExpoBw>(entity =>
        {
            entity.HasKey(e => e.ExpobwId)
                .HasName("PRIMARY21")
                .IsClustered(false);

            entity.ToTable("ExpoBW");

            entity.HasIndex(e => e.Exportflag, "EXPORTFLAG");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.GegrstId, "GegrST");

            entity.HasIndex(e => e.Quelle, "QUELLE");

            entity.Property(e => e.ExpobwId)
                .ValueGeneratedNever()
                .HasColumnName("EXPOBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Exportflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EXPORTFLAG");
            entity.Property(e => e.Extraparam)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXTRAPARAM");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.GegrstId).HasColumnName("GEGRST_ID");
            entity.Property(e => e.Menge)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("MENGE");
            entity.Property(e => e.QuellId).HasColumnName("QUELL_ID");
            entity.Property(e => e.Quelle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("QUELLE");

            entity.HasOne(d => d.Filist).WithMany(p => p.ExpoBws)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_2310");

            entity.HasOne(d => d.Gegrst).WithMany(p => p.ExpoBws)
                .HasForeignKey(d => d.GegrstId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_232");
        });

        modelBuilder.Entity<FaktBw>(entity =>
        {
            entity.HasKey(e => e.FaktbwId)
                .HasName("PRIMARY44")
                .IsClustered(false);

            entity.ToTable("FaktBW");

            entity.HasIndex(e => e.Datzeit, "DATZEIT");

            entity.HasIndex(e => e.Faktnr, "FAKTNR");

            entity.HasIndex(e => e.KundstId, "KundST");

            entity.Property(e => e.FaktbwId)
                .ValueGeneratedNever()
                .HasColumnName("FAKTBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bewkbisdat).HasColumnName("BEWKBISDAT");
            entity.Property(e => e.Datzeit)
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.Faktnr).HasColumnName("FAKTNR");
            entity.Property(e => e.KundstId).HasColumnName("KUNDST_ID");

            entity.HasOne(d => d.Kundst).WithMany(p => p.FaktBws)
                .HasForeignKey(d => d.KundstId)
                .HasConstraintName("Relation_296");
        });

        modelBuilder.Entity<FigrSt>(entity =>
        {
            entity.HasKey(e => e.FigrstId)
                .HasName("PRIMARY9")
                .IsClustered(false);

            entity.ToTable("FigrST");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.Property(e => e.FigrstId)
                .ValueGeneratedNever()
                .HasColumnName("FIGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
        });

        modelBuilder.Entity<FiliSt>(entity =>
        {
            entity.HasKey(e => e.FilistId)
                .HasName("PRIMARY2")
                .IsClustered(false);

            entity.ToTable("FiliST");

            entity.HasIndex(e => e.FigrstId, "FigrST");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.HasIndex(e => e.LagestIdz, "LageST");

            entity.HasIndex(e => e.LagestIda, "LageST0");

            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anrede)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANREDE");
            entity.Property(e => e.Anschrift1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT1");
            entity.Property(e => e.Anschrift2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT2");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FigrstId).HasColumnName("FIGRST_ID");
            entity.Property(e => e.Ghinaktiv)
                .HasDefaultValue(false)
                .HasColumnName("GHINAKTIV");
            entity.Property(e => e.Ghivksperr)
                .HasDefaultValue(false)
                .HasColumnName("GHIVKSPERR");
            entity.Property(e => e.Koebuclpw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KOEBUCLPW");
            entity.Property(e => e.Koebuvknr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KOEBUVKNR");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.LagestIda).HasColumnName("LAGEST_IDA");
            entity.Property(e => e.LagestIdz).HasColumnName("LAGEST_IDZ");
            entity.Property(e => e.Land)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("LAND");
            entity.Property(e => e.Nachname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("NACHNAME");
            entity.Property(e => e.Nielsfilnr)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("NIELSFILNR");
            entity.Property(e => e.Nosapanka)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOSAPANKA");
            entity.Property(e => e.Ort)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ORT");
            entity.Property(e => e.Plz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLZ");
            entity.Property(e => e.Telefon1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON3");
            entity.Property(e => e.Uidnr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIDNR");
            entity.Property(e => e.Url)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Vorname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("VORNAME");
            entity.Property(e => e.Woffentage)
                .HasDefaultValue(6m)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("WOFFENTAGE");

            entity.HasOne(d => d.Figrst).WithMany(p => p.FiliSts)
                .HasForeignKey(d => d.FigrstId)
                .HasConstraintName("Relation_222");

            entity.HasOne(d => d.LagestIdaNavigation).WithMany(p => p.FiliStLagestIdaNavigations)
                .HasForeignKey(d => d.LagestIda)
                .HasConstraintName("Relation_276");

            entity.HasOne(d => d.LagestIdzNavigation).WithMany(p => p.FiliStLagestIdzNavigations)
                .HasForeignKey(d => d.LagestIdz)
                .HasConstraintName("Relation_275");
        });

        modelBuilder.Entity<Firmendaten>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Firmenda__3214EC0780091325");

            entity.ToTable("Firmendaten");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirmendatenAbsenderZeile).HasColumnType("text");
            entity.Property(e => e.FirmendatenRgRepoTitel3).HasColumnType("text");
            entity.Property(e => e.FirmendatenRgfußZeile1)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile1");
            entity.Property(e => e.FirmendatenRgfußZeile2)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile2");
            entity.Property(e => e.FirmendatenRgfußZeile3)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile3");
            entity.Property(e => e.FirmendatenRgfußZeile4)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile4");
            entity.Property(e => e.FirmendatenRgfußZeile5)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile5");
            entity.Property(e => e.FirmendatenRgfußZeile6)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGFußZeile6");
            entity.Property(e => e.FirmendatenRgkopfZeile1)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGKopfZeile1");
            entity.Property(e => e.FirmendatenRgkopfZeile2)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGKopfZeile2");
            entity.Property(e => e.FirmendatenRgkopfZeile3)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGKopfZeile3");
            entity.Property(e => e.FirmendatenRgkopfZeile4)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGKopfZeile4");
            entity.Property(e => e.FirmendatenRgkopfZeile5)
                .HasColumnType("text")
                .HasColumnName("FirmendatenRGKopfZeile5");
        });

        modelBuilder.Entity<GeFil>(entity =>
        {
            entity.HasKey(e => e.GeFilId)
                .HasName("PRIMARY20")
                .IsClustered(false);

            entity.ToTable("GE_FIL");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.GerastId, "GeraST");

            entity.Property(e => e.GeFilId).HasColumnName("GE_FIL_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Beschr)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BESCHR");
            entity.Property(e => e.BewastIko).HasColumnName("BEWAST_IKO");
            entity.Property(e => e.BewastLko).HasColumnName("BEWAST_LKO");
            entity.Property(e => e.BewastVko).HasColumnName("BEWAST_VKO");
            entity.Property(e => e.BewastVks).HasColumnName("BEWAST_VKS");
            entity.Property(e => e.BidIkond).HasColumnName("BID_IKOND");
            entity.Property(e => e.BidIkonn).HasColumnName("BID_IKONN");
            entity.Property(e => e.BidIkons).HasColumnName("BID_IKONS");
            entity.Property(e => e.BidLkond).HasColumnName("BID_LKOND");
            entity.Property(e => e.BidLkonn).HasColumnName("BID_LKONN");
            entity.Property(e => e.BidLkons).HasColumnName("BID_LKONS");
            entity.Property(e => e.BidVkokd).HasColumnName("BID_VKOKD");
            entity.Property(e => e.BidVkokn).HasColumnName("BID_VKOKN");
            entity.Property(e => e.BidVkoks).HasColumnName("BID_VKOKS");
            entity.Property(e => e.BidVkond).HasColumnName("BID_VKOND");
            entity.Property(e => e.BidVkonn).HasColumnName("BID_VKONN");
            entity.Property(e => e.BidVkons).HasColumnName("BID_VKONS");
            entity.Property(e => e.BidVksnd).HasColumnName("BID_VKSND");
            entity.Property(e => e.BidVksnn).HasColumnName("BID_VKSNN");
            entity.Property(e => e.BidVksns).HasColumnName("BID_VKSNS");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.GerastId).HasColumnName("GERAST_ID");
            entity.Property(e => e.LEmpfangen).HasColumnName("lEMPFANGEN");
            entity.Property(e => e.LSenden).HasColumnName("lSENDEN");

            entity.HasOne(d => d.Filist).WithMany(p => p.GeFils)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_2300");

            entity.HasOne(d => d.Gerast).WithMany(p => p.GeFils)
                .HasForeignKey(d => d.GerastId)
                .HasConstraintName("Relation_229");
        });

        modelBuilder.Entity<GegrSy>(entity =>
        {
            entity.HasKey(e => e.GegrsyId)
                .HasName("PRIMARY40")
                .IsClustered(false);

            entity.ToTable("GegrSY");

            entity.Property(e => e.GegrsyId)
                .ValueGeneratedNever()
                .HasColumnName("GEGRSY_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
        });

        modelBuilder.Entity<Gegrst>(entity =>
        {
            entity.HasKey(e => e.GegrstId)
                .HasName("PRIMARY18")
                .IsClustered(false);

            entity.ToTable("gegrst");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.GegrsyId, "GegrSY");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.Property(e => e.GegrstId).HasColumnName("GEGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Flaglist)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FLAGLIST");
            entity.Property(e => e.GegrsyId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("GEGRSY_ID");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.LErlgegrbc).HasColumnName("lERLGEGRBC");
            entity.Property(e => e.Lsendl).HasColumnName("LSENDL");
            entity.Property(e => e.Lsendn).HasColumnName("LSENDN");
            entity.Property(e => e.Lsends).HasColumnName("LSENDS");
            entity.Property(e => e.Lsendu).HasColumnName("LSENDU");

            entity.HasOne(d => d.Gegrsy).WithMany(p => p.Gegrsts)
                .HasForeignKey(d => d.GegrsyId)
                .HasConstraintName("Relation_290");
        });

        modelBuilder.Entity<GeraSt>(entity =>
        {
            entity.HasKey(e => e.GerastId)
                .HasName("PRIMARY19")
                .IsClustered(false);

            entity.ToTable("GeraST");

            entity.HasIndex(e => e.GegrstId, "GEGRST_ID");

            entity.Property(e => e.GerastId).HasColumnName("GERAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.GegrstId).HasColumnName("GEGRST_ID");
            entity.Property(e => e.Klasse)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KLASSE");
            entity.Property(e => e.Klassenlib)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("KLASSENLIB");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");

            entity.HasOne(d => d.Gegrst).WithMany(p => p.GeraSts)
                .HasForeignKey(d => d.GegrstId)
                .HasConstraintName("Relation_2280");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID3")
                .IsClustered(false);

            entity.ToTable("groups");

            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Cgrpdesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CGRPDESC");
            entity.Property(e => e.Ilastupdid).HasColumnName("ILASTUPDID");
            entity.Property(e => e.Tlastupd)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TLASTUPD");
        });

        modelBuilder.Entity<GrupCv>(entity =>
        {
            entity.HasKey(e => e.GrupcvId)
                .HasName("PRIMARY30")
                .IsClustered(false);

            entity.ToTable("GrupCV");

            entity.HasIndex(e => e.AgrustId, "AgruST");

            entity.HasIndex(e => e.Cvgruppe, "CVGRUPPE");

            entity.HasIndex(e => e.HagrstId, "HagrST");

            entity.HasIndex(e => e.LirestId, "LireST");

            entity.HasIndex(e => e.WagrstId, "WagrST");

            entity.Property(e => e.GrupcvId).HasColumnName("GRUPCV_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.AgrustId).HasColumnName("AGRUST_ID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Cvgruppe)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CVGRUPPE");
            entity.Property(e => e.HagrstId).HasColumnName("HAGRST_ID");
            entity.Property(e => e.LirestId).HasColumnName("LIREST_ID");
            entity.Property(e => e.WagrstId).HasColumnName("WAGRST_ID");

            entity.HasOne(d => d.Agrust).WithMany(p => p.GrupCvs)
                .HasForeignKey(d => d.AgrustId)
                .HasConstraintName("Relation_252");

            entity.HasOne(d => d.Hagrst).WithMany(p => p.GrupCvs)
                .HasForeignKey(d => d.HagrstId)
                .HasConstraintName("Relation_249");

            entity.HasOne(d => d.Lirest).WithMany(p => p.GrupCvs)
                .HasForeignKey(d => d.LirestId)
                .HasConstraintName("Relation_253");

            entity.HasOne(d => d.Wagrst).WithMany(p => p.GrupCvs)
                .HasForeignKey(d => d.WagrstId)
                .HasConstraintName("Relation_250");
        });

        modelBuilder.Entity<HagrSt>(entity =>
        {
            entity.HasKey(e => e.HagrstId)
                .HasName("PRIMARY5")
                .IsClustered(false);

            entity.ToTable("HagrST");

            entity.HasIndex(e => e.Hagrnr, "HAGRNR");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.Property(e => e.HagrstId).HasColumnName("HAGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Hagrnr)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("HAGRNR");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.WagrstNrm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .HasColumnName("WAGRST_NRM");
            entity.Property(e => e.WagrstNrx)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("ZZZZZZ")
                .HasColumnName("WAGRST_NRX");
        });

        modelBuilder.Entity<Id>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("id");

            entity.HasIndex(e => e.Keyname, "KEYNAME");

            entity.Property(e => e.Incrementprocedure)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("INCREMENTPROCEDURE");
            entity.Property(e => e.Keyname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KEYNAME");
            entity.Property(e => e.Maxlength)
                .HasDefaultValue(11)
                .HasColumnName("MAXLENGTH");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("I")
                .HasColumnName("TYPE");
            entity.Property(e => e.Value)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("          1")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<KaMpst>(entity =>
        {
            entity.HasKey(e => e.KampstId)
                .HasName("PRIMARY26")
                .IsClustered(false);

            entity.ToTable("KaMPST");

            entity.Property(e => e.KampstId)
                .ValueGeneratedNever()
                .HasColumnName("KAMPST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Kasatznr)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("KASATZNR");
        });

        modelBuilder.Entity<KaPfSt>(entity =>
        {
            entity.HasKey(e => e.KapfstId)
                .HasName("PRIMARY4")
                .IsClustered(false);

            entity.ToTable("KaPfST");

            entity.HasIndex(e => e.Kasatznr, "KASATZNR");

            entity.Property(e => e.KapfstId)
                .ValueGeneratedNever()
                .HasColumnName("KAPFST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Kasatznr)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("KASATZNR");
        });

        modelBuilder.Entity<KawgSt>(entity =>
        {
            entity.HasKey(e => e.KawgstId)
                .HasName("PRIMARY23")
                .IsClustered(false);

            entity.ToTable("KawgST");

            entity.Property(e => e.KawgstId)
                .ValueGeneratedNever()
                .HasColumnName("KAWGST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Kasatznr)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("KASATZNR");
        });

        modelBuilder.Entity<KunAst>(entity =>
        {
            entity.HasKey(e => e.KunastId)
                .HasName("PRIMARY43")
                .IsClustered(false);

            entity.ToTable("KunAST");

            entity.HasIndex(e => e.Kuerzel, "Kuerzel");

            entity.Property(e => e.KunastId).HasColumnName("KUNAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Preisebene)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("PREISEBENE");
        });

        modelBuilder.Entity<KundSt>(entity =>
        {
            entity.HasKey(e => e.KundstId)
                .HasName("PRIMARY42")
                .IsClustered(false);

            entity.ToTable("KundST");

            entity.HasIndex(e => e.Kabezeichn, "Kabezeichn");

            entity.HasIndex(e => e.KunastId, "KunAST");

            entity.HasIndex(e => e.Kundnr, "Kundnr");

            entity.HasIndex(e => e.Matchcode, "Matchcode");

            entity.HasIndex(e => e.Nachname, "Nachname");

            entity.HasIndex(e => e.Vorname, "Vorname");

            entity.Property(e => e.KundstId).HasColumnName("KUNDST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Anrede)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANREDE");
            entity.Property(e => e.Anschrift1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT1");
            entity.Property(e => e.Anschrift2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT2");
            entity.Property(e => e.Bank)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BANK");
            entity.Property(e => e.Blz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BLZ");
            entity.Property(e => e.Datablauf).HasColumnName("DATABLAUF");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gebdatum).HasColumnName("GEBDATUM");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.Kto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KTO");
            entity.Property(e => e.KunastId).HasColumnName("KUNAST_ID");
            entity.Property(e => e.Kundnr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNDNR");
            entity.Property(e => e.Land)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("LAND");
            entity.Property(e => e.Matchcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATCHCODE");
            entity.Property(e => e.Nachname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("NACHNAME");
            entity.Property(e => e.Ort)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ORT");
            entity.Property(e => e.Plz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLZ");
            entity.Property(e => e.Preisebene)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("PREISEBENE");
            entity.Property(e => e.Sperrlimit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("SPERRLIMIT");
            entity.Property(e => e.Telefon1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON3");
            entity.Property(e => e.Titel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TITEL");
            entity.Property(e => e.Uidnr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIDNR");
            entity.Property(e => e.Url)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Vorname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("VORNAME");

            entity.HasOne(d => d.Kunast).WithMany(p => p.KundSts)
                .HasForeignKey(d => d.KunastId)
                .HasConstraintName("Relation_292");
        });

        modelBuilder.Entity<LageSt>(entity =>
        {
            entity.HasKey(e => e.LagestId)
                .HasName("PRIMARY36")
                .IsClustered(false);

            entity.ToTable("LageST");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.Property(e => e.LagestId)
                .ValueGeneratedNever()
                .HasColumnName("LAGEST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");

            entity.HasOne(d => d.Filist).WithMany(p => p.LageSts)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_274");
        });

        modelBuilder.Entity<LevoSy>(entity =>
        {
            entity.HasKey(e => e.LevosyId)
                .HasName("PRIMARY37")
                .IsClustered(false);

            entity.ToTable("LevoSY");

            entity.Property(e => e.LevosyId)
                .ValueGeneratedNever()
                .HasColumnName("LEVOSY_ID");
            entity.Property(e => e.Dbversion)
                .HasDefaultValue(100000m)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("DBVERSION");
            entity.Property(e => e.Faktnr)
                .HasDefaultValue(1)
                .HasColumnName("FAKTNR");
        });

        modelBuilder.Entity<LiFil>(entity =>
        {
            entity.HasKey(e => e.LiFilId)
                .HasName("PRIMARY45")
                .IsClustered(false);

            entity.ToTable("LI_FIL");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.Property(e => e.LiFilId).HasColumnName("LI_FIL_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Kundennr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNDENNR");
            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");

            entity.HasOne(d => d.Filist).WithMany(p => p.LiFils)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_302");

            entity.HasOne(d => d.Liefst).WithMany(p => p.LiFils)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_301");
        });

        modelBuilder.Entity<LiefCv>(entity =>
        {
            entity.HasKey(e => e.LiefcvId)
                .HasName("PRIMARY29")
                .IsClustered(false);

            entity.ToTable("LiefCV");

            entity.HasIndex(e => e.Cvliefnr, "CVLIEFNR");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.LirestId, "LireST");

            entity.Property(e => e.LiefcvId).HasColumnName("LIEFCV_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Cvliefnr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CVLIEFNR");
            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");
            entity.Property(e => e.LirestId).HasColumnName("LIREST_ID");

            entity.HasOne(d => d.Liefst).WithMany(p => p.LiefCvs)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_248");

            entity.HasOne(d => d.Lirest).WithMany(p => p.LiefCvs)
                .HasForeignKey(d => d.LirestId)
                .HasConstraintName("Relation_247");
        });

        modelBuilder.Entity<LiefSt>(entity =>
        {
            entity.HasKey(e => e.LiefstId)
                .HasName("PRIMARY13")
                .IsClustered(false);

            entity.ToTable("LiefST");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.HasIndex(e => e.Liefnr, "LIEFNR");

            entity.HasIndex(e => e.LirestId, "LireST");

            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Anrede)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ANREDE");
            entity.Property(e => e.Anschrift1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT1");
            entity.Property(e => e.Anschrift2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ANSCHRIFT2");
            entity.Property(e => e.Bank)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BANK");
            entity.Property(e => e.Bestelltag)
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("BESTELLTAG");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Bic)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("BIC");
            entity.Property(e => e.Blz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BLZ");
            entity.Property(e => e.Dataexchid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATAEXCHID");
            entity.Property(e => e.Ekfaktor)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("EKFaktor");
            entity.Property(e => e.Ekfw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EKFW");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Iban)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("IBAN");
            entity.Property(e => e.Islandcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ISLANDCODE");
            entity.Property(e => e.Kto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KTO");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Kundennr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNDENNR");
            entity.Property(e => e.LExpoverk)
                .HasDefaultValue(false)
                .HasColumnName("lEXPOVERK");
            entity.Property(e => e.LIsmeldung)
                .HasDefaultValue(false)
                .HasColumnName("lISMELDUNG");
            entity.Property(e => e.Land)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("LAND");
            entity.Property(e => e.Liefnr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("LIEFNR");
            entity.Property(e => e.LirestId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LIREST_ID");
            entity.Property(e => e.Llanrbarc)
                .HasDefaultValue(false)
                .HasColumnName("LLANRBARC");
            entity.Property(e => e.Nachname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("NACHNAME");
            entity.Property(e => e.Ort)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ORT");
            entity.Property(e => e.Plz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLZ");
            entity.Property(e => e.Prldatei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRLDATEI");
            entity.Property(e => e.Rabattsatz)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("RABATTSATZ");
            entity.Property(e => e.Telefon1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TELEFON3");
            entity.Property(e => e.Url)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Vorname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("VORNAME");

            entity.HasOne(d => d.Lirest).WithMany(p => p.LiefSts)
                .HasForeignKey(d => d.LirestId)
                .HasConstraintName("Relation_2400");
        });

        modelBuilder.Entity<LireSt>(entity =>
        {
            entity.HasKey(e => e.LirestId)
                .HasName("PRIMARY27")
                .IsClustered(false);

            entity.ToTable("LireST");

            entity.Property(e => e.LirestId).HasColumnName("LIREST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Klasse)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KLASSE");
            entity.Property(e => e.Klassenlib)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("KLASSENLIB");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
        });

        modelBuilder.Entity<Lstdbw>(entity =>
        {
            entity.HasKey(e => e.LstdbwId)
                .HasName("PRIMARY52")
                .IsClustered(false);

            entity.ToTable("LSTDBW");

            entity.HasIndex(e => e.LstkbwId, "LSTKBW");

            entity.HasIndex(e => e.VaristId, "VariST");

            entity.Property(e => e.LstdbwId).HasColumnName("LSTDBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Extmenge)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EXTMENGE");
            entity.Property(e => e.LstkbwId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LSTKBW_ID");
            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");

            entity.HasOne(d => d.Lstkbw).WithMany(p => p.Lstdbws)
                .HasForeignKey(d => d.LstkbwId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_321");

            entity.HasOne(d => d.Varist).WithMany(p => p.Lstdbws)
                .HasForeignKey(d => d.VaristId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_322");
        });

        modelBuilder.Entity<Lstkbw>(entity =>
        {
            entity.HasKey(e => e.LstkbwId)
                .HasName("PRIMARY51")
                .IsClustered(false);

            entity.ToTable("lstkbw");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.Property(e => e.LstkbwId)
                .ValueGeneratedNever()
                .HasColumnName("LSTKBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");

            entity.HasOne(d => d.Filist).WithMany(p => p.Lstkbws)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_320");
        });

        modelBuilder.Entity<Mmcntrl>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID1")
                .IsClustered(false);

            entity.ToTable("mmcntrls");

            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Cdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CDESC");
        });

        modelBuilder.Entity<Mmsecure>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID0")
                .IsClustered(false);

            entity.ToTable("mmsecure");

            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Ctype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CTYPE");
            entity.Property(e => e.Iaccess).HasColumnName("IACCESS");
            entity.Property(e => e.Icontrolid).HasColumnName("ICONTROLID");
            entity.Property(e => e.Iusrgroupid).HasColumnName("IUSRGROUPID");
        });

        modelBuilder.Entity<MpGast>(entity =>
        {
            entity.HasKey(e => e.MpgastId)
                .HasName("PRIMARY25")
                .IsClustered(false);

            entity.ToTable("MpGAST");

            entity.Property(e => e.MpgastId).HasColumnName("MPGAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Labstk)
                .HasDefaultValue(false)
                .HasColumnName("LABSTK");
            entity.Property(e => e.Lbetrag)
                .HasDefaultValue(true)
                .HasColumnName("LBETRAG");
            entity.Property(e => e.Lfuerstk)
                .HasDefaultValue(true)
                .HasColumnName("LFUERSTK");
            entity.Property(e => e.Lprozent)
                .HasDefaultValue(false)
                .HasColumnName("LPROZENT");
        });

        modelBuilder.Entity<MpgrSt>(entity =>
        {
            entity.HasKey(e => e.MpgrstId)
                .HasName("PRIMARY10")
                .IsClustered(false);

            entity.ToTable("MpgrST");

            entity.HasIndex(e => e.KampstId, "KaMPST");

            entity.HasIndex(e => e.MpgastId, "MPGAST");

            entity.Property(e => e.MpgrstId).HasColumnName("MPGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.KampstId).HasColumnName("KAMPST_ID");
            entity.Property(e => e.Menge)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("MENGE");
            entity.Property(e => e.MpgastId).HasColumnName("MPGAST_ID");
            entity.Property(e => e.Wert)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("WERT");

            entity.HasOne(d => d.Kampst).WithMany(p => p.MpgrSts)
                .HasForeignKey(d => d.KampstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_2380");

            entity.HasOne(d => d.Mpgast).WithMany(p => p.MpgrSts)
                .HasForeignKey(d => d.MpgastId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_2360");
        });

        modelBuilder.Entity<RadeSt>(entity =>
        {
            entity.HasKey(e => e.RadestId)
                .HasName("PRIMARY16")
                .IsClustered(false);

            entity.ToTable("RadeST");

            entity.HasIndex(e => e.RagrstId, "RagrST");

            entity.Property(e => e.RadestId)
                .ValueGeneratedNever()
                .HasColumnName("RADEST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.RagrstId).HasColumnName("RAGRST_ID");

            entity.HasOne(d => d.Ragrst).WithMany(p => p.RadeSts)
                .HasForeignKey(d => d.RagrstId)
                .HasConstraintName("Relation_240");
        });

        modelBuilder.Entity<RagrSt>(entity =>
        {
            entity.HasKey(e => e.RagrstId)
                .HasName("PRIMARY15")
                .IsClustered(false);

            entity.ToTable("RagrST");

            entity.Property(e => e.RagrstId)
                .ValueGeneratedNever()
                .HasColumnName("RAGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
        });

        modelBuilder.Entity<RastSt>(entity =>
        {
            entity.HasKey(e => e.RaststId)
                .HasName("PRIMARY17")
                .IsClustered(false);

            entity.ToTable("RastST");

            entity.HasIndex(e => e.RagrstIdx, "RagrSTX");

            entity.HasIndex(e => e.RagrstIdy, "RagrSTY");

            entity.Property(e => e.RaststId)
                .ValueGeneratedNever()
                .HasColumnName("RASTST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.RagrstIdx).HasColumnName("RAGRST_IDX");
            entity.Property(e => e.RagrstIdy).HasColumnName("RAGRST_IDY");

            entity.HasOne(d => d.RagrstIdxNavigation).WithMany(p => p.RastStRagrstIdxNavigations)
                .HasForeignKey(d => d.RagrstIdx)
                .HasConstraintName("Relation_242");

            entity.HasOne(d => d.RagrstIdyNavigation).WithMany(p => p.RastStRagrstIdyNavigations)
                .HasForeignKey(d => d.RagrstIdy)
                .HasConstraintName("Relation_243");
        });

        modelBuilder.Entity<RechBw>(entity =>
        {
            entity.HasKey(e => e.RechbwId)
                .HasName("PRIMARY47")
                .IsClustered(false);

            entity.ToTable("RechBW");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.Rechnr, "RECHNR");

            entity.Property(e => e.RechbwId)
                .ValueGeneratedNever()
                .HasColumnName("RECHBW_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Datzeit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATZEIT");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");
            entity.Property(e => e.Rechdat).HasColumnName("RECHDAT");
            entity.Property(e => e.Rechnr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECHNR");

            entity.HasOne(d => d.Filist).WithMany(p => p.RechBws)
                .HasForeignKey(d => d.FilistId)
                .HasConstraintName("Relation_312");

            entity.HasOne(d => d.Liefst).WithMany(p => p.RechBws)
                .HasForeignKey(d => d.LiefstId)
                .HasConstraintName("Relation_311");
        });

        modelBuilder.Entity<RepoSt>(entity =>
        {
            entity.HasKey(e => e.RepostId)
                .HasName("PRIMARY50")
                .IsClustered(false);

            entity.ToTable("RepoSt");

            entity.HasIndex(e => e.Flaglist, "FLAGLIST");

            entity.HasIndex(e => e.LAktiv, "LAKTIV");

            entity.HasIndex(e => e.ReposyId, "RepoSy");

            entity.Property(e => e.RepostId).HasColumnName("REPOST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Beschreib)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("BESCHREIB");
            entity.Property(e => e.Flaglist)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FLAGLIST");
            entity.Property(e => e.LAktiv).HasColumnName("lAKTIV");
            entity.Property(e => e.Repofile)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("REPOFILE");
            entity.Property(e => e.ReposyId).HasColumnName("REPOSY_ID");

            entity.HasOne(d => d.Reposy).WithMany(p => p.RepoSts)
                .HasForeignKey(d => d.ReposyId)
                .HasConstraintName("Relation_316");
        });

        modelBuilder.Entity<RepoSy>(entity =>
        {
            entity.HasKey(e => e.ReposyId)
                .HasName("PRIMARY49")
                .IsClustered(false);

            entity.ToTable("RepoSy");

            entity.Property(e => e.ReposyId)
                .ValueGeneratedNever()
                .HasColumnName("REPOSY_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
        });

        modelBuilder.Entity<Repolist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("repolist");

            entity.HasIndex(e => e.Cdosname, "CDOSNAME").IsUnique();

            entity.HasIndex(e => e.Cfullname, "CFULLNAME");

            entity.HasIndex(e => e.Ctype, "CTYPE");

            entity.Property(e => e.Cdosname)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CDOSNAME");
            entity.Property(e => e.Cfullname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CFULLNAME");
            entity.Property(e => e.Ctype)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CTYPE");
            entity.Property(e => e.Ldaterange).HasColumnName("LDATERANGE");
            entity.Property(e => e.Lnoexcel).HasColumnName("LNOEXCEL");
        });

        //modelBuilder.Entity<Resource>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //    entity.Property(e => e.BackgroundCss).HasMaxLength(100);
        //    entity.Property(e => e.Name).HasMaxLength(50);
        //    entity.Property(e => e.TextCss).HasMaxLength(100);

        //    entity.HasOne(d => d.User).WithMany(p => p.Resources)
        //        .HasForeignKey(d => d.UserId)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_Resources_users");
        //});

        modelBuilder.Entity<Setsst>(entity =>
        {
            entity.HasKey(e => e.SetsstId)
                .HasName("PRIMARY48")
                .IsClustered(false);

            entity.ToTable("setsst");

            entity.HasIndex(e => e.VaristIds, "VariST");

            entity.HasIndex(e => e.VaristIdd, "VariST0");

            entity.Property(e => e.SetsstId)
                .ValueGeneratedNever()
                .HasColumnName("SETSST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Menge)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("MENGE");
            entity.Property(e => e.Splitschl)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("SPLITSCHL");
            entity.Property(e => e.VaristIdd).HasColumnName("VARIST_IDD");
            entity.Property(e => e.VaristIds).HasColumnName("VARIST_IDS");

            entity.HasOne(d => d.VaristIddNavigation).WithMany(p => p.SetsstVaristIddNavigations)
                .HasForeignKey(d => d.VaristIdd)
                .HasConstraintName("Relation_315");

            entity.HasOne(d => d.VaristIdsNavigation).WithMany(p => p.SetsstVaristIdsNavigations)
                .HasForeignKey(d => d.VaristIds)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Relation_314");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Cstate)
                .HasName("CSTATE")
                .IsClustered(false);

            entity.ToTable("states");

            entity.HasIndex(e => e.Ccountry, "CCOUNTRY");

            entity.Property(e => e.Cstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CSTATE");
            entity.Property(e => e.Ccountry)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCOUNTRY");
            entity.Property(e => e.Cfullname)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("CFULLNAME");
        });

        modelBuilder.Entity<SteuSt>(entity =>
        {
            entity.HasKey(e => e.SteustId)
                .HasName("PRIMARY8")
                .IsClustered(false);

            entity.ToTable("SteuST");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.HasIndex(e => e.Steunr, "STEUNR");

            entity.Property(e => e.SteustId).HasColumnName("STEUST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kasatznr)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("KASATZNR");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.Steunr)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("STEUNR");
            entity.Property(e => e.Steusatz)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("STEUSATZ");
            entity.Property(e => e.Wasatznr)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("WASATZNR");
        });

        modelBuilder.Entity<TJournalarchiv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tJournalarchiv");

            entity.Property(e => e.AArtnr)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_ARTNR");
            entity.Property(e => e.ABez)
                .HasMaxLength(33)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_BEZ");
            entity.Property(e => e.AKunr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_KUNR");
            entity.Property(e => e.AMwst)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("A_MWST");
            entity.Property(e => e.AVerkauft)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("A_VERKAUFT");
            entity.Property(e => e.AVkdat)
                .HasColumnType("datetime")
                .HasColumnName("A_VKDAT");
            entity.Property(e => e.AVkpre)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("A_VKPRE");
            entity.Property(e => e.AWgr)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("A_WGR");
            entity.Property(e => e.Abrechok).HasColumnName("ABRECHOK");
            entity.Property(e => e.Addon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ADDON");
            entity.Property(e => e.Barcfakt)
                .HasColumnType("numeric(7, 3)")
                .HasColumnName("BARCFAKT");
            entity.Property(e => e.Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG");
            entity.Property(e => e.JournalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JOURNAL_ID");
            entity.Property(e => e.Journalau).HasColumnName("JOURNALAU");
            entity.Property(e => e.Kassa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KASSA");
            entity.Property(e => e.Kassiernr)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("KASSIERNR");
            entity.Property(e => e.Limitarti).HasColumnName("LIMITARTI");
            entity.Property(e => e.Marker)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MARKER");
            entity.Property(e => e.Materialnr)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERIALNR");
            entity.Property(e => e.Monatabrok).HasColumnName("MONATABROK");
            entity.Property(e => e.Mtext)
                .IsUnicode(false)
                .HasColumnName("MTEXT");
            entity.Property(e => e.Nrgt)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NRGT");
            entity.Property(e => e.Onlinebuch).HasColumnName("ONLINEBUCH");
            entity.Property(e => e.Preisebene)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PREISEBENE");
            entity.Property(e => e.Qrdaten)
                .IsUnicode(false)
                .HasColumnName("QRDATEN");
            entity.Property(e => e.Sequenznr)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SEQUENZNR");
            entity.Property(e => e.Storniert).HasColumnName("STORNIERT");
            entity.Property(e => e.Tagabschln)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("TAGABSCHLN");
            entity.Property(e => e.Training).HasColumnName("TRAINING");
            entity.Property(e => e.Varistid).HasColumnName("VARISTID");
            entity.Property(e => e.Vorgang)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VORGANG");
            entity.Property(e => e.Wochabrok).HasColumnName("WOCHABROK");
            entity.Property(e => e.Zahlart)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ZAHLART");
            entity.Property(e => e.Zeitungsvk).HasColumnName("ZEITUNGSVK");
        });

        modelBuilder.Entity<TKjournal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tKjournal");

            entity.Property(e => e.AArtnr)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_ARTNR");
            entity.Property(e => e.ABez)
                .HasMaxLength(33)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_BEZ");
            entity.Property(e => e.AKunr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A_KUNR");
            entity.Property(e => e.AMwst)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("A_MWST");
            entity.Property(e => e.AVerkauft)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("A_VERKAUFT");
            entity.Property(e => e.AVkdat)
                .HasColumnType("datetime")
                .HasColumnName("A_VKDAT");
            entity.Property(e => e.AVkpre)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("A_VKPRE");
            entity.Property(e => e.AWgr)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("A_WGR");
            entity.Property(e => e.Abrechok).HasColumnName("ABRECHOK");
            entity.Property(e => e.Addon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ADDON");
            entity.Property(e => e.Barcfakt)
                .HasColumnType("numeric(7, 3)")
                .HasColumnName("BARCFAKT");
            entity.Property(e => e.Cwldverbucht).HasColumnName("CWLDverbucht");
            entity.Property(e => e.Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FLAG");
            entity.Property(e => e.Journalau).HasColumnName("JOURNALAU");
            entity.Property(e => e.Kassa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KASSA");
            entity.Property(e => e.Kassiernr)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("KASSIERNR");
            entity.Property(e => e.KjournalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("KJOURNAL_ID");
            entity.Property(e => e.Limitarti).HasColumnName("LIMITARTI");
            entity.Property(e => e.Marker)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MARKER");
            entity.Property(e => e.Materialnr)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MATERIALNR");
            entity.Property(e => e.Monatabrok).HasColumnName("MONATABROK");
            entity.Property(e => e.Mtext)
                .IsUnicode(false)
                .HasColumnName("MTEXT");
            entity.Property(e => e.Nrgt)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NRGT");
            entity.Property(e => e.Onlinebuch).HasColumnName("ONLINEBUCH");
            entity.Property(e => e.Preisebene)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PREISEBENE");
            entity.Property(e => e.Qrdaten)
                .IsUnicode(false)
                .HasColumnName("QRDATEN");
            entity.Property(e => e.Sequenznr)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("SEQUENZNR");
            entity.Property(e => e.Storniert).HasColumnName("STORNIERT");
            entity.Property(e => e.Tagabschln)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("TAGABSCHLN");
            entity.Property(e => e.Training).HasColumnName("TRAINING");
            entity.Property(e => e.Varistid).HasColumnName("VARISTID");
            entity.Property(e => e.Vorgang)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VORGANG");
            entity.Property(e => e.Wochabrok).HasColumnName("WOCHABROK");
            entity.Property(e => e.Zahlart)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ZAHLART");
            entity.Property(e => e.Zeitungsvk).HasColumnName("ZEITUNGSVK");
        });

        modelBuilder.Entity<Tljournal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tljournal");

            entity.Property(e => e.Aktzeit)
                .HasColumnType("datetime")
                .HasColumnName("aktzeit");
            entity.Property(e => e.Anzahl)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("anzahl");
            entity.Property(e => e.Bonnr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("bonnr");
            entity.Property(e => e.Bonposit)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("bonposit");
            entity.Property(e => e.Ean)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ean");
            entity.Property(e => e.Eanfaktor)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("eanfaktor");
            entity.Property(e => e.Eanint)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("eanint");
            entity.Property(e => e.Einauszahl)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("einauszahl");
            entity.Property(e => e.Ekpreis)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("ekpreis");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kassanr)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("kassanr");
            entity.Property(e => e.Kassiernr)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("kassiernr");
            entity.Property(e => e.Kundennr)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("kundennr");
            entity.Property(e => e.Lageralt)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("lageralt");
            entity.Property(e => e.Mwst)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("mwst");
            entity.Property(e => e.Regmodus)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("regmodus");
            entity.Property(e => e.Satzart)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("satzart");
            entity.Property(e => e.Titel)
                .HasMaxLength(33)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("titel");
            entity.Property(e => e.Vkdatum)
                .HasColumnType("datetime")
                .HasColumnName("vkdatum");
            entity.Property(e => e.Vkpreis)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("vkpreis");
            entity.Property(e => e.Zwinvdat)
                .HasColumnType("datetime")
                .HasColumnName("zwinvdat");
            entity.Property(e => e.Zwinvstand)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("zwinvstand");
            entity.Property(e => e.Zwinvwert)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("zwinvwert");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID")
                .IsClustered(false);

            entity.ToTable("users");

            entity.HasIndex(e => e.Cuserid, "CUSERID");

            entity.Property(e => e.Iid).HasColumnName("IID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Cfullname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CFULLNAME");
            entity.Property(e => e.Clastupdid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASTUPDID");
            entity.Property(e => e.Cpassword)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CPASSWORD");
            entity.Property(e => e.Cuserid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSERID");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Idatabaseutilities).HasColumnName("IDATABASEUTILITIES");
            entity.Property(e => e.Iprintreports).HasColumnName("IPRINTREPORTS");
            entity.Property(e => e.Isystemsettings).HasColumnName("ISYSTEMSETTINGS");
            entity.Property(e => e.Iusergroups).HasColumnName("IUSERGROUPS");
            entity.Property(e => e.Iuserpreferences).HasColumnName("IUSERPREFERENCES");
            entity.Property(e => e.Iusers).HasColumnName("IUSERS");
            entity.Property(e => e.Lusedplist)
                .HasDefaultValue(false)
                .HasColumnName("LUSEDPLIST");
            entity.Property(e => e.Lwgrsperr).HasColumnName("LWGRSPERR");
            entity.Property(e => e.Sendmailcc)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SENDMAILCC");
            entity.Property(e => e.Smtppassw)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SMTPPASSW");
            entity.Property(e => e.Smtpsender)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SMTPSENDER");
            entity.Property(e => e.Smtpuser)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SMTPUSER");
            entity.Property(e => e.Tlastupd)
                .HasColumnType("datetime")
                .HasColumnName("TLASTUPD");
        });

        modelBuilder.Entity<Usgrlink>(entity =>
        {
            entity.HasKey(e => e.Iid)
                .HasName("IID2")
                .IsClustered(false);

            entity.ToTable("usgrlink");

            entity.HasIndex(e => e.Igroupid, "IGROUPID");

            entity.HasIndex(e => e.Iuserid, "IUSERID");

            entity.Property(e => e.Iid)
                .ValueGeneratedNever()
                .HasColumnName("IID");
            entity.Property(e => e.Igroupid).HasColumnName("IGROUPID");
            entity.Property(e => e.Ilastupdid).HasColumnName("ILASTUPDID");
            entity.Property(e => e.Iorder).HasColumnName("IORDER");
            entity.Property(e => e.Iuserid).HasColumnName("IUSERID");
            entity.Property(e => e.Tlastupd)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TLASTUPD");

            entity.HasOne(d => d.Igroup).WithMany(p => p.Usgrlinks)
                .HasForeignKey(d => d.Igroupid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_201");

            entity.HasOne(d => d.Iuser).WithMany(p => p.Usgrlinks)
                .HasForeignKey(d => d.Iuserid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_200");
        });

        modelBuilder.Entity<VaFil>(entity =>
        {
            entity.HasKey(e => e.VaFilId)
                .HasName("PRIMARY3")
                .IsClustered(false);

            entity.ToTable("VA_FIL");

            entity.HasIndex(e => e.EtiastId, "EtiAST");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.HasIndex(e => e.MpgrstId, "MpgrST");

            entity.HasIndex(e => e.SteustId, "SteuST");

            entity.HasIndex(e => e.VaristId, "VariST");

            entity.Property(e => e.VaFilId).HasColumnName("VA_FIL_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anzeti1)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("ANZETI1");
            entity.Property(e => e.Anzeti2)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("ANZETI2");
            entity.Property(e => e.Anzeti3)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("ANZETI3");
            entity.Property(e => e.EtiastId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ETIAST_ID");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Gpeinheit)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("GPEINHEIT");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.Laktiv).HasColumnName("LAKTIV");
            entity.Property(e => e.Minlagmeng)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("MINLAGMENG");
            entity.Property(e => e.MpgrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MPGRST_ID");
            entity.Property(e => e.Netinh)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("NETINH");
            entity.Property(e => e.Netinhbez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NETINHBEZ");
            entity.Property(e => e.Sollagmeng)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("SOLLAGMENG");
            entity.Property(e => e.SteustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("STEUST_ID");
            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");
            entity.Property(e => e.Vk1)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK1");
            entity.Property(e => e.Vk2)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK2");
            entity.Property(e => e.Vk3)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK3");
            entity.Property(e => e.Vk4)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK4");
            entity.Property(e => e.Vk5)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK5");
            entity.Property(e => e.Vk6)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK6");
            entity.Property(e => e.Vk7)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK7");
            entity.Property(e => e.Vk8)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK8");
            entity.Property(e => e.Vk9)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK9");
            entity.Property(e => e.VteDstId).HasColumnName("VTeDST_ID");

            entity.HasOne(d => d.Etiast).WithMany(p => p.VaFils)
                .HasForeignKey(d => d.EtiastId)
                .HasConstraintName("Relation_291");

            entity.HasOne(d => d.Filist).WithMany(p => p.VaFils)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_227");

            entity.HasOne(d => d.Mpgrst).WithMany(p => p.VaFils)
                .HasForeignKey(d => d.MpgrstId)
                .HasConstraintName("Relation_225");

            entity.HasOne(d => d.Steust).WithMany(p => p.VaFils)
                .HasForeignKey(d => d.SteustId)
                .HasConstraintName("Relation_224");

            entity.HasOne(d => d.Varist).WithMany(p => p.VaFils)
                .HasForeignKey(d => d.VaristId)
                .HasConstraintName("Relation_204");
        });

        modelBuilder.Entity<VaLie>(entity =>
        {
            entity.HasKey(e => e.VaLieId)
                .HasName("PRIMARY14")
                .IsClustered(false);

            entity.ToTable("VA_LIE");

            entity.HasIndex(e => e.Liefartnr, "LIEFARTNR");

            entity.HasIndex(e => e.Lieftype, "LIEFTYPE");

            entity.HasIndex(e => e.LiefstId, "LiefST");

            entity.HasIndex(e => e.LiefstIdb, "LiefSTB");

            entity.HasIndex(e => e.VaristId, "VariST");

            entity.Property(e => e.VaLieId).HasColumnName("VA_LIE_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bek)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BEK");
            entity.Property(e => e.Datumbis)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("DATUMBIS");
            entity.Property(e => e.Datumvon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("DATUMVON");
            entity.Property(e => e.Ekp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EKP");
            entity.Property(e => e.Fwekp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("FWEKP");
            entity.Property(e => e.Ghe)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("GHE");
            entity.Property(e => e.Ghebez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GHEBEZ");
            entity.Property(e => e.Ghstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("+")
                .HasColumnName("GHSTATUS");
            entity.Property(e => e.Letztekdat).HasColumnName("LETZTEKDAT");
            entity.Property(e => e.Letztekp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("LETZTEKP");
            entity.Property(e => e.Liefartbez)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("LIEFARTBEZ");
            entity.Property(e => e.Liefartnr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LIEFARTNR");
            entity.Property(e => e.LiefstId).HasColumnName("LIEFST_ID");
            entity.Property(e => e.LiefstIdb).HasColumnName("LIEFST_IDB");
            entity.Property(e => e.Lieftype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("LIEFTYPE");
            entity.Property(e => e.Lwhauptart)
                .HasDefaultValue(true)
                .HasColumnName("LWHAUPTART");
            entity.Property(e => e.Lwvkp)
                .HasDefaultValue(true)
                .HasColumnName("LWVKP");
            entity.Property(e => e.Minlimenge)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("MINLIMENGE");
            entity.Property(e => e.Minlizeit)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 0)")
                .HasColumnName("MINLIZEIT");
            entity.Property(e => e.Sollspanne)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(8, 4)")
                .HasColumnName("SOLLSPANNE");
            entity.Property(e => e.Suslief)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUSLIEF");
            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");

            entity.HasOne(d => d.Liefst).WithMany(p => p.VaLieLiefsts)
                .HasForeignKey(d => d.LiefstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_233");

            entity.HasOne(d => d.LiefstIdbNavigation).WithMany(p => p.VaLieLiefstIdbNavigations)
                .HasForeignKey(d => d.LiefstIdb)
                .HasConstraintName("Relation_300");

            entity.HasOne(d => d.Varist).WithMany(p => p.VaLies)
                .HasForeignKey(d => d.VaristId)
                .HasConstraintName("Relation_234");
        });

        modelBuilder.Entity<VariSt>(entity =>
        {
            entity.HasKey(e => e.VaristId)
                .HasName("PRIMARY0")
                .IsClustered(false);

            entity.ToTable("VariST");

            entity.HasIndex(e => e.AgrustId, "AgruST");

            entity.HasIndex(e => e.ArtistId, "ArtiST");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.ErzestId, "ErzeST");

            entity.HasIndex(e => e.HagrstId, "HagrST");

            entity.HasIndex(e => e.Lpfandart, "LPFANDART");

            entity.HasIndex(e => e.Matchcode, "MATCHCODE");

            entity.HasIndex(e => e.KapfstId, "PfanST");

            entity.HasIndex(e => e.RadestIdx, "RadeSTX");

            entity.HasIndex(e => e.RadestIdy, "RadeSTY");

            entity.HasIndex(e => e.VaristIdp, "VARIST_IDP");

            entity.HasIndex(e => e.WagrstId, "WagrST");

            entity.Property(e => e.VaristId).HasColumnName("VARIST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.AgrustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("AGRUST_ID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.ArtistId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ARTIST_ID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.ErzestId).HasColumnName("ERZEST_ID");
            entity.Property(e => e.Extartnr).HasColumnName("EXTARTNR");
            entity.Property(e => e.Gewichtnet)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("GEWICHTNET");
            entity.Property(e => e.HagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("HAGRST_ID");
            entity.Property(e => e.Haltbtage)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("HALTBTAGE");
            entity.Property(e => e.Iskn8)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ISKN8");
            entity.Property(e => e.Isurspland)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ISURSPLAND");
            entity.Property(e => e.KapfstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("KAPFST_ID");
            entity.Property(e => e.LFlag01).HasColumnName("lFLAG01");
            entity.Property(e => e.LFlag02).HasColumnName("lFLAG02");
            entity.Property(e => e.LIsexpostk).HasColumnName("lISEXPOSTK");
            entity.Property(e => e.Lagekbew)
                .HasDefaultValue(2)
                .HasColumnName("LAGEKBEW");
            entity.Property(e => e.Lfestpreis)
                .HasDefaultValue(true)
                .HasColumnName("LFESTPREIS");
            entity.Property(e => e.Lpfandart).HasColumnName("LPFANDART");
            entity.Property(e => e.Lpreiseing).HasColumnName("LPREISEING");
            entity.Property(e => e.Lwiegeart).HasColumnName("LWIEGEART");
            entity.Property(e => e.Matchcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATCHCODE");
            entity.Property(e => e.Merkmal01)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MERKMAL01");
            entity.Property(e => e.Merkmal02)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MERKMAL02");
            entity.Property(e => e.RadestIdx)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("RADEST_IDX");
            entity.Property(e => e.RadestIdy)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("RADEST_IDY");
            entity.Property(e => e.VaristIdp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("VARIST_IDP");
            entity.Property(e => e.WagrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("WAGRST_ID");

            entity.HasOne(d => d.Agrust).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.AgrustId)
                .HasConstraintName("Relation_238");

            entity.HasOne(d => d.Artist).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.ArtistId)
                .HasConstraintName("Relation_2000");

            entity.HasOne(d => d.Erzest).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.ErzestId)
                .HasConstraintName("Relation_303");

            entity.HasOne(d => d.Hagrst).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.HagrstId)
                .HasConstraintName("Relation_236");

            entity.HasOne(d => d.Kapfst).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.KapfstId)
                .HasConstraintName("Relation_2090");

            entity.HasOne(d => d.RadestIdxNavigation).WithMany(p => p.VariStRadestIdxNavigations)
                .HasForeignKey(d => d.RadestIdx)
                .HasConstraintName("Relation_244");

            entity.HasOne(d => d.RadestIdyNavigation).WithMany(p => p.VariStRadestIdyNavigations)
                .HasForeignKey(d => d.RadestIdy)
                .HasConstraintName("Relation_226");

            entity.HasOne(d => d.VaristIdpNavigation).WithMany(p => p.InverseVaristIdpNavigation)
                .HasForeignKey(d => d.VaristIdp)
                .HasConstraintName("Relation_2270");

            entity.HasOne(d => d.Wagrst).WithMany(p => p.VariSts)
                .HasForeignKey(d => d.WagrstId)
                .HasConstraintName("Relation_237");
        });

        modelBuilder.Entity<VteAst>(entity =>
        {
            entity.HasKey(e => e.VteastId)
                .HasName("PRIMARY24")
                .IsClustered(false);

            entity.ToTable("VTeAST");

            entity.Property(e => e.VteastId).HasColumnName("VTEAST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Lexchvari).HasColumnName("LEXCHVARI");
            entity.Property(e => e.Llinkvari)
                .HasDefaultValue(true)
                .HasColumnName("LLINKVARI");
            entity.Property(e => e.Lnurstart).HasColumnName("LNURSTART");
            entity.Property(e => e.Lreplvari).HasColumnName("LREPLVARI");
        });

        modelBuilder.Entity<VteDst>(entity =>
        {
            entity.HasKey(e => e.VtedstId)
                .HasName("PRIMARY12")
                .IsClustered(false);

            entity.ToTable("VTeDST");

            entity.HasIndex(e => e.VtekstId, "ATeKST");

            entity.HasIndex(e => e.MpgrstId, "MpgrST");

            entity.HasIndex(e => e.SteustId, "SteuST");

            entity.HasIndex(e => e.VaFilId, "VA_FIL");

            entity.Property(e => e.VtedstId).HasColumnName("VTEDST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anzeti1)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI1");
            entity.Property(e => e.Anzeti2)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI2");
            entity.Property(e => e.Anzeti3)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(1, 0)")
                .HasColumnName("ANZETI3");
            entity.Property(e => e.Bek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BEK");
            entity.Property(e => e.Ekp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EKP");
            entity.Property(e => e.Gpeinheit)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("GPEINHEIT");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.Laktiv)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("LAKTIV");
            entity.Property(e => e.MpgrstId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("MPGRST_ID");
            entity.Property(e => e.Netinh)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("NETINH");
            entity.Property(e => e.Netinhbez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("NETINHBEZ");
            entity.Property(e => e.SteustId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("STEUST_ID");
            entity.Property(e => e.VaFilId).HasColumnName("VA_FIL_ID");
            entity.Property(e => e.Vk1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK1");
            entity.Property(e => e.Vk2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK2");
            entity.Property(e => e.Vk3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK3");
            entity.Property(e => e.Vk4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK4");
            entity.Property(e => e.Vk5)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK5");
            entity.Property(e => e.Vk6)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK6");
            entity.Property(e => e.Vk7)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK7");
            entity.Property(e => e.Vk8)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK8");
            entity.Property(e => e.Vk9)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK9");
            entity.Property(e => e.VtekstId).HasColumnName("VTEKST_ID");

            entity.HasOne(d => d.Mpgrst).WithMany(p => p.VteDsts)
                .HasForeignKey(d => d.MpgrstId)
                .HasConstraintName("Relation_230");

            entity.HasOne(d => d.Steust).WithMany(p => p.VteDsts)
                .HasForeignKey(d => d.SteustId)
                .HasConstraintName("Relation_2350");

            entity.HasOne(d => d.VaFil).WithMany(p => p.VteDsts)
                .HasForeignKey(d => d.VaFilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_231");

            entity.HasOne(d => d.Vtekst).WithMany(p => p.VteDsts)
                .HasForeignKey(d => d.VtekstId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_228");
        });

        modelBuilder.Entity<VteKst>(entity =>
        {
            entity.HasKey(e => e.VtekstId)
                .HasName("PRIMARY11")
                .IsClustered(false);

            entity.ToTable("VTeKST");

            entity.HasIndex(e => e.Bezeichn, "BEZICHN");

            entity.HasIndex(e => e.Datumbis, "DATUMBIS");

            entity.HasIndex(e => e.Datumvon, "DATUMVON");

            entity.HasIndex(e => e.VteastId, "VTeAST");

            entity.Property(e => e.VtekstId).HasColumnName("VTEKST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Datende)
                .HasColumnType("datetime")
                .HasColumnName("DATENDE");
            entity.Property(e => e.Datstart)
                .HasColumnType("datetime")
                .HasColumnName("DATSTART");
            entity.Property(e => e.Datumbis).HasColumnName("DATUMBIS");
            entity.Property(e => e.Datumvon).HasColumnName("DATUMVON");
            entity.Property(e => e.Lbeendet)
                .HasDefaultValue(false)
                .HasColumnName("LBEENDET");
            entity.Property(e => e.Lgestartet).HasColumnName("LGESTARTET");
            entity.Property(e => e.VteastId).HasColumnName("VTEAST_ID");

            entity.HasOne(d => d.Vteast).WithMany(p => p.VteKsts)
                .HasForeignKey(d => d.VteastId)
                .HasConstraintName("Relation_2340");
        });

        modelBuilder.Entity<VtedIm>(entity =>
        {
            entity.HasKey(e => e.VtedimId)
                .HasName("PRIMARY32")
                .IsClustered(false);

            entity.ToTable("VtedIM");

            entity.HasIndex(e => e.FilistId, "FiliST");

            entity.Property(e => e.VtedimId).HasColumnName("VTEDIM_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Aktbez)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("AKTBEZ");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Ek)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("EK");
            entity.Property(e => e.FilistId).HasColumnName("FILIST_ID");
            entity.Property(e => e.Liefartnr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LIEFARTNR");
            entity.Property(e => e.LiefstId)
                .HasDefaultValue(1)
                .HasColumnName("LIEFST_ID");
            entity.Property(e => e.Vk)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("VK");

            entity.HasOne(d => d.Filist).WithMany(p => p.VtedIms)
                .HasForeignKey(d => d.FilistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_318");
        });

        modelBuilder.Entity<VtekIm>(entity =>
        {
            entity.HasKey(e => e.VtekimId)
                .HasName("PRIMARY31")
                .IsClustered(false);

            entity.ToTable("VtekIM");

            entity.HasIndex(e => e.Bezeichn, "BEZEICHN");

            entity.HasIndex(e => e.VteastId, "VTeAST");

            entity.Property(e => e.VtekimId)
                .ValueGeneratedNever()
                .HasColumnName("VTEKIM_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Anmerkung)
                .IsUnicode(false)
                .HasColumnName("ANMERKUNG");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Datumbis).HasColumnName("DATUMBIS");
            entity.Property(e => e.Datumvon).HasColumnName("DATUMVON");
            entity.Property(e => e.VteastId).HasColumnName("VTEAST_ID");

            entity.HasOne(d => d.Vteast).WithMany(p => p.VtekIms)
                .HasForeignKey(d => d.VteastId)
                .HasConstraintName("Relation_254");
        });

        modelBuilder.Entity<WagrSt>(entity =>
        {
            entity.HasKey(e => e.WagrstId)
                .HasName("PRIMARY6")
                .IsClustered(false);

            entity.ToTable("WagrST");

            entity.HasIndex(e => e.Kuerzel, "KUERZEL");

            entity.HasIndex(e => e.KawgstId, "KawgST");

            entity.HasIndex(e => e.SteustId, "SteuST");

            entity.HasIndex(e => e.Wagrnr, "WAGRNR");

            entity.Property(e => e.WagrstId).HasColumnName("WAGRST_ID");
            entity.Property(e => e.Aendat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AENDAT");
            entity.Property(e => e.Aenuserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AENUSERID");
            entity.Property(e => e.AgrustNrm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .HasColumnName("AGRUST_NRM");
            entity.Property(e => e.AgrustNrx)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("ZZZZZZ")
                .HasColumnName("AGRUST_NRX");
            entity.Property(e => e.Anldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ANLDAT");
            entity.Property(e => e.Anluserid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANLUSERID");
            entity.Property(e => e.Bezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("BEZEICHN");
            entity.Property(e => e.Kabezeichn)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("KABEZEICHN");
            entity.Property(e => e.KawgstId).HasColumnName("KAWGST_ID");
            entity.Property(e => e.Kuerzel)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUERZEL");
            entity.Property(e => e.LFlag01)
                .HasDefaultValue(false)
                .HasColumnName("lFLAG01");
            entity.Property(e => e.LFlag02)
                .HasDefaultValue(false)
                .HasColumnName("lFLAG02");
            entity.Property(e => e.Lgesperrt)
                .HasDefaultValue(false)
                .HasColumnName("LGESPERRT");
            entity.Property(e => e.Lgewicht)
                .HasDefaultValue(false)
                .HasColumnName("LGEWICHT");
            entity.Property(e => e.Lkomm)
                .HasDefaultValue(false)
                .HasColumnName("LKOMM");
            entity.Property(e => e.Lnegativ)
                .HasDefaultValue(false)
                .HasColumnName("LNEGATIV");
            entity.Property(e => e.Lsammel)
                .HasDefaultValue(false)
                .HasColumnName("LSAMMEL");
            entity.Property(e => e.Sammelsapo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SAMMELSAPO");
            entity.Property(e => e.SteustId).HasColumnName("STEUST_ID");
            entity.Property(e => e.Waabteilnr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .HasColumnName("WAABTEILNR");
            entity.Property(e => e.Wagrnr)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("WAGRNR");
            entity.Property(e => e.Wawagrnr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .HasColumnName("WAWAGRNR");

            entity.HasOne(d => d.Kawgst).WithMany(p => p.WagrSts)
                .HasForeignKey(d => d.KawgstId)
                .HasConstraintName("Relation_2330");

            entity.HasOne(d => d.Steust).WithMany(p => p.WagrSts)
                .HasForeignKey(d => d.SteustId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Relation_235");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
