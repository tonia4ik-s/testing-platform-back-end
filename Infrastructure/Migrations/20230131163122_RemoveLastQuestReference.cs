using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class RemoveLastQuestReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTests_Questions_LastAnsweredQuestionId",
                table: "UserTests");

            migrationBuilder.DropIndex(
                name: "IX_UserTests_LastAnsweredQuestionId",
                table: "UserTests");

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

            migrationBuilder.DropColumn(
                name: "LastAnsweredQuestionId",
                table: "UserTests");

            migrationBuilder.DropColumn(
                name: "WasFinished",
                table: "UserTests");

            migrationBuilder.RenameColumn(
                name: "WasStarted",
                table: "UserTests",
                newName: "IsFinished");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c0f1b1b-71eb-4c29-96c0-95f505dcccae", 0, "a9e90f94-706e-4884-8de2-2880a8ab13c8", "User", "Angelina.Little14@gmail.com", false, false, null, "ANGELINA.LITTLE14@GMAIL.COM", "ANGELINA.LITTLE30", "AQAAAAEAACcQAAAAENI57xQD5mh1eqp16SDikuPlaGIpEdrUpEnA5TMBVQ1ocrJzTxibGD/K/NoKrrG7QQ==", null, false, "ad2ddd29-4a83-4758-97b1-afaa3a210a4d", false, "Angelina.Little30" },
                    { "1ece2684-279e-48aa-bcf8-1eaef268cfc8", 0, "c911dd62-4b14-4a04-9002-41bd0ed31a96", "User", "Kate45@gmail.com", false, false, null, "KATE45@GMAIL.COM", "KATE.PROSACCO15", "AQAAAAEAACcQAAAAEMjuJBYQgw+VsHBW8JGR+K84qbhL1+hqIyCMEQCYSopYoo4FL+cBIkg3aCkkNB7IWQ==", null, false, "d7a6a45c-db27-46f8-a9eb-c6e07d7f0b5f", false, "Kate.Prosacco15" },
                    { "3b4844c9-f3a9-46ae-b86e-cd155973a268", 0, "5ffd1706-b79c-4da6-9f08-e6e0051540be", "User", "antonina.loboda@oa.edu.ua", false, false, null, "ANTONINA.LOBODA@OA.EDU.UA", "TON4IK", "AQAAAAEAACcQAAAAEGE3eEVGae4v5jVReahq87u7v5zNKbPEP3xMpwPcApOuo0v9s4VrxbX6Jjhos75Lfg==", null, false, "2cc900fa-7ebf-4f20-90d0-0ec467f63d8e", false, "ton4ik" },
                    { "4eb7773d-1a2e-4396-8f58-3a8d9863680c", 0, "60fafa9b-1a4e-4456-85c2-e03e2bac9670", "User", "Lorena83@hotmail.com", false, false, null, "LORENA83@HOTMAIL.COM", "LORENA.WEST10", "AQAAAAEAACcQAAAAEKyaq543ecMWvFZpMJx9gwk0xnHqYD8tere237jhZX/agi3Yk06b7jM7icDwc3Xwzw==", null, false, "e1b19fbd-68e1-4515-8339-3e8ab715cfd5", false, "Lorena.West10" },
                    { "5fd37a12-9c1a-49b9-bbd9-57e942ac60a3", 0, "3d4b108c-65b6-48b8-96d5-44f84d7aaf4c", "User", "Elisa_Huels@gmail.com", false, false, null, "ELISA_HUELS@GMAIL.COM", "ELISA16", "AQAAAAEAACcQAAAAEM+IL5R4UjTEvUBqxOBZTC42c2GxiDCuuSKIH96ctHNU4vcaY1JcsDkkDgg0s/Pikw==", null, false, "a6c0dbff-33b6-4499-b1f2-645218a420ee", false, "Elisa16" }
                });

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "AssignedToId", "IsFinished", "Result", "TestId" },
                values: new object[] { 1, "4eb7773d-1a2e-4396-8f58-3a8d9863680c", false, 0f, 1 });

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "AssignedToId", "IsFinished", "Result", "TestId" },
                values: new object[] { 2, "0c0f1b1b-71eb-4c29-96c0-95f505dcccae", false, 0f, 1 });

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "AssignedToId", "IsFinished", "Result", "TestId" },
                values: new object[] { 3, "3b4844c9-f3a9-46ae-b86e-cd155973a268", true, 10f, 1 });

            migrationBuilder.InsertData(
                table: "UserAnswers",
                columns: new[] { "Id", "ChosenOptionId", "QuestionId", "UserTestId" },
                values: new object[,]
                {
                    { 1, 3, 1, 3 },
                    { 2, 7, 2, 3 },
                    { 3, 9, 3, 3 },
                    { 4, 14, 4, 3 },
                    { 5, 18, 5, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ece2684-279e-48aa-bcf8-1eaef268cfc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fd37a12-9c1a-49b9-bbd9-57e942ac60a3");

            migrationBuilder.DeleteData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserAnswers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c0f1b1b-71eb-4c29-96c0-95f505dcccae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eb7773d-1a2e-4396-8f58-3a8d9863680c");

            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b4844c9-f3a9-46ae-b86e-cd155973a268");

            migrationBuilder.RenameColumn(
                name: "IsFinished",
                table: "UserTests",
                newName: "WasStarted");

            migrationBuilder.AddColumn<int>(
                name: "LastAnsweredQuestionId",
                table: "UserTests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "WasFinished",
                table: "UserTests",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserTests_LastAnsweredQuestionId",
                table: "UserTests",
                column: "LastAnsweredQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTests_Questions_LastAnsweredQuestionId",
                table: "UserTests",
                column: "LastAnsweredQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
