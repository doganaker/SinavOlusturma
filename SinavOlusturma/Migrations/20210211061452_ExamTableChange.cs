using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavOlusturma.Migrations
{
    public partial class ExamTableChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionID",
                table: "Exams",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionID",
                table: "Exams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Questions_QuestionID",
                table: "Exams",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
