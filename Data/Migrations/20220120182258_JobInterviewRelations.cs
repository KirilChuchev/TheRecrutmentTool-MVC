using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRecrutmentTool.Data.Migrations
{
    public partial class JobInterviewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobId",
                table: "Interviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_JobId",
                table: "Interviews",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Jobs_JobId",
                table: "Interviews",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Jobs_JobId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_JobId",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Interviews");
        }
    }
}
