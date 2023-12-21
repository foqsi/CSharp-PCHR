using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Davis_FinalProject_Cs.Models.DataLayer;

public partial class PCHRContext : DbContext
{
    public PCHRContext()
    {
    }

    public PCHRContext(DbContextOptions<PCHRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllergyTbl> AllergyTbls { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ImmunizationTbl> ImmunizationTbls { get; set; }

    public virtual DbSet<MedProcTbl> MedProcTbls { get; set; }

    public virtual DbSet<MedicationTbl> MedicationTbls { get; set; }

    public virtual DbSet<PatientTbl> PatientTbls { get; set; }

    public virtual DbSet<PerDetailsTbl> PerDetailsTbls { get; set; }

    public virtual DbSet<PrimaryCareTbl> PrimaryCareTbls { get; set; }

    public virtual DbSet<TestTbl> TestTbls { get; set; }

    public virtual DbSet<EmergencyContactTbl> EmergencyContact { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\C#\\Database\\pchr.mdf;Integrated security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PatientTbl>()
            .HasOne(p => p.PrimaryCareProvider)
            .WithMany(pc => pc.Patients)
            .HasForeignKey(p => p.PrimaryCareProviderId);


        modelBuilder.Entity<AllergyTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.AllergyId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.AllergyTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ALLERGY_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ConditionId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.Conditions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONDITION_PATIENT_TBL");
        });

        modelBuilder.Entity<ImmunizationTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ImmunizationId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.ImmunizationTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMMUNIZATION_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<MedProcTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.ProcedureId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.MedProcTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MED_PROC_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<MedicationTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.MedId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicationTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MEDICATION_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<PatientTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.AddressZip).IsFixedLength();
            entity.Property(e => e.PhoneHome).IsFixedLength();
            entity.Property(e => e.PhoneMobile).IsFixedLength();
            entity.Property(e => e.PrimaryId).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.Email).IsFixedLength();
        });

        modelBuilder.Entity<PerDetailsTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.BloodType).IsFixedLength();

            entity.HasOne(d => d.Patient).WithOne(p => p.PerDetailsTbl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PER_DETAILS_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<PrimaryCareTbl>(entity =>
        {
            entity.Property(e => e.PrimaryId).IsFixedLength();
            entity.Property(e => e.NameFisrt).IsFixedLength();
            entity.Property(e => e.NameLast).IsFixedLength();
            entity.Property(e => e.PhoneMobile).IsFixedLength();
            entity.Property(e => e.PhoneOffice).IsFixedLength();
            entity.Property(e => e.Specialty).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();

            entity.HasMany(pc => pc.Patients)
                .WithOne(p => p.PrimaryCareProvider)
                .HasForeignKey(p => p.PrimaryCareProviderId);
        });

        modelBuilder.Entity<TestTbl>(entity =>
        {
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.TestId).IsFixedLength();

            entity.HasOne(d => d.Patient).WithMany(p => p.TestTbls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEST_TBL_PATIENT_TBL");
        });

        modelBuilder.Entity<EmergencyContactTbl>(entity =>
        {
            entity.ToTable("EMERGENCY_CONTACT_TBL");
            entity.Property(e => e.PatientId).IsFixedLength();
            entity.Property(e => e.LastName).IsFixedLength();
            entity.Property(e => e.FirstName).IsFixedLength();
            entity.Property(e => e.Relationship).IsFixedLength();
            entity.Property(e => e.AddressStreet).IsFixedLength();
            entity.Property(e => e.AddressSuburb).IsFixedLength();
            entity.Property(e => e.AddressCity).IsFixedLength();
            entity.Property(e => e.AddressZip).IsFixedLength();
            entity.Property(e => e.PhoneHome).IsFixedLength();
            entity.Property(e => e.PhoneMobile).IsFixedLength();
            entity.Property(e => e.PhoneWork).IsFixedLength();
            entity.Property(e => e.Fax).IsFixedLength();
            entity.Property(e => e.Email).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
