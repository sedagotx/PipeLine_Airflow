using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public partial class ContainerTypeModel
{
    public Guid ContainerTypeId { get; set; }
    public string? ContainerTypeName { get; set; }
    public bool IsActive { get; set; }
    public string? CreatedBy { get; set; } 
    public DateTime CreatedAt { get; set; }
}
