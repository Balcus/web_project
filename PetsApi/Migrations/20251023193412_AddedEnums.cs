using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:animal_status", "available,adopted,unavailable")
                .Annotation("Npgsql:Enum:gender", "male,female,unknown")
                .Annotation("Npgsql:Enum:species", "dog,cat,bird,hamster,reptile,other");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:animal_status", "available,adopted,unavailable")
                .OldAnnotation("Npgsql:Enum:gender", "male,female,unknown")
                .OldAnnotation("Npgsql:Enum:species", "dog,cat,bird,hamster,reptile,other");
        }
    }
}
