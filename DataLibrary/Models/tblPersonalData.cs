using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLibrary.Models;

[Table("personal_data")]
[Index("PersonalDataId", Name = "personal_data_id_key", IsUnique = true)]
public partial class tblPersonalData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("personal_data_id")]
    public Guid PersonalDataId { get; set; }

    [Column("personal_data")]
    public string PersonalDataName { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

}
