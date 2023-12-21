using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "TestId")]
[Table("TEST_TBL")]
public partial class TestTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("TEST_ID")]
    [StringLength(10)]
    public string TestId { get; set; } = null!;

    [Column("TEST")]
    [StringLength(50)]
    public string Test { get; set; } = null!;

    [Column("RESULT")]
    [StringLength(50)]
    public string Result { get; set; } = null!;

    [Column("DATE")]
    public DateOnly Date { get; set; }

    [Column("NOTE")]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("TestTbls")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
