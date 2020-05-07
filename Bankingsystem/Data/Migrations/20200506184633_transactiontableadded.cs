using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bankingsystem.Data.Migrations
{
    public partial class transactiontableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<string>(nullable: true),
                    Datetime = table.Column<DateTime>(nullable: false),
                    Narration = table.Column<string>(nullable: true),
                    Withdrawl = table.Column<int>(nullable: false),
                    Deposit = table.Column<int>(nullable: false),
                    ClosingBalance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactions");
        }
    }
}
