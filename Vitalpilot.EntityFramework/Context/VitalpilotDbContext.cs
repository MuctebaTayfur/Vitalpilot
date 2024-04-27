using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Vitalpilot.Domain;
using Vitalpilot.Domain.Helper;
using Vitalpilot.Domain.Models;
using File = Vitalpilot.Domain.Models.File;

namespace Vitalpilot.EntityFramework.Context
{
    public class VitalpilotDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public VitalpilotDbContext(DbContextOptions<VitalpilotDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Vitalpilot"));
            base.OnConfiguring(optionsBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<IBase>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property(nameof(IBase.CreatedDate)).CurrentValue = DateTime.Now;
                        entry.Property(nameof(IBase.LastModifiedDate)).CurrentValue = DateTime.Now;
                        entry.Property(nameof(IBase.CreatedBy)).CurrentValue = "System";
                        entry.Property(nameof(IBase.LastModifiedBy)).CurrentValue = "System";

                        break;

                    case EntityState.Modified:
                        entry.Property(nameof(IBase.LastModifiedDate)).CurrentValue = DateTime.Now;
                        entry.Property(nameof(IBase.LastModifiedBy)).CurrentValue = "System";
                        break;

                    case EntityState.Deleted:

                        entry.State = EntityState.Unchanged;
                        entry.Property(nameof(IBase.LastModifiedDate)).CurrentValue = DateTime.Now;
                        entry.Property(nameof(IBase.Deleted)).CurrentValue = true;
                        entry.Property(nameof(IBase.LastModifiedBy)).CurrentValue = "System";
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Clinic> Clinics { get; set; } = null!;
        public virtual DbSet<Disease> Diseases { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<File> Files { get; set; } = null!;
        public virtual DbSet<FileType> FileTypes { get; set; } = null!;
        public virtual DbSet<Hospital> Hospitals { get; set; } = null!;
        public virtual DbSet<LabResult> LabResults { get; set; } = null!;
        public virtual DbSet<NoteType> NoteTypes { get; set; } = null!;
        public virtual DbSet<Patience> Patiences { get; set; } = null!;
        public virtual DbSet<PatienceNote> PatienceNotes { get; set; } = null!;
        public virtual DbSet<Prescription> Prescriptions { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Surgery> Surgeries { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasOne(x => x.Doctor)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(x => x.Patience)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PatienceNote>(entity =>
            {
                entity.HasOne(x => x.Patience)
                .WithMany(x => x.PatienceNotes)
                .HasForeignKey(x => x.PatiencId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.HasOne(x => x.Hospital)
                .WithMany(x => x.Clinics)
                .HasForeignKey(x => x.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasOne(x => x.Clinic)
                .WithMany(x => x.Doctors)
                .HasForeignKey(x => x.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(x => x.Hospital)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(x => x.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasOne(x => x.User)
                .WithMany(x => x.UserTokens)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PatienceDisease>(entity =>
            {
                entity.HasOne(x => x.Patience)
                .WithMany(x => x.PatienceDiseases)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(x => x.Diesase)
                .WithMany(x => x.PatienceDiseases)
                .HasForeignKey(x => x.DiseaseId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LabResult>(entity =>
            {
                entity.HasOne(x => x.Patience)
                .WithMany(x => x.LabResults)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasOne(x => x.Patience)
                .WithMany(x => x.Prescriptions)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Surgery>(entity =>
            {
                entity.HasOne(x => x.Patience)
                .WithMany(x => x.Surgeries)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(x => x.Doctor)
                .WithMany(x => x.Surgeries)
                .HasForeignKey(x => x.PatienceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}