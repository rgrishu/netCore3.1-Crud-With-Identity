﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Whatsapp.Migrations
{
    public partial class InitiateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiRequestResponseLog",
                columns: table => new
                {
                    RequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestName = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    RequestUrl = table.Column<string>(nullable: true),
                    RequestData = table.Column<string>(nullable: true),
                    Response = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiRequestResponseLog", x => x.RequestID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WID = table.Column<int>(nullable: false),
                    IsOtp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    StateID = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProfile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    WID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    MobileNo2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailSupport = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    DeveloperKey = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    PAN = table.Column<string>(nullable: true),
                    GSTIN = table.Column<string>(nullable: true),
                    HeaderTitle = table.Column<string>(nullable: true),
                    MobileSupport = table.Column<string>(nullable: true),
                    EmailTechnical = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "EmailSetting",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    FromEmail = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    HostName = table.Column<string>(nullable: true),
                    Port = table.Column<int>(nullable: false),
                    WID = table.Column<int>(nullable: false),
                    EntryBy = table.Column<string>(nullable: true),
                    ModifyBy = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsEmailVerified = table.Column<string>(nullable: true),
                    IsSSL = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterApi",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    ApiTypeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    BaseUrl = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterApi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterApiType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    ApiTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterApiType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterMessageFormat",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    FormatType = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterMessageFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterPackage",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    PackageName = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    ValidityInDays = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPackage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterService",
                columns: table => new
                {
                    ServiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(nullable: true),
                    SCode = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsFeature = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterService", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "MasterWebsite",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    WebsiteName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    EntryBy = table.Column<int>(nullable: false),
                    ModifyBy = table.Column<int>(nullable: false),
                    IsDeactivateByAdmin = table.Column<bool>(nullable: false),
                    IsSSL = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterWebsite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    FormatID = table.Column<int>(nullable: false),
                    IsEnableSMS = table.Column<bool>(nullable: false),
                    TemplateID = table.Column<string>(nullable: true),
                    SMSTemplate = table.Column<string>(nullable: true),
                    IsEnableEmail = table.Column<bool>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    EmailTemplate = table.Column<string>(nullable: true),
                    IsEnableWhatsapp = table.Column<bool>(nullable: false),
                    WhatsappTemplate = table.Column<string>(nullable: true),
                    WID = table.Column<int>(nullable: false),
                    EntryBy = table.Column<int>(nullable: false),
                    ModifyBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendEmail",
                columns: table => new
                {
                    Int64 = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(nullable: true),
                    Recipients = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    IsSent = table.Column<bool>(nullable: false),
                    WID = table.Column<int>(nullable: false),
                    EntryDate = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendEmail", x => x.Int64);
                });

            migrationBuilder.CreateTable(
                name: "SendSms",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIID = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    TransactionID = table.Column<string>(nullable: true),
                    ResponseID = table.Column<string>(nullable: true),
                    Response = table.Column<string>(nullable: true),
                    EntryDate = table.Column<string>(nullable: true),
                    IsRead = table.Column<string>(nullable: true),
                    WID = table.Column<int>(nullable: false),
                    ModifyDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendSms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "SenderNo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsAutoReply = table.Column<bool>(nullable: false),
                    WID = table.Column<int>(nullable: false),
                    ApiID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenderNo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SenderNo_MasterApi_ApiID",
                        column: x => x.ApiID,
                        principalTable: "MasterApi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterServiceFeatures",
                columns: table => new
                {
                    FeatureID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ServiceID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterServiceFeatures", x => x.FeatureID);
                    table.ForeignKey(
                        name: "FK_MasterServiceFeatures_MasterService_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "MasterService",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsFeature = table.Column<bool>(nullable: false),
                    MasterPackageID = table.Column<long>(nullable: false),
                    ServiceID = table.Column<long>(nullable: false),
                    MasterServiceServiceID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_MasterPackage_MasterPackageID",
                        column: x => x.MasterPackageID,
                        principalTable: "MasterPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_MasterService_MasterServiceServiceID",
                        column: x => x.MasterServiceServiceID,
                        principalTable: "MasterService",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "d56d9543-b61e-4c7a-a611-ebc073d5da71", "Admin", "ADMIN" },
                    { 2, "23e0f213-c8fa-4d53-bf9b-5c6220d2e3ba", "Seller", "SELLER" },
                    { 3, "da576a70-2276-4872-a496-6765a07534e6", "ReSeller", "RESELLER" },
                    { 4, "b52abe85-ca0e-44ae-a4d0-fd1b315576ee", "WhiteLabel", "WHITELEABEL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsOtp", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "WID" },
                values: new object[] { 1, 0, "6879d998-a62e-4219-b24d-c47191f3c7a4", "admin@gmail.com", true, false, false, new DateTimeOffset(new DateTime(2022, 5, 23, 13, 55, 48, 191, DateTimeKind.Unspecified).AddTicks(6374), new TimeSpan(0, 5, 30, 0, 0)), "Admin", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAyx8BWY/9CpOotUEyCWW7oPN/2HbxyjdkQSxPku80tUrHaumc7f45SExD+xgPy9MA==", "7777777777", true, "DLE2VEKKAJXRDQLF3FHGWUKM6EO3JCZQ", false, "admin@gmail.com", 0 });

            migrationBuilder.InsertData(
                table: "CompanyProfile",
                columns: new[] { "Id", "CompanyAddress", "CreatedDate", "DeveloperKey", "Email", "EmailSupport", "EmailTechnical", "Facebook", "GSTIN", "HeaderTitle", "IPAddress", "Instagram", "MobileNo", "MobileNo2", "MobileSupport", "ModifiedDate", "Name", "PAN", "State", "Twitter", "WID" },
                values: new object[] { 1L, "3/553 Station Road Near Aryan Restaurant Vivek Khand Gomtinagar Lucknow 226010", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9c34176d6b9710399c3cf3128acc6b24", "Info@mobilet.com", "9807253370@gmail.com", "support@roundpay.in", "", "", "Mobile", null, "", "7777777777", "", "9807253370", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roundpay Techno Media Pvt Ltd", "", "NA", "", 1 });

            migrationBuilder.InsertData(
                table: "MasterApiType",
                columns: new[] { "Id", "ApiTypeName", "CreatedDate", "IPAddress", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "Whatsapp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "Email", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "SMS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MasterMessageFormat",
                columns: new[] { "Id", "CreatedDate", "FormatType", "IPAddress", "IsActive", "ModifiedDate", "Remark" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Registration", null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Registration Type" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OTP", null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OTP Type" }
                });

            migrationBuilder.InsertData(
                table: "MasterWebsite",
                columns: new[] { "Id", "CreatedDate", "EntryBy", "IPAddress", "IsActive", "IsDeactivateByAdmin", "IsSSL", "ModifiedDate", "ModifyBy", "Remark", "UserId", "WebsiteName" },
                values: new object[] { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "RoundpayWhatsapp.com", 1, "RoundpayWhatsapp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MasterServiceFeatures_ServiceID",
                table: "MasterServiceFeatures",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Package_MasterPackageID",
                table: "Package",
                column: "MasterPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Package_MasterServiceServiceID",
                table: "Package",
                column: "MasterServiceServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_SenderNo_ApiID",
                table: "SenderNo",
                column: "ApiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiRequestResponseLog");

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
                name: "City");

            migrationBuilder.DropTable(
                name: "CompanyProfile");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmailSetting");

            migrationBuilder.DropTable(
                name: "MasterApiType");

            migrationBuilder.DropTable(
                name: "MasterMessageFormat");

            migrationBuilder.DropTable(
                name: "MasterServiceFeatures");

            migrationBuilder.DropTable(
                name: "MasterWebsite");

            migrationBuilder.DropTable(
                name: "MessageTemplate");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "SendEmail");

            migrationBuilder.DropTable(
                name: "SenderNo");

            migrationBuilder.DropTable(
                name: "SendSms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MasterPackage");

            migrationBuilder.DropTable(
                name: "MasterService");

            migrationBuilder.DropTable(
                name: "MasterApi");
        }
    }
}
