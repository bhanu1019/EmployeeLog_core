using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeLog.Data.Migrations
{
    public partial class EmployeeLog_0922 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => new { x.EmployeeID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkItem_ProjectID",
                table: "WorkItem",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItem_WorkItemStatusID",
                table: "WorkItem",
                column: "WorkItemStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientID",
                table: "Projects",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_EmployeeID",
                table: "EmployeeRole",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_RoleID",
                table: "EmployeeRole",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientID",
                table: "Projects",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItem_Projects_ProjectID",
                table: "WorkItem",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItem_WorkItemStatus_WorkItemStatusID",
                table: "WorkItem",
                column: "WorkItemStatusID",
                principalTable: "WorkItemStatus",
                principalColumn: "WorkItemStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItemDetails_WorkItem_WorkItemID",
                table: "WorkItemDetails",
                column: "WorkItemID",
                principalTable: "WorkItem",
                principalColumn: "WorkItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItem_Projects_ProjectID",
                table: "WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItem_WorkItemStatus_WorkItemStatusID",
                table: "WorkItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItemDetails_WorkItem_WorkItemID",
                table: "WorkItemDetails");

            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_WorkItem_ProjectID",
                table: "WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_WorkItem_WorkItemStatusID",
                table: "WorkItem");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ClientID",
                table: "Projects");
        }
    }
}
