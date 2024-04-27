using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vitalpilot.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    FileTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "FileTypes",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTypes", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "NoteTypes",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteTypes", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.UniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    HostpitalSection = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Clinics_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Users_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "UniqueId");
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patiences",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patiences", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Patiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    AccessTokenHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessTokenExpiresDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RefreshTokenIdHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshTokenIdHashSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshTokenExpiresDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatienceHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "UniqueId");
                    table.ForeignKey(
                        name: "FK_Appointments_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "LabResults",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    PatienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabResults", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_LabResults_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "UniqueId");
                    table.ForeignKey(
                        name: "FK_LabResults_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "PatienceDisease",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    DiseaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatienceDisease", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_PatienceDisease_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "UniqueId");
                    table.ForeignKey(
                        name: "FK_PatienceDisease_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "PatienceNotes",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    PatiencId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoteTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoteText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatienceNotes", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_PatienceNotes_NoteTypes_NoteTypeId",
                        column: x => x.NoteTypeId,
                        principalTable: "NoteTypes",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatienceNotes_Patiences_PatiencId",
                        column: x => x.PatiencId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "Surgeries",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgeries", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Surgeries_Doctors_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Doctors",
                        principalColumn: "UniqueId");
                    table.ForeignKey(
                        name: "FK_Surgeries_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendlyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    PatienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patiences_PatienceId",
                        column: x => x.PatienceId,
                        principalTable: "Patiences",
                        principalColumn: "UniqueId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatienceId",
                table: "Appointments",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_HospitalId",
                table: "Clinics",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ClinicId",
                table: "Doctors",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_FileId",
                table: "LabResults",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_LabResults_PatienceId",
                table: "LabResults",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatienceDisease_DiseaseId",
                table: "PatienceDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatienceDisease_PatienceId",
                table: "PatienceDisease",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatienceNotes_NoteTypeId",
                table: "PatienceNotes",
                column: "NoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PatienceNotes_PatiencId",
                table: "PatienceNotes",
                column: "PatiencId");

            migrationBuilder.CreateIndex(
                name: "IX_Patiences_UserId",
                table: "Patiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatienceId",
                table: "Prescriptions",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_PatienceId",
                table: "Surgeries",
                column: "PatienceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HospitalId",
                table: "Users",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId",
                table: "UserTokens",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileTypes");

            migrationBuilder.DropTable(
                name: "LabResults");

            migrationBuilder.DropTable(
                name: "PatienceDisease");

            migrationBuilder.DropTable(
                name: "PatienceNotes");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "NoteTypes");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patiences");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
