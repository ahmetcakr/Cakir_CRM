using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deleteAuthType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthenticatorType",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 36, 53, 17, 248, 184, 85, 81, 19, 45, 26, 22, 251, 115, 150, 57, 123, 92, 213, 185, 84, 66, 136, 198, 24, 113, 3, 197, 205, 209, 211, 78, 255, 47, 159, 24, 29, 23, 107, 118, 93, 115, 104, 101, 57, 230, 184, 48, 243, 66, 234, 7, 39, 47, 253, 76, 71, 143, 250, 220, 41, 165, 43, 255 }, new byte[] { 69, 21, 7, 180, 15, 181, 164, 113, 147, 23, 246, 80, 157, 208, 234, 118, 116, 27, 54, 89, 195, 241, 129, 222, 224, 124, 107, 13, 131, 69, 56, 58, 131, 10, 199, 120, 198, 81, 198, 41, 147, 1, 157, 150, 92, 131, 16, 203, 148, 114, 152, 40, 202, 3, 64, 102, 99, 217, 162, 131, 126, 135, 213, 130, 13, 213, 30, 112, 94, 40, 20, 137, 56, 255, 81, 205, 40, 136, 157, 196, 123, 185, 37, 132, 110, 205, 106, 68, 31, 152, 217, 156, 12, 12, 189, 33, 148, 180, 188, 135, 240, 82, 160, 52, 174, 18, 62, 152, 100, 230, 172, 213, 226, 8, 118, 157, 69, 36, 76, 22, 222, 236, 154, 227, 27, 148, 46, 54 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthenticatorType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthenticatorType", "PasswordHash", "PasswordSalt" },
                values: new object[] { 0, new byte[] { 150, 177, 204, 117, 71, 255, 202, 56, 46, 104, 107, 252, 210, 155, 142, 126, 171, 158, 191, 234, 232, 0, 3, 208, 182, 192, 97, 170, 50, 160, 126, 166, 195, 244, 237, 50, 151, 129, 159, 175, 24, 251, 228, 107, 54, 129, 33, 230, 137, 142, 96, 217, 119, 166, 138, 100, 64, 57, 172, 2, 18, 98, 237, 180 }, new byte[] { 230, 18, 79, 63, 63, 195, 139, 36, 103, 191, 112, 123, 154, 39, 86, 6, 233, 28, 54, 64, 137, 246, 68, 33, 42, 200, 108, 143, 49, 66, 160, 7, 14, 202, 220, 48, 28, 201, 115, 25, 98, 138, 251, 46, 38, 210, 11, 66, 11, 101, 16, 111, 202, 139, 214, 92, 42, 199, 141, 133, 23, 99, 178, 103, 146, 180, 7, 33, 166, 70, 47, 126, 131, 115, 179, 106, 56, 211, 214, 110, 88, 231, 184, 223, 165, 131, 225, 152, 85, 6, 80, 216, 55, 136, 114, 148, 169, 250, 230, 136, 127, 186, 85, 202, 243, 26, 3, 112, 222, 129, 121, 116, 31, 119, 12, 239, 32, 223, 4, 47, 24, 251, 240, 101, 51, 103, 152, 57 } });
        }
    }
}
