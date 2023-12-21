using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[Table("PRIMARY_CARE_TBL")]
public partial class PrimaryCareTbl
{
    [Key]
    [Column("PRIMARY_ID")]
    [StringLength(10)]
    public string PrimaryId { get; set; } = null!;

    [Column("PRIMARY_CARE_PROVIDER_ID")]
    [StringLength(10)]
    public string PrimaryCareProviderId { get; set; } = null!;

    [Column("NAME_LAST")]
    [StringLength(10)]
    public string? NameLast { get; set; }

    [Column("NAME_FISRT")]
    [StringLength(10)]
    public string? NameFisrt { get; set; }

    [Column("TITLE")]
    [StringLength(10)]
    public string? Title { get; set; }

    [Column("SPECIALTY")]
    [StringLength(10)]
    public string? Specialty { get; set; }

    [Column("PHONE_OFFICE")]
    [StringLength(10)]
    public string? PhoneOffice { get; set; }

    [Column("PHONE_MOBILE")]
    [StringLength(10)]
    public string? PhoneMobile { get; set; }

    [InverseProperty("PrimaryCareProvider")]
    public virtual ICollection<PatientTbl> Patients { get; set; } = new List<PatientTbl>();
}
