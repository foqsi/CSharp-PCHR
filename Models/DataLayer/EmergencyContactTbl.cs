using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis_FinalProject_Cs.Models.DataLayer
{
    public partial class EmergencyContactTbl
    {
        [Key]
        [Column("PATIENT_ID")]
        [StringLength(10)]
        public string PatientId { get; set; } = null!;

        [Column("LAST_NAME")]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [Column("FIRST_NAME")]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Column("RELATIONSHIP")]
        [StringLength(20)]
        public string Relationship { get; set; } = null!;

        [Column("ADDRESS_STREET")]
        [StringLength(50)]
        public string? AddressStreet { get; set; }

        [Column("ADDRESS_SUBURB")]
        [StringLength(20)]
        public string? AddressSuburb { get; set; }

        [Column("ADDRESS_CITY")]
        [StringLength(20)]
        public string? AddressCity { get; set; }

        [Column("ADDRESS_ZIP")]
        [StringLength(10)]
        public string? AddressZip { get; set; }

        [Column("PHONE_HOME")]
        [StringLength(10)]
        public string? PhoneHome { get; set; }

        [Column("PHONE_MOBILE")]
        [StringLength(10)]
        public string? PhoneMobile { get; set; }

        [Column("PHONE_WORK")]
        [StringLength(10)]
        public string? PhoneWork { get; set; }

        [Column("FAX")]
        [StringLength(10)]
        public string? Fax { get; set; }

        [Column("EMAIL")]
        [StringLength(50)]
        public string? Email { get; set; }
    }
}
