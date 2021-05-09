using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckForMigration.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:day_of_week", "sunday,monday,tuesday,wednesday,thursday,friday,saturday");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseLangCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyText = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseLangCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CsvMapTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CsvTemplateName = table.Column<string>(type: "text", nullable: false),
                    SheetTemplateName = table.Column<string>(type: "text", nullable: false),
                    CsvValuesNumber = table.Column<int>(type: "integer", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CsvMapTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailVerificationResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Result = table.Column<string>(type: "text", nullable: true),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    Disposable = table.Column<bool>(type: "boolean", nullable: false),
                    Accept_all = table.Column<bool>(type: "boolean", nullable: false),
                    Role = table.Column<bool>(type: "boolean", nullable: false),
                    Free = table.Column<bool>(type: "boolean", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    User = table.Column<string>(type: "text", nullable: true),
                    Domain = table.Column<string>(type: "text", nullable: true),
                    Mx_record = table.Column<string>(type: "text", nullable: true),
                    Mx_domain = table.Column<string>(type: "text", nullable: true),
                    Safe_to_send = table.Column<bool>(type: "boolean", nullable: false),
                    Did_you_mean = table.Column<string>(type: "text", nullable: true),
                    Success = table.Column<bool>(type: "boolean", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailVerificationResponse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    LeadPurchasingDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IndustrySector = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Protocol = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    ScheduledForMeeting = table.Column<bool>(type: "boolean", nullable: false),
                    TemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CsvTempItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    Header = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                    ClassPropertyName = table.Column<string>(type: "text", nullable: false),
                    MapTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CsvTempItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CsvTempItem_CsvMapTemplates_MapTemplateId",
                        column: x => x.MapTemplateId,
                        principalTable: "CsvMapTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerifiedEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    VerificationResponseId = table.Column<int>(type: "integer", nullable: true),
                    VerificationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifiedEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerifiedEmails_EmailVerificationResponse_VerificationRespon~",
                        column: x => x.VerificationResponseId,
                        principalTable: "EmailVerificationResponse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    LastName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Thumbnail = table.Column<string>(type: "text", nullable: true),
                    PhotoUrl = table.Column<string>(type: "text", nullable: true),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false),
                    EnableWorkTaskSetting = table.Column<bool>(type: "boolean", nullable: false),
                    ImapPassword = table.Column<string>(type: "text", nullable: true),
                    LanguageId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_LanguageCodes_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "LanguageCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LangTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Translation = table.Column<string>(type: "text", nullable: true),
                    BaseLangId = table.Column<int>(type: "integer", nullable: false),
                    LangCodeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LangTranslations_BaseLangCodes_BaseLangId",
                        column: x => x.BaseLangId,
                        principalTable: "BaseLangCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LangTranslations_LanguageCodes_LangCodeId",
                        column: x => x.LangCodeId,
                        principalTable: "LanguageCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Appellative = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    CompanyPosition = table.Column<int>(type: "integer", nullable: false),
                    LeadId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkSheetFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldType = table.Column<int>(type: "integer", nullable: false),
                    FieldValue = table.Column<string>(type: "text", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Mandatory = table.Column<bool>(type: "boolean", nullable: false),
                    FillWithCurrentUser = table.Column<bool>(type: "boolean", nullable: false),
                    NeedValidEmail = table.Column<bool>(type: "boolean", nullable: false),
                    EmailCheckStatus = table.Column<int>(type: "integer", nullable: false),
                    WorkSheetId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSheetFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkSheetFields_WorkSheets_WorkSheetId",
                        column: x => x.WorkSheetId,
                        principalTable: "WorkSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppDynamicNavMenus",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false),
                    Multi = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    Style = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDynamicNavMenus", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_AppDynamicNavMenus_AspNetUsers_AppId",
                        column: x => x.AppId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MessageId = table.Column<string>(type: "text", nullable: true),
                    MessageIds = table.Column<List<string>>(type: "text[]", nullable: true),
                    Date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Importance = table.Column<int>(type: "integer", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    IsHtml = table.Column<bool>(type: "boolean", nullable: false),
                    NeedReadReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    NeedDeliveredReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    InReplyTo = table.Column<string>(type: "text", nullable: true),
                    Sender = table.Column<string>(type: "text", nullable: true),
                    MessageDirection = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailMessages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassDataSource = table.Column<string>(type: "text", nullable: true),
                    TemplateName = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    NeedReadReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    NeedDeliveredReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    Shared = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailTemplates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FidaUserRouteToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Token = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FidaUserRouteToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FidaUserRouteToken_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OldPassword",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    oldPasswordHash = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldPassword", x => x.id);
                    table.ForeignKey(
                        name: "FK_OldPassword_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ReportType = table.Column<int>(type: "integer", nullable: false),
                    ChartType = table.Column<int>(type: "integer", nullable: false),
                    Shared = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameId = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Flat = table.Column<string>(type: "text", nullable: true),
                    Staircase = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    County = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<int>(type: "integer", nullable: false),
                    State = table.Column<string>(type: "text", nullable: true),
                    AddressType = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    LeadId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddress_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserIdentityNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdNumber = table.Column<string>(type: "text", nullable: false),
                    IdType = table.Column<int>(type: "integer", nullable: false),
                    DocumentCopyUrl = table.Column<string>(type: "text", nullable: true),
                    DocumentThumbnail = table.Column<string>(type: "text", nullable: true),
                    IssuingDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpiringDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DocumentIssuer = table.Column<string>(type: "text", nullable: true),
                    IssuingPlace = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIdentityNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserIdentityNumber_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMailAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    MailType = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMailAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMailAddress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LastPageVisited = table.Column<string>(type: "text", nullable: true),
                    IsNavOpen = table.Column<bool>(type: "boolean", nullable: false),
                    IsNavMinified = table.Column<bool>(type: "boolean", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkSheetAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkSheetId = table.Column<int>(type: "integer", nullable: false),
                    AssigneeId = table.Column<int>(type: "integer", nullable: false),
                    UserSelectedToWork = table.Column<bool>(type: "boolean", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AssignmentReason = table.Column<string>(type: "text", nullable: false),
                    AssignmentEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AssignmentEndReason = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSheetAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkSheetAssignments_AspNetUsers_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkSheetAssignments_WorkSheets_WorkSheetId",
                        column: x => x.WorkSheetId,
                        principalTable: "WorkSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTaskParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkTaskType = table.Column<int>(type: "integer", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "integer", nullable: false),
                    ValidityStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ValidityEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    FromAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    WeekWorkDays = table.Column<int[]>(type: "integer[]", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTaskParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTaskParameter_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LangTransPage",
                columns: table => new
                {
                    langTranslationId = table.Column<int>(type: "integer", nullable: false),
                    PageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangTransPage", x => new { x.PageId, x.langTranslationId });
                    table.ForeignKey(
                        name: "FK_LangTransPage_LangTranslations_langTranslationId",
                        column: x => x.langTranslationId,
                        principalTable: "LangTranslations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LangTransPage_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryDialCode = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    NumberType = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkSheetFieldSelectItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    ItemValue = table.Column<string>(type: "text", nullable: false),
                    IsDefaultValue = table.Column<bool>(type: "boolean", nullable: false),
                    WorkSheetFieldId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSheetFieldSelectItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkSheetFieldSelectItem_WorkSheetFields_WorkSheetFieldId",
                        column: x => x.WorkSheetFieldId,
                        principalTable: "WorkSheetFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    MessageId = table.Column<string>(type: "text", nullable: true),
                    Event = table.Column<string>(type: "text", nullable: true),
                    Reason = table.Column<string>(type: "text", nullable: true),
                    Tag = table.Column<string>(type: "text", nullable: true),
                    Ip = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    From = table.Column<string>(type: "text", nullable: true),
                    TemplateId = table.Column<long>(type: "bigint", nullable: true),
                    EventRegistrationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailEvents_EmailMessages_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RawField = table.Column<byte[]>(type: "bytea", nullable: true),
                    HeaderId = table.Column<int>(type: "integer", nullable: false),
                    Field = table.Column<string>(type: "text", nullable: true),
                    Offset = table.Column<long>(type: "bigint", nullable: true),
                    RawValue = table.Column<byte[]>(type: "bytea", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailHeaders_EmailMessages_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessageFlag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MessageFlag = table.Column<int>(type: "integer", nullable: false),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessageFlag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailMessageFlag_EmailMessages_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailMessageId",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    MessageId = table.Column<string>(type: "text", nullable: true),
                    EmailMessageParentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessageId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailMessageId_EmailMessages_EmailMessageParentId",
                        column: x => x.EmailMessageParentId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailUid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    UidId = table.Column<long>(type: "bigint", nullable: false),
                    Validity = table.Column<long>(type: "bigint", nullable: false),
                    IsValid = table.Column<bool>(type: "boolean", nullable: false),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailUid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailUid_EmailMessages_Id",
                        column: x => x.Id,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportChartSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReportId = table.Column<int>(type: "integer", nullable: false),
                    LegendShape = table.Column<int>(type: "integer", nullable: false),
                    MinRadius = table.Column<double>(type: "double precision", nullable: false),
                    MaxRadius = table.Column<double>(type: "double precision", nullable: false),
                    BullFillColor = table.Column<string>(type: "text", nullable: true),
                    BearFillColor = table.Column<string>(type: "text", nullable: true),
                    EnableSolidCandles = table.Column<bool>(type: "boolean", nullable: false),
                    SplineType = table.Column<int>(type: "integer", nullable: false),
                    IsClosed = table.Column<bool>(type: "boolean", nullable: false),
                    SegmentAxis = table.Column<int>(type: "integer", nullable: false),
                    StackingGroup = table.Column<string>(type: "text", nullable: true),
                    ColumnWidth = table.Column<double>(type: "double precision", nullable: false),
                    ColumnSpacing = table.Column<double>(type: "double precision", nullable: false),
                    CardinalSplineTension = table.Column<double>(type: "double precision", nullable: false),
                    TooltipMappingName = table.Column<string>(type: "text", nullable: true),
                    IntermediateSumIndexes = table.Column<double[]>(type: "double precision[]", nullable: true),
                    SumIndexes = table.Column<double[]>(type: "double precision[]", nullable: true),
                    SummaryFillColor = table.Column<string>(type: "text", nullable: true),
                    NegativeFillColor = table.Column<string>(type: "text", nullable: true),
                    ShowNormalDistribution = table.Column<bool>(type: "boolean", nullable: false),
                    BinInterval = table.Column<double>(type: "double precision", nullable: false),
                    BoxPlotMode = table.Column<int>(type: "integer", nullable: false),
                    ShowMean = table.Column<bool>(type: "boolean", nullable: false),
                    SelectionStyle = table.Column<string>(type: "text", nullable: true),
                    UnSelectedStyle = table.Column<string>(type: "text", nullable: true),
                    NonHighlightStyle = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Visible = table.Column<bool>(type: "boolean", nullable: false),
                    Width = table.Column<double>(type: "double precision", nullable: false),
                    XAxisName = table.Column<string>(type: "text", nullable: true),
                    XName = table.Column<string>(type: "text", nullable: true),
                    YAxisName = table.Column<string>(type: "text", nullable: true),
                    YName = table.Column<string>(type: "text", nullable: true),
                    High = table.Column<string>(type: "text", nullable: true),
                    Low = table.Column<string>(type: "text", nullable: true),
                    HighlightStyle = table.Column<string>(type: "text", nullable: true),
                    Close = table.Column<string>(type: "text", nullable: true),
                    Volume = table.Column<string>(type: "text", nullable: true),
                    Open = table.Column<string>(type: "text", nullable: true),
                    ZOrder = table.Column<int>(type: "integer", nullable: false),
                    Opacity = table.Column<double>(type: "double precision", nullable: false),
                    DashArray = table.Column<string>(type: "text", nullable: true),
                    Size = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TooltipFormat = table.Column<string>(type: "text", nullable: true),
                    PointColorMapping = table.Column<string>(type: "text", nullable: true),
                    EnableComplexProperty = table.Column<bool>(type: "boolean", nullable: false),
                    DrawType = table.Column<int>(type: "integer", nullable: false),
                    Fill = table.Column<string>(type: "text", nullable: true),
                    EnableTooltip = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportChartSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportChartSeries_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ReportId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportRole", x => new { x.ReportId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ReportRole_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportRole_Reports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkWindow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<TimeSpan>(type: "interval", nullable: false),
                    End = table.Column<TimeSpan>(type: "interval", nullable: false),
                    WorkTaskParameterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkWindow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkWindow_WorkTaskParameter_WorkTaskParameterId",
                        column: x => x.WorkTaskParameterId,
                        principalTable: "WorkTaskParameter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NavMenuItems",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false),
                    Href = table.Column<string>(type: "text", nullable: true),
                    Disabled = table.Column<bool>(type: "boolean", nullable: false),
                    AllowSection = table.Column<bool>(type: "boolean", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    AppDynamicNavMenuAppId = table.Column<int>(type: "integer", nullable: true),
                    SubMenuListAppId = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    Style = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavMenuItems", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_NavMenuItems_AppDynamicNavMenus_AppDynamicNavMenuAppId",
                        column: x => x.AppDynamicNavMenuAppId,
                        principalTable: "AppDynamicNavMenus",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubMenus",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Selected = table.Column<bool>(type: "boolean", nullable: false),
                    Expanded = table.Column<bool>(type: "boolean", nullable: false),
                    AppDynamicNavMenuAppId = table.Column<int>(type: "integer", nullable: true),
                    SubMenuListAppId1 = table.Column<int>(type: "integer", nullable: true),
                    Id = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    Style = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenus", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_SubMenus_AppDynamicNavMenus_AppDynamicNavMenuAppId",
                        column: x => x.AppDynamicNavMenuAppId,
                        principalTable: "AppDynamicNavMenus",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubMenuHeaders",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    Style = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenuHeaders", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_SubMenuHeaders_SubMenus_AppId",
                        column: x => x.AppId,
                        principalTable: "SubMenus",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubMenuLists",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: true),
                    Style = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenuLists", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_SubMenuLists_SubMenus_AppId",
                        column: x => x.AppId,
                        principalTable: "SubMenus",
                        principalColumn: "AppId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmkTemplateRole",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkTemplateRole", x => new { x.TemplateId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_TmkTemplateRole_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FidaVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Selected = table.Column<bool>(type: "boolean", nullable: false),
                    StartCoordinates = table.Column<double[]>(type: "double precision[]", nullable: true),
                    EndCoordinates = table.Column<double[]>(type: "double precision[]", nullable: true),
                    VehicleProfile = table.Column<int>(type: "integer", nullable: false),
                    WorkStart = table.Column<TimeSpan>(type: "interval", nullable: false),
                    WorkEnd = table.Column<TimeSpan>(type: "interval", nullable: false),
                    BreakDuration = table.Column<int>(type: "integer", nullable: false),
                    BreakStart = table.Column<TimeSpan>(type: "interval", nullable: false),
                    BreakEnd = table.Column<TimeSpan>(type: "interval", nullable: false),
                    ValidityStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ValidityEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    StartAddressId = table.Column<int>(type: "integer", nullable: false),
                    EndAddressId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FidaVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FidaVehicles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RouteAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Locality = table.Column<string>(type: "text", nullable: true),
                    Postalcode = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    FidaVeichleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteAddress_FidaVehicles_FidaVeichleId",
                        column: x => x.FidaVeichleId,
                        principalTable: "FidaVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DueOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    End = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    TaskType = table.Column<int>(type: "integer", nullable: false),
                    WtChanged = table.Column<bool>(type: "boolean", nullable: false),
                    TemplateId = table.Column<int>(type: "integer", nullable: false),
                    EmailTemplateId = table.Column<int>(type: "integer", nullable: true),
                    WorkSheetId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkTasks_WorkSheets_WorkSheetId",
                        column: x => x.WorkSheetId,
                        principalTable: "WorkSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAutomations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TriggerEvent = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAutomations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAutomations_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldType = table.Column<int>(type: "integer", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldValue = table.Column<string>(type: "text", nullable: true),
                    WorkTaskId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskField_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WtEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Importance = table.Column<int>(type: "integer", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    NeedReadReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    NeedDeliveredReceipt = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionCleared = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionClearedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Executed = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MessageId = table.Column<string>(type: "text", nullable: true),
                    MessageIds = table.Column<List<string>>(type: "text[]", nullable: true),
                    WorkTaskId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WtEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WtEmails_WorkTasks_WorkTaskId",
                        column: x => x.WorkTaskId,
                        principalTable: "WorkTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WT_Action",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActionType = table.Column<int>(type: "integer", nullable: false),
                    Delay = table.Column<double>(type: "double precision", nullable: false),
                    ClassType = table.Column<string>(type: "text", nullable: true),
                    ClassPropertyName = table.Column<string>(type: "text", nullable: true),
                    ClassPropertyValue = table.Column<string>(type: "text", nullable: true),
                    EmailTemplateId = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskType = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskTemplateId = table.Column<int>(type: "integer", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Executed = table.Column<bool>(type: "boolean", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TaskAutomationId = table.Column<int>(type: "integer", nullable: false),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WT_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WT_Action_EmailMessages_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WT_Action_TaskAutomations_TaskAutomationId",
                        column: x => x.TaskAutomationId,
                        principalTable: "TaskAutomations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    ToEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    FromEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    BccEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    CcEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    ReplyToEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true),
                    ToWtEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    FromWtEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    BccWtEmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    CcWtEmailMessageId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAddress_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailMessages_BccEmailMessageId",
                        column: x => x.BccEmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailMessages_CcEmailMessageId",
                        column: x => x.CcEmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailMessages_FromEmailMessageId",
                        column: x => x.FromEmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailMessages_ReplyToEmailMessageId",
                        column: x => x.ReplyToEmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_EmailMessages_ToEmailMessageId",
                        column: x => x.ToEmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAddress_WtEmails_BccWtEmailMessageId",
                        column: x => x.BccWtEmailMessageId,
                        principalTable: "WtEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailAddress_WtEmails_CcWtEmailMessageId",
                        column: x => x.CcWtEmailMessageId,
                        principalTable: "WtEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailAddress_WtEmails_FromWtEmailMessageId",
                        column: x => x.FromWtEmailMessageId,
                        principalTable: "WtEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailAddress_WtEmails_ToWtEmailMessageId",
                        column: x => x.ToWtEmailMessageId,
                        principalTable: "WtEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileNameUrl = table.Column<string>(type: "text", nullable: true),
                    FileFullPath = table.Column<string>(type: "text", nullable: true),
                    FileUrl = table.Column<string>(type: "text", nullable: true),
                    MediaType = table.Column<string>(type: "text", nullable: true),
                    MediaSubType = table.Column<string>(type: "text", nullable: true),
                    FileDataBytes = table.Column<byte[]>(type: "bytea", nullable: true),
                    EmailMessageId = table.Column<int>(type: "integer", nullable: true),
                    EmailTemplateId = table.Column<int>(type: "integer", nullable: true),
                    WtEmailId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAttachments_EmailMessages_EmailMessageId",
                        column: x => x.EmailMessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAttachments_EmailTemplates_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailAttachments_WtEmails_WtEmailId",
                        column: x => x.WtEmailId,
                        principalTable: "WtEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatorName = table.Column<string>(type: "text", nullable: true),
                    ModifierName = table.Column<string>(type: "text", nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CsvMapTemplateId = table.Column<int>(type: "integer", nullable: true),
                    TmkSheetTemplateId = table.Column<int>(type: "integer", nullable: true),
                    WorkSheetAssignmentId = table.Column<int>(type: "integer", nullable: true),
                    WorkSheetId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracer_CsvMapTemplates_CsvMapTemplateId",
                        column: x => x.CsvMapTemplateId,
                        principalTable: "CsvMapTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracer_WorkSheetAssignments_WorkSheetAssignmentId",
                        column: x => x.WorkSheetAssignmentId,
                        principalTable: "WorkSheetAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracer_WorkSheets_WorkSheetId",
                        column: x => x.WorkSheetId,
                        principalTable: "WorkSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmkSheetTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    FinalTaskType = table.Column<int>(type: "integer", nullable: false),
                    ProtNumTempId = table.Column<int>(type: "integer", nullable: true),
                    RouteAddressMapId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkSheetTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentReason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReasonText = table.Column<string>(type: "text", nullable: false),
                    ReasonValue = table.Column<string>(type: "text", nullable: false),
                    TmkSheetTemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentReason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignmentReason_TmkSheetTemplates_TmkSheetTemplateId",
                        column: x => x.TmkSheetTemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProtocolTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProtocolType = table.Column<int>(type: "integer", nullable: false),
                    Prefix = table.Column<string>(type: "text", nullable: true),
                    Suffix = table.Column<string>(type: "text", nullable: true),
                    ProtProgNumber = table.Column<int>(type: "integer", nullable: false),
                    TemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtocolTemplate_TmkSheetTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RouteAddressMap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressMapFieldName = table.Column<string>(type: "text", nullable: true),
                    CountryMapFieldName = table.Column<string>(type: "text", nullable: true),
                    PostalcodeMapFieldName = table.Column<string>(type: "text", nullable: true),
                    LocalityMapFieldName = table.Column<string>(type: "text", nullable: true),
                    TmkTemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteAddressMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteAddressMap_TmkSheetTemplates_TmkTemplateId",
                        column: x => x.TmkTemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmkLayoutTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LayoutName = table.Column<string>(type: "text", nullable: true),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    TmkTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkLayoutTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TmkLayoutTemplates_TmkSheetTemplates_TmkTemplateId",
                        column: x => x.TmkTemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmkSheetFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldType = table.Column<int>(type: "integer", nullable: false),
                    DefaultValue = table.Column<string>(type: "text", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Mandatory = table.Column<bool>(type: "boolean", nullable: false),
                    FillWithCurrentUser = table.Column<bool>(type: "boolean", nullable: false),
                    NeedValidEmail = table.Column<bool>(type: "boolean", nullable: false),
                    ReadOnly = table.Column<bool>(type: "boolean", nullable: false),
                    SheetTemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkSheetFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TmkSheetFields_TmkSheetTemplates_SheetTemplateId",
                        column: x => x.SheetTemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkTaskTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskTemplateName = table.Column<string>(type: "text", nullable: true),
                    TaskType = table.Column<int>(type: "integer", nullable: false),
                    TmkSheetTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTaskTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTaskTemplates_TmkSheetTemplates_TmkSheetTemplateId",
                        column: x => x.TmkSheetTemplateId,
                        principalTable: "TmkSheetTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TmkLayoutRow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    TmkLayoutId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkLayoutRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TmkLayoutRow_TmkLayoutTemplates_TmkLayoutId",
                        column: x => x.TmkLayoutId,
                        principalTable: "TmkLayoutTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmkFieldSelectValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    ItemValue = table.Column<string>(type: "text", nullable: false),
                    IsDefaultValue = table.Column<bool>(type: "boolean", nullable: false),
                    TmkSheetFieldId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkFieldSelectValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TmkFieldSelectValue_TmkSheetFields_TmkSheetFieldId",
                        column: x => x.TmkSheetFieldId,
                        principalTable: "TmkSheetFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskAutomationTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TriggerEvent = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAutomationTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAutomationTemplate_WorkTaskTemplates_WorkTaskTemplateId",
                        column: x => x.WorkTaskTemplateId,
                        principalTable: "WorkTaskTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskFieldTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldType = table.Column<int>(type: "integer", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    FieldValue = table.Column<string>(type: "text", nullable: true),
                    Mandatory = table.Column<bool>(type: "boolean", nullable: false),
                    MandatoryForResult = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    FillWithCurrentUser = table.Column<bool>(type: "boolean", nullable: false),
                    NeedValidEmail = table.Column<bool>(type: "boolean", nullable: false),
                    ReadOnly = table.Column<bool>(type: "boolean", nullable: false),
                    WorkTaskTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskFieldTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskFieldTemplate_WorkTaskTemplates_WorkTaskTemplateId",
                        column: x => x.WorkTaskTemplateId,
                        principalTable: "WorkTaskTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TmkLayoutColumn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldName = table.Column<string>(type: "text", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    ColumnSize = table.Column<int>(type: "integer", nullable: false),
                    LayoutRowId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TmkLayoutColumn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TmkLayoutColumn_TmkLayoutRow_LayoutRowId",
                        column: x => x.LayoutRowId,
                        principalTable: "TmkLayoutRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WT_ActionTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActionType = table.Column<int>(type: "integer", nullable: false),
                    Delay = table.Column<double>(type: "double precision", nullable: false),
                    ClassType = table.Column<string>(type: "text", nullable: true),
                    ClassPropertyName = table.Column<string>(type: "text", nullable: true),
                    ClassPropertyValue = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    EmailTemplateId = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskType = table.Column<int>(type: "integer", nullable: false),
                    WorkTaskTemplateId = table.Column<int>(type: "integer", nullable: false),
                    TaskAutomationTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WT_ActionTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WT_ActionTemplate_TaskAutomationTemplate_TaskAutomationTemp~",
                        column: x => x.TaskAutomationTemplateId,
                        principalTable: "TaskAutomationTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDropItemTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    ItemValue = table.Column<string>(type: "text", nullable: false),
                    IsDefaultValue = table.Column<bool>(type: "boolean", nullable: false),
                    TaskFieldTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDropItemTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDropItemTemplate_TaskFieldTemplate_TaskFieldTemplateId",
                        column: x => x.TaskFieldTemplateId,
                        principalTable: "TaskFieldTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentReason_TmkSheetTemplateId",
                table: "AssignmentReason",
                column: "TmkSheetTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_LeadId",
                table: "Contact",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_CsvTempItem_MapTemplateId",
                table: "CsvTempItem",
                column: "MapTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_BccEmailMessageId",
                table: "EmailAddress",
                column: "BccEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_BccWtEmailMessageId",
                table: "EmailAddress",
                column: "BccWtEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_CcEmailMessageId",
                table: "EmailAddress",
                column: "CcEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_CcWtEmailMessageId",
                table: "EmailAddress",
                column: "CcWtEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_ContactId",
                table: "EmailAddress",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_FromEmailMessageId",
                table: "EmailAddress",
                column: "FromEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_FromWtEmailMessageId",
                table: "EmailAddress",
                column: "FromWtEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_ReplyToEmailMessageId",
                table: "EmailAddress",
                column: "ReplyToEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_ToEmailMessageId",
                table: "EmailAddress",
                column: "ToEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_ToWtEmailMessageId",
                table: "EmailAddress",
                column: "ToWtEmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachments_EmailMessageId",
                table: "EmailAttachments",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachments_EmailTemplateId",
                table: "EmailAttachments",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachments_WtEmailId",
                table: "EmailAttachments",
                column: "WtEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailEvents_EmailMessageId",
                table: "EmailEvents",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailHeaders_EmailMessageId",
                table: "EmailHeaders",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessageFlag_EmailMessageId",
                table: "EmailMessageFlag",
                column: "EmailMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessageId_EmailMessageParentId",
                table: "EmailMessageId",
                column: "EmailMessageParentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_UserId",
                table: "EmailMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_UserId",
                table: "EmailTemplates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FidaUserRouteToken_UserId",
                table: "FidaUserRouteToken",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FidaVehicles_EndAddressId",
                table: "FidaVehicles",
                column: "EndAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FidaVehicles_StartAddressId",
                table: "FidaVehicles",
                column: "StartAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FidaVehicles_UserId",
                table: "FidaVehicles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LangTranslations_BaseLangId",
                table: "LangTranslations",
                column: "BaseLangId");

            migrationBuilder.CreateIndex(
                name: "IX_LangTranslations_LangCodeId",
                table: "LangTranslations",
                column: "LangCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_LangTransPage_langTranslationId",
                table: "LangTransPage",
                column: "langTranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_NavMenuItems_AppDynamicNavMenuAppId",
                table: "NavMenuItems",
                column: "AppDynamicNavMenuAppId");

            migrationBuilder.CreateIndex(
                name: "IX_NavMenuItems_SubMenuListAppId",
                table: "NavMenuItems",
                column: "SubMenuListAppId");

            migrationBuilder.CreateIndex(
                name: "IX_OldPassword_UserId",
                table: "OldPassword",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ContactId",
                table: "PhoneNumber",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_UserId",
                table: "PhoneNumber",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolTemplate_TemplateId",
                table: "ProtocolTemplate",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportChartSeries_ReportId",
                table: "ReportChartSeries",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportRole_RoleId",
                table: "ReportRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteAddress_FidaVeichleId",
                table: "RouteAddress",
                column: "FidaVeichleId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteAddressMap_TmkTemplateId",
                table: "RouteAddressMap",
                column: "TmkTemplateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_AppDynamicNavMenuAppId",
                table: "SubMenus",
                column: "AppDynamicNavMenuAppId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_SubMenuListAppId1",
                table: "SubMenus",
                column: "SubMenuListAppId1");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAutomations_WorkTaskId",
                table: "TaskAutomations",
                column: "WorkTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAutomationTemplate_WorkTaskTemplateId",
                table: "TaskAutomationTemplate",
                column: "WorkTaskTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDropItemTemplate_TaskFieldTemplateId",
                table: "TaskDropItemTemplate",
                column: "TaskFieldTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskField_WorkTaskId",
                table: "TaskField",
                column: "WorkTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskFieldTemplate_WorkTaskTemplateId",
                table: "TaskFieldTemplate",
                column: "WorkTaskTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkFieldSelectValue_TmkSheetFieldId",
                table: "TmkFieldSelectValue",
                column: "TmkSheetFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkLayoutColumn_LayoutRowId",
                table: "TmkLayoutColumn",
                column: "LayoutRowId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkLayoutRow_TmkLayoutId",
                table: "TmkLayoutRow",
                column: "TmkLayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkLayoutTemplates_TmkTemplateId",
                table: "TmkLayoutTemplates",
                column: "TmkTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkSheetFields_SheetTemplateId",
                table: "TmkSheetFields",
                column: "SheetTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkSheetTemplates_ProtNumTempId",
                table: "TmkSheetTemplates",
                column: "ProtNumTempId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkSheetTemplates_RouteAddressMapId",
                table: "TmkSheetTemplates",
                column: "RouteAddressMapId");

            migrationBuilder.CreateIndex(
                name: "IX_TmkTemplateRole_RoleId",
                table: "TmkTemplateRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracer_CsvMapTemplateId",
                table: "Tracer",
                column: "CsvMapTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracer_TmkSheetTemplateId",
                table: "Tracer",
                column: "TmkSheetTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracer_WorkSheetAssignmentId",
                table: "Tracer",
                column: "WorkSheetAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracer_WorkSheetId",
                table: "Tracer",
                column: "WorkSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_LeadId",
                table: "UserAddress",
                column: "LeadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIdentityNumber_UserId",
                table: "UserIdentityNumber",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMailAddress_UserId",
                table: "UserMailAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserId",
                table: "UserProfile",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VerifiedEmails_VerificationResponseId",
                table: "VerifiedEmails",
                column: "VerificationResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkSheetAssignments_AssigneeId",
                table: "WorkSheetAssignments",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkSheetAssignments_WorkSheetId",
                table: "WorkSheetAssignments",
                column: "WorkSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkSheetFields_WorkSheetId",
                table: "WorkSheetFields",
                column: "WorkSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkSheetFieldSelectItem_WorkSheetFieldId",
                table: "WorkSheetFieldSelectItem",
                column: "WorkSheetFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTaskParameter_UserId",
                table: "WorkTaskParameter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_TemplateId",
                table: "WorkTasks",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_UserId",
                table: "WorkTasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTasks_WorkSheetId",
                table: "WorkTasks",
                column: "WorkSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTaskTemplates_TmkSheetTemplateId",
                table: "WorkTaskTemplates",
                column: "TmkSheetTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkWindow_WorkTaskParameterId",
                table: "WorkWindow",
                column: "WorkTaskParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_WT_Action_EmailMessageId",
                table: "WT_Action",
                column: "EmailMessageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WT_Action_TaskAutomationId",
                table: "WT_Action",
                column: "TaskAutomationId");

            migrationBuilder.CreateIndex(
                name: "IX_WT_ActionTemplate_TaskAutomationTemplateId",
                table: "WT_ActionTemplate",
                column: "TaskAutomationTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_WtEmails_WorkTaskId",
                table: "WtEmails",
                column: "WorkTaskId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NavMenuItems_SubMenuHeaders_AppId",
                table: "NavMenuItems",
                column: "AppId",
                principalTable: "SubMenuHeaders",
                principalColumn: "AppId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NavMenuItems_SubMenuLists_SubMenuListAppId",
                table: "NavMenuItems",
                column: "SubMenuListAppId",
                principalTable: "SubMenuLists",
                principalColumn: "AppId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenus_SubMenuLists_SubMenuListAppId1",
                table: "SubMenus",
                column: "SubMenuListAppId1",
                principalTable: "SubMenuLists",
                principalColumn: "AppId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmkTemplateRole_TmkSheetTemplates_TemplateId",
                table: "TmkTemplateRole",
                column: "TemplateId",
                principalTable: "TmkSheetTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FidaVehicles_RouteAddress_EndAddressId",
                table: "FidaVehicles",
                column: "EndAddressId",
                principalTable: "RouteAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FidaVehicles_RouteAddress_StartAddressId",
                table: "FidaVehicles",
                column: "StartAddressId",
                principalTable: "RouteAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTasks_WorkTaskTemplates_TemplateId",
                table: "WorkTasks",
                column: "TemplateId",
                principalTable: "WorkTaskTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracer_TmkSheetTemplates_TmkSheetTemplateId",
                table: "Tracer",
                column: "TmkSheetTemplateId",
                principalTable: "TmkSheetTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmkSheetTemplates_ProtocolTemplate_ProtNumTempId",
                table: "TmkSheetTemplates",
                column: "ProtNumTempId",
                principalTable: "ProtocolTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TmkSheetTemplates_RouteAddressMap_RouteAddressMapId",
                table: "TmkSheetTemplates",
                column: "RouteAddressMapId",
                principalTable: "RouteAddressMap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppDynamicNavMenus_AspNetUsers_AppId",
                table: "AppDynamicNavMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_FidaVehicles_AspNetUsers_UserId",
                table: "FidaVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocolTemplate_TmkSheetTemplates_TemplateId",
                table: "ProtocolTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteAddressMap_TmkSheetTemplates_TmkTemplateId",
                table: "RouteAddressMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FidaVehicles_RouteAddress_EndAddressId",
                table: "FidaVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_FidaVehicles_RouteAddress_StartAddressId",
                table: "FidaVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_SubMenus_AppDynamicNavMenus_AppDynamicNavMenuAppId",
                table: "SubMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_SubMenus_SubMenuLists_SubMenuListAppId1",
                table: "SubMenus");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssignmentReason");

            migrationBuilder.DropTable(
                name: "CsvTempItem");

            migrationBuilder.DropTable(
                name: "EmailAddress");

            migrationBuilder.DropTable(
                name: "EmailAttachments");

            migrationBuilder.DropTable(
                name: "EmailEvents");

            migrationBuilder.DropTable(
                name: "EmailHeaders");

            migrationBuilder.DropTable(
                name: "EmailMessageFlag");

            migrationBuilder.DropTable(
                name: "EmailMessageId");

            migrationBuilder.DropTable(
                name: "EmailUid");

            migrationBuilder.DropTable(
                name: "FidaUserRouteToken");

            migrationBuilder.DropTable(
                name: "LangTransPage");

            migrationBuilder.DropTable(
                name: "NavMenuItems");

            migrationBuilder.DropTable(
                name: "OldPassword");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "ReportChartSeries");

            migrationBuilder.DropTable(
                name: "ReportRole");

            migrationBuilder.DropTable(
                name: "TaskDropItemTemplate");

            migrationBuilder.DropTable(
                name: "TaskField");

            migrationBuilder.DropTable(
                name: "TmkFieldSelectValue");

            migrationBuilder.DropTable(
                name: "TmkLayoutColumn");

            migrationBuilder.DropTable(
                name: "TmkTemplateRole");

            migrationBuilder.DropTable(
                name: "Tracer");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "UserIdentityNumber");

            migrationBuilder.DropTable(
                name: "UserMailAddress");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "VerifiedEmails");

            migrationBuilder.DropTable(
                name: "WorkSheetFieldSelectItem");

            migrationBuilder.DropTable(
                name: "WorkWindow");

            migrationBuilder.DropTable(
                name: "WT_Action");

            migrationBuilder.DropTable(
                name: "WT_ActionTemplate");

            migrationBuilder.DropTable(
                name: "EmailTemplates");

            migrationBuilder.DropTable(
                name: "WtEmails");

            migrationBuilder.DropTable(
                name: "LangTranslations");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "SubMenuHeaders");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "TaskFieldTemplate");

            migrationBuilder.DropTable(
                name: "TmkSheetFields");

            migrationBuilder.DropTable(
                name: "TmkLayoutRow");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CsvMapTemplates");

            migrationBuilder.DropTable(
                name: "WorkSheetAssignments");

            migrationBuilder.DropTable(
                name: "EmailVerificationResponse");

            migrationBuilder.DropTable(
                name: "WorkSheetFields");

            migrationBuilder.DropTable(
                name: "WorkTaskParameter");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.DropTable(
                name: "TaskAutomations");

            migrationBuilder.DropTable(
                name: "TaskAutomationTemplate");

            migrationBuilder.DropTable(
                name: "BaseLangCodes");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "TmkLayoutTemplates");

            migrationBuilder.DropTable(
                name: "WorkTasks");

            migrationBuilder.DropTable(
                name: "WorkSheets");

            migrationBuilder.DropTable(
                name: "WorkTaskTemplates");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LanguageCodes");

            migrationBuilder.DropTable(
                name: "TmkSheetTemplates");

            migrationBuilder.DropTable(
                name: "ProtocolTemplate");

            migrationBuilder.DropTable(
                name: "RouteAddressMap");

            migrationBuilder.DropTable(
                name: "RouteAddress");

            migrationBuilder.DropTable(
                name: "FidaVehicles");

            migrationBuilder.DropTable(
                name: "AppDynamicNavMenus");

            migrationBuilder.DropTable(
                name: "SubMenuLists");

            migrationBuilder.DropTable(
                name: "SubMenus");
        }
    }
}
