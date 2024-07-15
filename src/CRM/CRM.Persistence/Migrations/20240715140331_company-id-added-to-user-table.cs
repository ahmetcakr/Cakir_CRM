using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class companyidaddedtousertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "companies.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "companies.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "companies.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "companies.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "companies.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "companies.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "companytypes.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "companytypes.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "companytypes.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "companytypes.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "companytypes.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "companytypes.delete");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyId", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "Cakir", new byte[] { 79, 60, 131, 47, 217, 45, 44, 48, 30, 24, 254, 42, 104, 230, 50, 0, 149, 154, 135, 11, 238, 104, 120, 172, 128, 242, 40, 207, 98, 158, 167, 253, 109, 104, 56, 228, 45, 20, 29, 240, 221, 203, 58, 167, 187, 88, 192, 103, 95, 2, 189, 167, 66, 23, 29, 156, 53, 186, 215, 69, 96, 217, 84, 171 }, new byte[] { 151, 14, 107, 180, 163, 169, 151, 183, 182, 220, 18, 33, 199, 235, 12, 241, 122, 243, 123, 23, 74, 71, 199, 77, 67, 192, 219, 105, 0, 37, 38, 70, 127, 203, 230, 233, 40, 45, 3, 143, 77, 187, 123, 147, 134, 88, 128, 84, 101, 89, 193, 130, 122, 214, 100, 78, 220, 193, 70, 125, 113, 202, 111, 211, 3, 148, 88, 122, 224, 72, 149, 243, 104, 51, 89, 164, 11, 10, 74, 187, 96, 208, 230, 181, 96, 101, 47, 69, 41, 188, 129, 210, 156, 21, 181, 228, 76, 173, 131, 66, 34, 153, 178, 31, 130, 231, 92, 155, 145, 4, 199, 3, 226, 75, 35, 92, 104, 85, 134, 155, 139, 167, 186, 135, 128, 40, 231, 146 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "companies.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "companies.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "companies.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "companies.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "companies.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "companies.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "companytypes.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "companytypes.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "companytypes.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "companytypes.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "companytypes.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "companytypes.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "users.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "users.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "users.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "users.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "users.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "users.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "operationclaims.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "operationclaims.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "operationclaims.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "operationclaims.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "operationclaims.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "operationclaims.delete");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "useroperationclaims.admin");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "useroperationclaims.read");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "useroperationclaims.write");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "useroperationclaims.add");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "useroperationclaims.update");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "useroperationclaims.delete");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "NArchitecture", new byte[] { 43, 4, 108, 80, 225, 101, 76, 69, 71, 78, 245, 183, 98, 128, 152, 224, 230, 16, 69, 209, 254, 138, 36, 31, 222, 127, 211, 187, 43, 152, 206, 84, 186, 65, 88, 212, 62, 232, 22, 117, 44, 251, 151, 27, 238, 203, 200, 22, 196, 163, 88, 3, 127, 29, 84, 123, 117, 144, 114, 48, 237, 230, 214, 160 }, new byte[] { 148, 130, 213, 4, 41, 56, 105, 184, 113, 135, 126, 222, 52, 237, 81, 77, 172, 15, 100, 203, 7, 208, 215, 102, 199, 128, 147, 158, 42, 253, 172, 59, 50, 116, 209, 68, 176, 57, 248, 144, 224, 62, 127, 37, 62, 89, 171, 48, 185, 57, 76, 38, 252, 226, 92, 47, 34, 147, 3, 192, 3, 190, 82, 113, 11, 9, 233, 84, 40, 189, 106, 141, 7, 190, 234, 137, 74, 217, 0, 82, 49, 236, 27, 73, 252, 246, 64, 158, 190, 40, 133, 103, 21, 16, 168, 44, 135, 93, 74, 59, 21, 237, 9, 194, 43, 21, 103, 97, 209, 80, 231, 176, 69, 70, 198, 19, 117, 173, 141, 217, 212, 238, 233, 205, 51, 35, 77, 208 } });
        }
    }
}
