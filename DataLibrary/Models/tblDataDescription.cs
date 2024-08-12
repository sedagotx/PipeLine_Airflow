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

[Table("data_description")]
[Index("DataDescriptionId", Name = "data_description_id_key", IsUnique = true)]
public partial class tblDataDescription
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("data_description_id")]
    public Guid DataDescriptionId { get; set; }

    [Column("data_description")]
    public string DataDescriptions { get; set; } = null!;

    [Column("title")]
    public string Title { get; set; } = null!;

    [Column("data_upload_status")]
    public string DataUploadStatus { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
}
