using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoreWebApi.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoomInfo",
                table: "HotelRoomInfo");

            migrationBuilder.AlterColumn<int>(
                name: "HotelID",
                table: "HotelRoomInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "LogId",
                table: "HotelRoomInfo",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoomInfo",
                table: "HotelRoomInfo",
                column: "LogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelRoomInfo",
                table: "HotelRoomInfo");

            migrationBuilder.DropColumn(
                name: "LogId",
                table: "HotelRoomInfo");

            migrationBuilder.AlterColumn<int>(
                name: "HotelID",
                table: "HotelRoomInfo",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelRoomInfo",
                table: "HotelRoomInfo",
                column: "HotelID");
        }
    }
}
