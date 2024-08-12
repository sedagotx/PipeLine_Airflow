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
    [Migration("20240808050556_CreateInitialDatabase")]
    partial class CreateInitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

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
#pragma warning restore 612, 618
        }
    }
}
