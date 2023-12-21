using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "ProcedureId")]
[Table("MED_PROC_TBL")]
public partial class MedProcTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("PROCEDURE_ID")]
    [StringLength(10)]
    public string ProcedureId { get; set; } = null!;

    [Column("MED_PROCEDURE")]
    [StringLength(50)]
    public string MedProcedure { get; set; } = null!;

    [Column("DATE")]
    public DateOnly Date { get; set; }

    [Column("DOCTOR")]
    [StringLength(50)]
    public string Doctor { get; set; } = null!;

    [Column("NOTE")]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("MedProcTbls")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
