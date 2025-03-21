using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VCFirstPractice.Migrations
{
    /// <inheritdoc />
    public partial class ResetIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DBCC CHECKIDENT ('Books', RESEED, 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
