using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "MedId")]
[Table("MEDICATION_TBL")]
public partial class MedicationTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("MED_ID")]
    [StringLength(10)]
    public string MedId { get; set; } = null!;

    [Column("MEDICATION")]
    [StringLength(50)]
    public string Medication { get; set; } = null!;

    [Column("DATE")]
    public DateOnly Date { get; set; }

    [Column("CHRONIC")]
    public bool Chronic { get; set; }

    [Column("NOTE")]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("MedicationTbls")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
