using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "ConditionId")]
[Table("CONDITION")]
public partial class Condition
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("CONDITION_ID")]
    [StringLength(10)]
    public string ConditionId { get; set; } = null!;

    [Column("CONDITION")]
    [StringLength(50)]
    public string Condition1 { get; set; } = null!;

    [Column("ONSET_DATE")]
    public DateOnly OnsetDate { get; set; }

    [Column("ACUTE")]
    public bool Acute { get; set; }

    [Column("CHRONIC")]
    public bool Chronic { get; set; }

    [Column("NOTE")]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("Conditions")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
