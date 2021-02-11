using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavOlusturma.Migrations
{
    public partial class ExamTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Exams",
                newName: "QuestionTwoID");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_QuestionID",
                table: "Exams",
                newName: "IX_Exams_QuestionTwoID");

            migrationBuilder.AddColumn<int>(
                name: "QuestionFourID",
                table: "Exams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionOneID",
                table: "Exams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionThreeID",
                table: "Exams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_QuestionFourID",
                table: "Exams",
                column: "QuestionFourID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_QuestionOneID",
                table: "Exams",
                column: "QuestionOneID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_QuestionThreeID",
                table: "Exams",
                column: "QuestionThreeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionFourID",
                table: "Exams",
                column: "QuestionFourID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionOneID",
                table: "Exams",
                column: "QuestionOneID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionThreeID",
                table: "Exams",
                column: "QuestionThreeID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionTwoID",
                table: "Exams",
                column: "QuestionTwoID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionFourID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionOneID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionThreeID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionTwoID",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_QuestionFourID",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_QuestionOneID",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_QuestionThreeID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "QuestionFourID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "QuestionOneID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "QuestionThreeID",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "QuestionTwoID",
                table: "Exams",
                newName: "QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_QuestionTwoID",
                table: "Exams",
                newName: "IX_Exams_QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
