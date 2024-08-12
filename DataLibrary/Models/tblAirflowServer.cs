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

[Table("airflow_server")]
[Index("AirflowServerId", Name = "airflow_server_id_key", IsUnique = true)]
public partial class tblAirflowServer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("airflow_server_id")]
    public Guid AirflowServerId { get; set; }

    [Column("airflow_server_name")]
    public string AirflowServerName { get; set; } = null!;

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    [StringLength(12)]
    public string CreatedBy { get; set; } = null!;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
