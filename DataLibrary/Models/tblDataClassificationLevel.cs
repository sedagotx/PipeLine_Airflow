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

[Table("data_classification_level")]
[Index("DataClassificationLevelId", Name = "data_classification_level_id_key", IsUnique = true)]
public partial class tblDataClassificationLevel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("data_classification_level_id")]
    public Guid DataClassificationLevelId { get; set; }

    [Column("data_classification_level")]
    public string DataClassificationLevelName { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

}
