using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ePF.portal.Entities
{
    public partial class AspNetIdTstContext : DbContext
    {
        public AspNetIdTstContext()
        {
        }

        public AspNetIdTstContext(DbContextOptions<AspNetIdTstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Corporates> Corporates { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<TravelAgents> TravelAgents { get; set; }
        public virtual DbSet<UserAccessLocking> UserAccessLocking { get; set; }
        public virtual DbSet<UserPassword> UserPassword { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=A0092D;Database=AspNetIdTst;user id=sa;password=Value*12;trusted_connection=yes;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporates>(entity =>
            {
                entity.HasKey(e => e.UniqueCorporateGuid);

                entity.ToTable("Corporates", "Administration");

                entity.Property(e => e.UniqueCorporateGuid)
                    .HasColumnName("UniqueCorporateGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorporateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DefaultGdsAccessCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GdsAccessCodeAgent)
                    .IsRequired()
                    .HasColumnName("GdsAccessCode_Agent")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelfCreatePin)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.UniqueProfileGuid);

                entity.ToTable("Profiles", "Administration");

                entity.Property(e => e.UniqueProfileGuid)
                    .HasColumnName("UniqueProfileGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TravelAgents>(entity =>
            {
                entity.ToTable("TravelAgents", "Administration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GdsAccessCodeAgent)
                    .HasColumnName("GdsAccessCode_Agent")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PrimeGdsCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PrimePseudoCity)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneCityCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAccessLocking>(entity =>
            {
                entity.ToTable("UserAccessLocking", "Administration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessFailedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IpaddressFailed)
                    .HasColumnName("IPAddressFailed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAccessedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserAccessLockingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAccessLockingUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAccessLocking_User_UserID");
            });

            modelBuilder.Entity<UserPassword>(entity =>
            {
                entity.ToTable("UserPassword", "Administration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationTokenId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordAnswer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordQuestion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PwdTokenId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PwdTokenIdDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserPassword1)
                    .HasColumnName("UserPassword")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserPasswordCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswordUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPassword_User_UserID");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "Administration");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Users", "Administration");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GdsAccessCodeAgent)
                    .HasColumnName("GdsAccessCode_Agent")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SourcePageName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueProfileGuid).HasColumnName("UniqueProfileGUID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.UniqueProfileGu)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UniqueProfileGuid);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
