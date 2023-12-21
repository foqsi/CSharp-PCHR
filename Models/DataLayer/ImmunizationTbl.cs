using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "ImmunizationId")]
[Table("IMMUNIZATION_TBL")]
public partial class ImmunizationTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("IMMUNIZATION_ID")]
    [StringLength(10)]
    public string ImmunizationId { get; set; } = null!;

    [Column("IMMUNIZATION")]
    [StringLength(50)]
    public string Immunization { get; set; } = null!;

    [Column("DATE")]
    public DateOnly Date { get; set; }

    [Column("NOTE")]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("ImmunizationTbls")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
