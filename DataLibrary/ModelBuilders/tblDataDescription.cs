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
    public static void BuildDataDescriptionTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblDataDescription>(entity =>
        {
            entity.HasKey(e => e.DataDescriptionId).HasName("data_description_pkey");
            entity.Property(e => e.DataDescriptionId).HasDefaultValueSql("uuid_generate_v4()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("true");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }

}