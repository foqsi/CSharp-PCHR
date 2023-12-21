using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[Table("PATIENT_TBL")]
public partial class PatientTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [ForeignKey("PrimaryCareProviderId")]
    public virtual PrimaryCareTbl PrimaryCareProvider { get; set; } = null!;

    [Column("PRIMARY_CARE_PROVIDER_ID")]
    [StringLength(10)]
    public string? PrimaryCareProviderId { get; set; }

    [Column("LAST_NAME")]
    [StringLength(20)]
    public string LastName { get; set; } = null!;

    [Column("FIRST_NAME")]
    [StringLength(20)]
    public string FirstName { get; set; } = null!;

    [Column("DATE_Of_BIRTH")]
    public DateOnly? DateOfBirth { get; set; }

    [Column("ADDRESS_STREET")]
    [StringLength(50)]
    public string? AddressStreet { get; set; }

    [Column("ADDRESS_CITY")]
    [StringLength(20)]
    public string? AddressCity { get; set; }

    [Column("ADDRESS_STATE")]
    [StringLength(20)]
    public string? AddressState { get; set; }

    [Column("ADDRESS_ZIP")]
    [StringLength(10)]
    public string? AddressZip { get; set; }

    [Column("PHONE_HOME")]
    [StringLength(10)]
    public string? PhoneHome { get; set; }

    [Column("PHONE_MOBILE")]
    [StringLength(10)]
    public string? PhoneMobile { get; set; }

    [Column("EMAIL")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("TITLE")]
    [StringLength(10)]
    public string? Title { get; set; }

    [Column("INITIALS")]
    [StringLength(10)]
    public string? Initials { get; set; }

    [Column("GENDER")]
    [StringLength(1)]
    public string? Gender { get; set; }

    [Column("PRIMARY_ID")]
    [StringLength(10)]
    public string? PrimaryId { get; set; }


    [InverseProperty("Patient")]
    public virtual ICollection<AllergyTbl> AllergyTbls { get; set; } = new List<AllergyTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();

    [InverseProperty("Patient")]
    public virtual ICollection<ImmunizationTbl> ImmunizationTbls { get; set; } = new List<ImmunizationTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<MedProcTbl> MedProcTbls { get; set; } = new List<MedProcTbl>();

    [InverseProperty("Patient")]
    public virtual ICollection<MedicationTbl> MedicationTbls { get; set; } = new List<MedicationTbl>();

    [InverseProperty("Patient")]
    public virtual PerDetailsTbl? PerDetailsTbl { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<TestTbl> TestTbls { get; set; } = new List<TestTbl>();
}
