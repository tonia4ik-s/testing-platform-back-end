using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionTest");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26e38e0d-93e1-4a2d-909c-b66073e69f12", 0, "4fa34865-673c-45d1-b5f1-20136a3fc088", "User", "Michele.Dickens@gmail.com", false, false, null, "MICHELE.DICKENS@GMAIL.COM", "MICHELE35", "AQAAAAEAACcQAAAAEFlMCqp8YckJPBIJ0k+lIuGnDeQkHsljbtunRC7LfzGTTUrntMvqRwwrCKDZsvnO2g==", null, false, "f470d9b5-fd09-46d9-a719-d992d106fa97", false, "Michele35" },
                    { "566dba7d-bfbe-4454-a569-12778caaa6f8", 0, "2adb6640-8893-4f41-88fe-17a1073e2d13", "User", "antonina.loboda@oa.edu.ua", false, false, null, "ANTONINA.LOBODA@OA.EDU.UA", "TON4IK", "AQAAAAEAACcQAAAAED6Yd/GqAEHfltcygZj4XjTFooZExM+0NSpZkhNbUNeOEQ81mrRQB78cISWxxpFwWw==", null, false, "3f71a2ff-34e8-4356-a9eb-712b9e51806a", false, "ton4ik" },
                    { "7149e65d-0a01-4380-b98c-5c05ae7fa166", 0, "bc638c5e-9349-40f2-b5a3-b3bb02beba8d", "User", "Misty83@gmail.com", false, false, null, "MISTY83@GMAIL.COM", "MISTY.SCHULTZ", "AQAAAAEAACcQAAAAELeZcXU4yX2zzezRc9EJdUuGYlWPQxUukffrb0i0KSm40Ue85l1B2NJ3LbDJehBLmw==", null, false, "b4cc9beb-65f2-4038-bc23-9a76df9e5381", false, "Misty.Schultz" },
                    { "8fe3caa3-619e-4362-884b-ade16ff042c1", 0, "58234134-22c5-48cc-8eda-a40fb36b64c5", "User", "Kent_Feest@yahoo.com", false, false, null, "KENT_FEEST@YAHOO.COM", "KENT81", "AQAAAAEAACcQAAAAEPh68JUxAdmtjzjNIsTzxOU2wCGGpWU2H6cc8ZGEjQDwCInx9zTxyd4/vytLRVIFng==", null, false, "64e6e13c-9d5e-4049-a8ae-47b4bcbebe91", false, "Kent81" },
                    { "ac1aa4b0-4639-4c21-b0b7-722620aac6eb", 0, "8fa5ace3-b767-4ae4-a0ff-7e72604d3b86", "User", "Yolanda_Kertzmann46@yahoo.com", false, false, null, "YOLANDA_KERTZMANN46@YAHOO.COM", "YOLANDA75", "AQAAAAEAACcQAAAAEMnArUYERGJg9cICLConGIAZYtXPyP1iRbP+1FfAaBqZqd8wXjmClIpu7Q+CNwa5vA==", null, false, "b9418320-b525-425c-b1b7-63fe16655a18", false, "Yolanda75" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Description", "MaxResult", "Title" },
                values: new object[] { 1, "Show your knowledge in different topics! Good luck!", 10f, "Multi-quiz" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Mark", "QuestionText", "TestId" },
                values: new object[,]
                {
                    { 1, 2f, "The capital of Ukraine is...", 1 },
                    { 2, 2f, "3 + 3 * 3 = ...", 1 },
                    { 3, 2f, "Which color will be, if mix blue and yellow?", 1 },
                    { 4, 2f, "Tanya is older than Eric.\nCliff is older than Tanya.\nEric is older than Cliff.\nIf the first two statements are true, the third statement is", 1 },
                    { 5, 2f, "How many elements are in the periodic table?", 1 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "IsRightAnswer", "OptionText", "QuestionId" },
                values: new object[,]
                {
                    { 1, false, "Lviv", 1 },
                    { 2, false, "Kharkiv", 1 },
                    { 3, true, "Kyiv", 1 },
                    { 4, false, "Chernigiv", 1 },
                    { 5, false, "18", 2 },
                    { 6, false, "9", 2 },
                    { 7, true, "12", 2 },
                    { 8, false, "27", 2 },
                    { 9, true, "green", 3 },
                    { 10, false, "blue", 3 },
                    { 11, false, "pink", 3 },
                    { 12, false, "purple", 3 },
                    { 13, false, "true", 4 },
                    { 14, true, "false", 4 },
                    { 15, false, "uncertain", 4 },
                    { 16, false, "100", 5 },
                    { 17, false, "30", 5 },
                    { 18, true, "118", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId",
                table: "Questions",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestId",
                table: "Questions",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TestId",
                table: "Questions");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26e38e0d-93e1-4a2d-909c-b66073e69f12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "566dba7d-bfbe-4454-a569-12778caaa6f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7149e65d-0a01-4380-b98c-5c05ae7fa166");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fe3caa3-619e-4362-884b-ade16ff042c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac1aa4b0-4639-4c21-b0b7-722620aac6eb");

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "QuestionTest",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "int", nullable: false),
                    TestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTest", x => new { x.QuestionsId, x.TestsId });
                    table.ForeignKey(
                        name: "FK_QuestionTest_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTest_Tests_TestsId",
                        column: x => x.TestsId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTest_TestsId",
                table: "QuestionTest",
                column: "TestsId");
        }
    }
}
