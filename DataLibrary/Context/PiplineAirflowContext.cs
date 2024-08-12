using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DataLibrary.ModelBuilders;
using System.Security.AccessControl;

namespace DataLibrary.Context;

public partial class PiplineAirflowContext :DbContext
{
    public PiplineAirflowContext()
    {
    }

    public PiplineAirflowContext(DbContextOptions<PiplineAirflowContext> options)
        : base(options)
    {
    }
    public DbSet<LoadData> LoadDatas { get; set; }
    public virtual DbSet<tblAirflowServer> tblAirflowServers { get; set; }
    public virtual DbSet<tblPersonalData> tblPersonalDatas { get; set; }
    public virtual DbSet<tblDataClassificationLevel> tblDataClassificationLevels { get; set; }
    public virtual DbSet<tblContainerType> tblContainerTypes { get; set; }
    public virtual DbSet<tblSourceType> tblSourceTypes { get; set; }
    public virtual DbSet<tblDataDescription> tblDataDescriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_stat_statements");

        modelBuilder.BuildAirflowServerTable();
        modelBuilder.BuildPersonalDataTable();
        modelBuilder.BuildContainerTypeTable();
        modelBuilder.BuildDataClassoficationLevelTable();   
        modelBuilder.BuildDataDescriptionTable();
        modelBuilder.BuildSourceTypeTable();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

