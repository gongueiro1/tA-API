using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AlteracoesModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotographyPurchase_Purchases_ListOfPhotosId1",
                table: "PhotographyPurchase");

            migrationBuilder.RenameColumn(
                name: "ListOfPhotosId1",
                table: "PhotographyPurchase",
                newName: "ListOfPurchasesId");

            migrationBuilder.RenameIndex(
                name: "IX_PhotographyPurchase_ListOfPhotosId1",
                table: "PhotographyPurchase",
                newName: "IX_PhotographyPurchase_ListOfPurchasesId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Photos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Photos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographyPurchase_Purchases_ListOfPurchasesId",
                table: "PhotographyPurchase",
                column: "ListOfPurchasesId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotographyPurchase_Purchases_ListOfPurchasesId",
                table: "PhotographyPurchase");

            migrationBuilder.RenameColumn(
                name: "ListOfPurchasesId",
                table: "PhotographyPurchase",
                newName: "ListOfPhotosId1");

            migrationBuilder.RenameIndex(
                name: "IX_PhotographyPurchase_ListOfPurchasesId",
                table: "PhotographyPurchase",
                newName: "IX_PhotographyPurchase_ListOfPhotosId1");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotographyPurchase_Purchases_ListOfPhotosId1",
                table: "PhotographyPurchase",
                column: "ListOfPhotosId1",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
