using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.ModelBuilders;
public static partial class ModelBuilderEx
{
    public static void BuildAirflowServerTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblAirflowServer>(entity =>
        {
            entity.HasKey(e => e.AirflowServerId).HasName("airflow_server_pkey");
            entity.Property(e => e.AirflowServerId).HasDefaultValueSql("uuid_generate_v4()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("true");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}

