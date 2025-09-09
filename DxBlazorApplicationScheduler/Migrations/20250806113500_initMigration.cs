using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DxBlazorApplicationScheduler.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsGroup = table.Column<bool>(type: "bit", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    TextCss = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BackgroundCss = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "IID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Label = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    Recurrence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    Resources = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Accepted = table.Column<bool>(type: "bit", nullable: true),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    AppGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AppGroups_AppGroupId",
                        column: x => x.AppGroupId,
                        principalTable: "AppGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Resources",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResourceGroups",
                columns: table => new
                {
                    ResourceGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceGroups", x => x.ResourceGroupId);
                    table.ForeignKey(
                        name: "FK_ResourceGroups_AppGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AppGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourceGroups_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResourceResource",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceResource", x => new { x.ChildrenId, x.ParentsId });
                    table.ForeignKey(
                        name: "FK_ResourceResource_Resources_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourceResource_Resources_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppGroupId",
                table: "Appointments",
                column: "AppGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ResourceId",
                table: "Appointments",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceGroups_GroupId",
                table: "ResourceGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceGroups_ResourceId",
                table: "ResourceGroups",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceResource_ParentsId",
                table: "ResourceResource",
                column: "ParentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_UserId",
                table: "Resources",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "ResourceGroups");

            migrationBuilder.DropTable(
                name: "ResourceResource");

            migrationBuilder.DropTable(
                name: "usgrlink");

            migrationBuilder.DropTable(
                name: "AppGroups");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
