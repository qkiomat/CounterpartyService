using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CounterpartyService.Migrations
{
    /// <inheritdoc />
    public partial class AddCounterpartyEntityId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Counterparty_CounterpartyEntityId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "CounterpartyEntityId",
                table: "Contracts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Counterparty_CounterpartyEntityId",
                table: "Contracts",
                column: "CounterpartyEntityId",
                principalTable: "Counterparty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Counterparty_CounterpartyEntityId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "CounterpartyEntityId",
                table: "Contracts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Counterparty_CounterpartyEntityId",
                table: "Contracts",
                column: "CounterpartyEntityId",
                principalTable: "Counterparty",
                principalColumn: "Id");
        }
    }
}
