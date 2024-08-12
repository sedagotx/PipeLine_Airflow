using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    /// <inheritdoc />
    public partial class initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "airflow_servers_pkey",
                table: "tblAirflowServers");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tblAirflowServers");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "tblAirflowServers");

            migrationBuilder.RenameTable(
                name: "tblAirflowServers",
                newName: "airflow_server");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "airflow_server",
                type: "boolean",
                nullable: false,
                defaultValueSql: "true");

            migrationBuilder.AddPrimaryKey(
                name: "airflow_server_pkey",
                table: "airflow_server",
                column: "airflow_server_id");

            migrationBuilder.CreateTable(
                name: "container_type",
                columns: table => new
                {
                    container_type_id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    container_type_name = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    created_by = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("container_type_pkey", x => x.container_type_id);
                });

            migrationBuilder.CreateTable(
                name: "data_classification_level",
                columns: table => new
                {
                    data_classification_level_id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    data_classification_level = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    created_by = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("data_classification_level_pkey", x => x.data_classification_level_id);
                });

            migrationBuilder.CreateTable(
                name: "data_description",
                columns: table => new
                {
                    data_description_id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    data_description = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    data_upload_status = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    created_by = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("data_description_pkey", x => x.data_description_id);
                });

            migrationBuilder.CreateTable(
                name: "personal_data",
                columns: table => new
                {
                    personal_data_id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    personal_data = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    created_by = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("personal_data_pkey", x => x.personal_data_id);
                });

            migrationBuilder.CreateTable(
                name: "source_type",
                columns: table => new
                {
                    source_type_id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    source_type_name = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "true"),
                    created_by = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("source_type_pkey", x => x.source_type_id);
                });

            migrationBuilder.CreateIndex(
                name: "airflow_server_id_key",
                table: "airflow_server",
                column: "airflow_server_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "container_type_id_key",
                table: "container_type",
                column: "container_type_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "data_classification_level_id_key",
                table: "data_classification_level",
                column: "data_classification_level_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "data_description_id_key",
                table: "data_description",
                column: "data_description_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "personal_data_id_key",
                table: "personal_data",
                column: "personal_data_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "source_type_id_key",
                table: "source_type",
                column: "source_type_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "container_type");

            migrationBuilder.DropTable(
                name: "data_classification_level");

            migrationBuilder.DropTable(
                name: "data_description");

            migrationBuilder.DropTable(
                name: "personal_data");

            migrationBuilder.DropTable(
                name: "source_type");

            migrationBuilder.DropPrimaryKey(
                name: "airflow_server_pkey",
                table: "airflow_server");

            migrationBuilder.DropIndex(
                name: "airflow_server_id_key",
                table: "airflow_server");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "airflow_server");

            migrationBuilder.RenameTable(
                name: "airflow_server",
                newName: "tblAirflowServers");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tblAirflowServers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "updated_by",
                table: "tblAirflowServers",
                type: "character varying(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "airflow_servers_pkey",
                table: "tblAirflowServers",
                column: "airflow_server_id");
        }
    }
}
