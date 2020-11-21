using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarexFinalProject.Migrations
{
    public partial class lastt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Declarations_AspNetUsers_AppUsersId",
                table: "Declarations");

            migrationBuilder.DropForeignKey(
                name: "FK_Declarations_OnlineFormCategories_CategoryId",
                table: "Declarations");

            migrationBuilder.DropIndex(
                name: "IX_Declarations_AppUsersId",
                table: "Declarations");

            migrationBuilder.DropIndex(
                name: "IX_Declarations_CategoryId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "AppUsersId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "CargoNumber",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "Declaration_Amount",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Declarations");

            migrationBuilder.AlterColumn<string>(
                name: "Shop",
                table: "Declarations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Declarations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Declarations",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeclarationDate",
                table: "Declarations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeliveryCode",
                table: "Declarations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Declarations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LiquidOrNot",
                table: "Declarations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductPrice",
                table: "Declarations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Declarations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ProductWeight",
                table: "Declarations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Declarations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingPrice",
                table: "Declarations",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Declarations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TrackingCode",
                table: "Declarations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Declarations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Warehouse_Id",
                table: "Declarations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Declarations_StatusId",
                table: "Declarations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Declarations_UserId",
                table: "Declarations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Declarations_DeclarationsStatuses_StatusId",
                table: "Declarations",
                column: "StatusId",
                principalTable: "DeclarationsStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Declarations_AspNetUsers_UserId",
                table: "Declarations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Declarations_DeclarationsStatuses_StatusId",
                table: "Declarations");

            migrationBuilder.DropForeignKey(
                name: "FK_Declarations_AspNetUsers_UserId",
                table: "Declarations");

            migrationBuilder.DropIndex(
                name: "IX_Declarations_StatusId",
                table: "Declarations");

            migrationBuilder.DropIndex(
                name: "IX_Declarations_UserId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "DeclarationDate",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "DeliveryCode",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "LiquidOrNot",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "ProductWeight",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "ShippingPrice",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "TrackingCode",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "Warehouse_Id",
                table: "Declarations");

            migrationBuilder.AlterColumn<string>(
                name: "Shop",
                table: "Declarations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "Declarations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Declarations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUsersId",
                table: "Declarations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoNumber",
                table: "Declarations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Declarations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Declaration_Amount",
                table: "Declarations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Declarations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Declarations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Declarations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Declarations_AppUsersId",
                table: "Declarations",
                column: "AppUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Declarations_CategoryId",
                table: "Declarations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Declarations_AspNetUsers_AppUsersId",
                table: "Declarations",
                column: "AppUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Declarations_OnlineFormCategories_CategoryId",
                table: "Declarations",
                column: "CategoryId",
                principalTable: "OnlineFormCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
