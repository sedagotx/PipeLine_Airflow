using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ModelBuilders;

public static partial class ModelBuilderEx
{
    public static void BuildSourceTypeTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblSourceType>(entity =>
        {
            entity.HasKey(e => e.SourceTypeId).HasName("source_type_pkey");
            entity.Property(e => e.SourceTypeId).HasDefaultValueSql("uuid_generate_v4()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("true");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}