using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
namespace DataLibrary.Models;

[Table("container_type")]
[Index("ContainerTypeId", Name = "container_type_id_key", IsUnique = true)]
public partial class tblContainerType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("container_type_id")]
    public Guid ContainerTypeId { get; set; }

    [Column("container_type_name")]
    public string ContainerTypeName { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; } 

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
      
}
