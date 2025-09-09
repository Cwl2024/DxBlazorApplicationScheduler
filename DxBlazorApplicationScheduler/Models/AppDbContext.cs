using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorApplicationScheduler.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Neccessary for application logic
    public virtual DbSet<Appointment> Appointments { get; set; }
    public virtual DbSet<Resource> Resources { get; set; }
    public virtual DbSet<ResourceGroup> ResourceGroups { get; set; }
    public virtual DbSet<AppGroup> AppGroups { get; set; }

    // Neccessary for Login
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Usgrlink> Usgrlinks { get; set; }
    public virtual DbSet<Group> Groups { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
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

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.Property(e => e.BackgroundCss).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TextCss).HasMaxLength(100);

            
        });

        modelBuilder.Entity<ResourceGroup>(entity =>
        {
            entity.HasOne(r => r.Group)
                .WithMany(g => g.ResourceGroups)
                .HasForeignKey(r => r.GroupId);

            entity.HasOne(r => r.Resource)
                .WithMany(res => res.ResourceGroups)
                .HasForeignKey(r => r.ResourceId);
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
