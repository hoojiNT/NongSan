using Microsoft.EntityFrameworkCore.Migrations;

namespace NongSan.API.Migrations
{
    public partial class everythinghaschange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductID",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Supplier",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Category",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "ProductID",
                table: "OrderDetail",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductID",
                table: "OrderDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductID",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Supplier",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Category",
                newName: "CategoryID");

            migrationBuilder.AlterColumn<string>(
                name: "ProductID",
                table: "OrderDetail",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductID",
                table: "OrderDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
