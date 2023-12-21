using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.Models.DataLayer;

[PrimaryKey("PatientId", "AllergyId")]
[Table("ALLERGY_TBL")]
public partial class AllergyTbl
{
    [Key]
    [Column("PATIENT_ID")]
    [StringLength(10)]
    public string PatientId { get; set; } = null!;

    [Key]
    [Column("ALLERGY_ID")]
    [StringLength(10)]
    public string AllergyId { get; set; } = null!;

    [Column("ALLERGEN")]
    [StringLength(50)]
    public string Allergen { get; set; } = null!;

    [Column("ONSET_DATE")]
    public DateOnly OnsetDate { get; set; }

    [Column("NOTE")]
    [Unicode(false)]
    public string? Note { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("AllergyTbls")]
    public virtual PatientTbl Patient { get; set; } = null!;
}
