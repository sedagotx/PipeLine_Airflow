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
    public static void BuildPersonalDataTable(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblPersonalData>(entity =>
        {
            entity.HasKey(e => e.PersonalDataId).HasName("personal_data_pkey");
            entity.Property(e => e.PersonalDataId).HasDefaultValueSql("uuid_generate_v4()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("true");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });
    }
}