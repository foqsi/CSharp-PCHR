using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[Table("PER_DETAILS_TBL")]
public partial class PerDetailsTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Column("BLOOD_TYPE")]
    [StringLength(10)]
    public string? BloodType { get; set; }

    [Column("ORGAN_DONOR")]
    public bool? OrganDonor { get; set; }

    [Column("HIV_STATUS")]
    public bool? HivStatus { get; set; }

    [Column("HEIGHT_INCHES")]
    public short? HeightInches { get; set; }

    [Column("WEIGHT_LBS")]
    public short? WeightLbs { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("PerDetailsTbl")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
