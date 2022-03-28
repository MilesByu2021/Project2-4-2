using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateTime",
                columns: table => new
                {
                    DateTimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<string>(nullable: true),
                    StartTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTime", x => x.DateTimeId);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    GroupEmail = table.Column<string>(nullable: false),
                    GroupPhone = table.Column<string>(nullable: true),
                    DateTimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedule_DateTime_DateTimeId",
                        column: x => x.DateTimeId,
                        principalTable: "DateTime",
                        principalColumn: "DateTimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 1, "03/21/2022", "8 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 22, "03/22/2022", "4 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 23, "03/22/2022", "5 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 24, "03/22/2022", "6 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 25, "03/22/2022", "7 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 26, "03/22/2022", "8 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 27, "03/23/2022", "8 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 28, "03/23/2022", "9 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 21, "03/22/2022", "3 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 29, "03/23/2022", "10 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 31, "03/23/2022", "12 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 32, "03/23/2022", "1 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 33, "03/23/2022", "2 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 34, "03/23/2022", "3 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 35, "03/23/2022", "4 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 36, "03/23/2022", "5 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 37, "03/23/2022", "6 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 30, "03/23/2022", "11 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 38, "03/23/2022", "7 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 20, "03/22/2022", "2 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 18, "03/22/2022", "12 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 2, "03/21/2022", "9 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 3, "03/21/2022", "10 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 4, "03/21/2022", "11 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 5, "03/21/2022", "12 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 6, "03/21/2022", "1 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 7, "03/21/2022", "2 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 8, "03/21/2022", "3 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 19, "03/22/2022", "1 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 9, "03/21/2022", "4 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 11, "03/21/2022", "6 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 12, "03/21/2022", "7 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 13, "03/21/2022", "8 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 14, "03/22/2022", "8 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 15, "03/22/2022", "9 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 16, "03/22/2022", "10 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 17, "03/22/2022", "11 AM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 10, "03/21/2022", "5 PM" });

            migrationBuilder.InsertData(
                table: "DateTime",
                columns: new[] { "DateTimeId", "StartDate", "StartTime" },
                values: new object[] { 39, "03/23/2022", "8 PM" });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleId", "DateTimeId", "GroupEmail", "GroupName", "GroupPhone", "GroupSize" },
                values: new object[] { 1, 1, "123@gmail.com", "Sheng Lei", "123-123-1234", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_DateTimeId",
                table: "Schedule",
                column: "DateTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "DateTime");
        }
    }
}
