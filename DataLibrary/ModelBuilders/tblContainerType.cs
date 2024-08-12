using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ModelBuilders;

public static partial class ModelBuilderEx
{
    public static void BuildContainerTypeTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblContainerType>(entity =>
        {
            entity.HasKey(e => e.ContainerTypeId).HasName("container_type_pkey");
            entity.Property(e => e.ContainerTypeId).HasDefaultValueSql("uuid_generate_v4()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("true");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}
