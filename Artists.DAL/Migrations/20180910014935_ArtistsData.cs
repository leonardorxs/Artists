using Microsoft.EntityFrameworkCore.Migrations;

namespace Artists.DAL.Migrations
{
    public partial class ArtistsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Artists(Name, Country, City, Site, BirthDate) VALUES ('Leonardo', 'São Paulo', 'Poá', 'github.com/leonardorxs', '1997-06-22')");
            migrationBuilder.Sql("INSERT INTO Artists(Name, Country, City, Site, BirthDate) VALUES ('Leo', 'São Paulo', 'Poá', 'github.com/leonardorxs', '1997-06-22')");
            migrationBuilder.Sql("INSERT INTO Artists(Name, Country, City, Site, BirthDate) VALUES ('Viewtiful', 'São Paulo', 'Poá', 'github.com/leonardorxs', '1997-06-22')");

            migrationBuilder.Sql("INSERT INTO ArtistDetails(Talent, Details, ArtistId) VALUES ('Programmer', 'Começou a programar em 2015', 1)");
            migrationBuilder.Sql("INSERT INTO ArtistDetails(Talent, Details, ArtistId) VALUES ('Cantor', 'Começou a cantar em 2015', 2)");
            migrationBuilder.Sql("INSERT INTO ArtistDetails(Talent, Details, ArtistId) VALUES ('Nadador', 'Começou a nadar em 2015', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artists");
            migrationBuilder.Sql("DELETE FROM ArtistDetails");
        }
    }
}
