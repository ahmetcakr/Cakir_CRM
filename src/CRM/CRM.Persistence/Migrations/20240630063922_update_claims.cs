using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_claims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "users.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "users.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "users.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "users.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "users.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "users.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "operationclaims.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "operationclaims.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "operationclaims.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "operationclaims.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "operationclaims.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "operationclaims.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "useroperationclaims.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "useroperationclaims.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "useroperationclaims.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "useroperationclaims.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "useroperationclaims.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "useroperationclaims.delete");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 157, 55, 9, 143, 191, 188, 115, 18, 95, 141, 123, 36, 58, 207, 191, 115, 151, 237, 197, 153, 120, 206, 91, 231, 227, 212, 70, 173, 136, 88, 210, 2, 190, 215, 45, 156, 136, 242, 236, 84, 218, 49, 212, 39, 222, 124, 162, 214, 37, 228, 210, 234, 209, 237, 91, 181, 116, 60, 136, 16, 35, 237, 195 }, new byte[] { 235, 202, 156, 114, 227, 225, 143, 213, 183, 24, 160, 160, 11, 49, 85, 101, 29, 42, 120, 212, 200, 207, 121, 77, 28, 108, 103, 249, 158, 209, 148, 31, 253, 219, 198, 219, 247, 177, 117, 186, 154, 94, 99, 237, 199, 83, 191, 183, 242, 201, 175, 146, 192, 37, 11, 169, 214, 36, 60, 62, 130, 225, 208, 24, 249, 154, 100, 253, 216, 160, 170, 249, 93, 107, 117, 248, 152, 62, 22, 203, 229, 74, 207, 106, 135, 16, 160, 211, 98, 247, 69, 139, 208, 118, 216, 81, 78, 166, 32, 183, 204, 195, 23, 102, 210, 204, 230, 232, 126, 100, 163, 139, 185, 63, 159, 226, 237, 165, 161, 239, 84, 68, 169, 34, 71, 3, 131, 182 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "users.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "users.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "users.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "users.Add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "users.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "users.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "operationclaims.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "operationclaims.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "operationclaims.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "operationclaims.Add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "operationclaims.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "operationclaims.Delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "useroperationclaims.Admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "useroperationclaims.Read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "useroperationclaims.Write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "useroperationclaims.Add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "useroperationclaims.Update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "useroperationclaims.Delete");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 36, 53, 17, 248, 184, 85, 81, 19, 45, 26, 22, 251, 115, 150, 57, 123, 92, 213, 185, 84, 66, 136, 198, 24, 113, 3, 197, 205, 209, 211, 78, 255, 47, 159, 24, 29, 23, 107, 118, 93, 115, 104, 101, 57, 230, 184, 48, 243, 66, 234, 7, 39, 47, 253, 76, 71, 143, 250, 220, 41, 165, 43, 255 }, new byte[] { 69, 21, 7, 180, 15, 181, 164, 113, 147, 23, 246, 80, 157, 208, 234, 118, 116, 27, 54, 89, 195, 241, 129, 222, 224, 124, 107, 13, 131, 69, 56, 58, 131, 10, 199, 120, 198, 81, 198, 41, 147, 1, 157, 150, 92, 131, 16, 203, 148, 114, 152, 40, 202, 3, 64, 102, 99, 217, 162, 131, 126, 135, 213, 130, 13, 213, 30, 112, 94, 40, 20, 137, 56, 255, 81, 205, 40, 136, 157, 196, 123, 185, 37, 132, 110, 205, 106, 68, 31, 152, 217, 156, 12, 12, 189, 33, 148, 180, 188, 135, 240, 82, 160, 52, 174, 18, 62, 152, 100, 230, 172, 213, 226, 8, 118, 157, 69, 36, 76, 22, 222, 236, 154, 227, 27, 148, 46, 54 } });
        }
    }
}
