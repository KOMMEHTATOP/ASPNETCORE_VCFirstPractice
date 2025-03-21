using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCFirstPractice.Migrations
{
    /// <inheritdoc />
    public partial class ResetIdentityFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Books;");
            // Сброс автоинкремента для SQL Server
            migrationBuilder.Sql("DBCC CHECKIDENT ('Books', RESEED, 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
