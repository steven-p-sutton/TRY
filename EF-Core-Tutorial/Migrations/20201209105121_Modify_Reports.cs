using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Tutorial.Migrations
{
    public partial class Modify_Reports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Department",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Report",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_DepartmentId",
                table: "Report",
                newName: "IX_Report_ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Project",
                table: "Report",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_Project",
                table: "Report");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Report",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ProjectId",
                table: "Report",
                newName: "IX_Report_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Department",
                table: "Report",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
