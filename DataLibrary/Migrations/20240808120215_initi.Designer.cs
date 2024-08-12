﻿// <auto-generated />
using System;
using DataLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLibrary.Migrations
{
    [DbContext(typeof(PiplineAirflowContext))]
    [Migration("20240808120215_initi")]
    partial class initi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pg_stat_statements");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataLibrary.Models.LoadData", b =>
                {
                    b.Property<Guid>("DataDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("data_description_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<string>("DataDescriptions")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_description");

                    b.Property<string>("DataUploadStatus")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_upload_status");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("updated_by");

                    b.HasKey("DataDescriptionId");

                    b.ToTable("LoadDatas");
                });

            modelBuilder.Entity("DataLibrary.Models.tblAirflowServer", b =>
                {
                    b.Property<Guid>("AirflowServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("airflow_server_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("AirflowServerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("airflow_server_name");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.HasKey("AirflowServerId")
                        .HasName("airflow_server_pkey");

                    b.HasIndex(new[] { "AirflowServerId" }, "airflow_server_id_key")
                        .IsUnique();

                    b.ToTable("airflow_server");
                });

            modelBuilder.Entity("DataLibrary.Models.tblContainerType", b =>
                {
                    b.Property<Guid>("ContainerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("container_type_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("ContainerTypeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("container_type_name");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.HasKey("ContainerTypeId")
                        .HasName("container_type_pkey");

                    b.HasIndex(new[] { "ContainerTypeId" }, "container_type_id_key")
                        .IsUnique();

                    b.ToTable("container_type");
                });

            modelBuilder.Entity("DataLibrary.Models.tblDataClassificationLevel", b =>
                {
                    b.Property<Guid>("DataClassificationLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("data_classification_level_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<string>("DataClassificationLevelName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_classification_level");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.HasKey("DataClassificationLevelId")
                        .HasName("data_classification_level_pkey");

                    b.HasIndex(new[] { "DataClassificationLevelId" }, "data_classification_level_id_key")
                        .IsUnique();

                    b.ToTable("data_classification_level");
                });

            modelBuilder.Entity("DataLibrary.Models.tblDataDescription", b =>
                {
                    b.Property<Guid>("DataDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("data_description_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<string>("DataDescriptions")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_description");

                    b.Property<string>("DataUploadStatus")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_upload_status");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("DataDescriptionId")
                        .HasName("data_description_pkey");

                    b.HasIndex(new[] { "DataDescriptionId" }, "data_description_id_key")
                        .IsUnique();

                    b.ToTable("data_description");
                });

            modelBuilder.Entity("DataLibrary.Models.tblPersonalData", b =>
                {
                    b.Property<Guid>("PersonalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("personal_data_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.Property<string>("PersonalDataName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("personal_data");

                    b.HasKey("PersonalDataId")
                        .HasName("personal_data_pkey");

                    b.HasIndex(new[] { "PersonalDataId" }, "personal_data_id_key")
                        .IsUnique();

                    b.ToTable("personal_data");
                });

            modelBuilder.Entity("DataLibrary.Models.tblSourceType", b =>
                {
                    b.Property<Guid>("SourceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("source_type_id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("created_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("isActive")
                        .HasDefaultValueSql("true");

                    b.Property<string>("SourceTypeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("source_type_name");

                    b.HasKey("SourceTypeId")
                        .HasName("source_type_pkey");

                    b.HasIndex(new[] { "SourceTypeId" }, "source_type_id_key")
                        .IsUnique();

                    b.ToTable("source_type");
                });
#pragma warning restore 612, 618
        }
    }
}
