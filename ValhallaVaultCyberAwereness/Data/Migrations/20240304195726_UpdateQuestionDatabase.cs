using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValhallaVaultCyberAwereness.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "SegmentId",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CorrectAnswer", "PossibleAnswers", "Questions", "SegmentId" },
                values: new object[] { 1, "Sunny", "[\"Rainy\",\"Sunny\",\"Wet\"]", "Whats the weather today?", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions",
                column: "SegmentId",
                principalTable: "Segments",
                principalColumn: "SegmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "SegmentId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Segments_SegmentId",
                table: "Questions",
                column: "SegmentId",
                principalTable: "Segments",
                principalColumn: "SegmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
