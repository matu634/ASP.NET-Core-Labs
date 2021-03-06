﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class convertfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<short>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(short));
        }
    }
}
