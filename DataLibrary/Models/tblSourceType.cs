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

[Table("source_type")]
[Index("SourceTypeId", Name = "source_type_id_key", IsUnique = true)]
public partial class tblSourceType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("source_type_id")]
    public Guid SourceTypeId { get; set; }

    [Column("source_type_name")]
    public string SourceTypeName { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

}
