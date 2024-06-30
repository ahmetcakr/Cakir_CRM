using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class operationClaims1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Admin", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Read", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Write", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Add", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Update", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "users.Delete", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Admin", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Read", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Write", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Add", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Update", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "operationclaims.Delete", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Admin", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Read", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Write", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Add", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Update", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "useroperationclaims.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 177, 204, 117, 71, 255, 202, 56, 46, 104, 107, 252, 210, 155, 142, 126, 171, 158, 191, 234, 232, 0, 3, 208, 182, 192, 97, 170, 50, 160, 126, 166, 195, 244, 237, 50, 151, 129, 159, 175, 24, 251, 228, 107, 54, 129, 33, 230, 137, 142, 96, 217, 119, 166, 138, 100, 64, 57, 172, 2, 18, 98, 237, 180 }, new byte[] { 230, 18, 79, 63, 63, 195, 139, 36, 103, 191, 112, 123, 154, 39, 86, 6, 233, 28, 54, 64, 137, 246, 68, 33, 42, 200, 108, 143, 49, 66, 160, 7, 14, 202, 220, 48, 28, 201, 115, 25, 98, 138, 251, 46, 38, 210, 11, 66, 11, 101, 16, 111, 202, 139, 214, 92, 42, 199, 141, 133, 23, 99, 178, 103, 146, 180, 7, 33, 166, 70, 47, 126, 131, 115, 179, 106, 56, 211, 214, 110, 88, 231, 184, 223, 165, 131, 225, 152, 85, 6, 80, 216, 55, 136, 114, 148, 169, 250, 230, 136, 127, 186, 85, 202, 243, 26, 3, 112, 222, 129, 121, 116, 31, 119, 12, 239, 32, 223, 4, 47, 24, 251, 240, 101, 51, 103, 152, 57 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 142, 248, 54, 224, 249, 95, 9, 48, 137, 220, 112, 90, 211, 129, 88, 16, 184, 33, 178, 51, 68, 6, 69, 254, 13, 175, 208, 164, 140, 77, 134, 180, 213, 56, 112, 191, 120, 125, 122, 79, 140, 153, 182, 132, 117, 225, 107, 201, 37, 55, 255, 75, 125, 223, 252, 63, 121, 117, 40, 147, 229, 234, 54, 85 }, new byte[] { 240, 177, 174, 177, 254, 254, 172, 232, 162, 112, 56, 188, 222, 23, 145, 209, 241, 128, 123, 182, 3, 112, 27, 177, 62, 199, 158, 138, 49, 244, 167, 238, 45, 204, 244, 129, 154, 180, 153, 102, 44, 232, 33, 119, 218, 64, 248, 243, 156, 152, 200, 230, 197, 16, 4, 44, 178, 112, 175, 154, 114, 252, 127, 36, 240, 45, 231, 253, 134, 65, 129, 46, 103, 10, 151, 207, 14, 61, 55, 209, 124, 20, 221, 155, 40, 187, 77, 73, 61, 20, 144, 235, 207, 140, 226, 52, 122, 104, 196, 89, 85, 173, 67, 214, 15, 186, 47, 222, 72, 165, 247, 11, 218, 150, 164, 171, 122, 108, 58, 79, 67, 151, 121, 61, 251, 3, 157, 14 } });
        }
    }
}
