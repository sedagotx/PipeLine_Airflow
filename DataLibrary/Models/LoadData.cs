using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models;

public class LoadData
{
    [Key]
    [Column("data_description_id")]
    public Guid DataDescriptionId { get; set; }

    [Column("data_description")]
    public string DataDescriptions { get; set; } = null!;

    [Column("title")]
    public string Title { get; set; } = null!;

    [Column("data_upload_status")]
    public string DataUploadStatus { get; set; } = null!;

    [Column("status")]
    public string Status { get; set; } = null!;

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_by")]
    [StringLength(12)]
    public string UpdatedBy { get; set; } = null!;
}
