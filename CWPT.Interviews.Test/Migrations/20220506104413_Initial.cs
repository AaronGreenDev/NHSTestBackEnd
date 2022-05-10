using Microsoft.EntityFrameworkCore.Migrations;

namespace CWPT.Interviews.Test.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Practices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 200, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 200, nullable: true),
                    AddressLine3 = table.Column<string>(maxLength: 200, nullable: true),
                    Postcode = table.Column<string>(maxLength: 12, nullable: true),
                    Longitude = table.Column<string>(maxLength: 15, nullable: true),
                    Latitude = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 1, "The Barley Lea", "Coventry", "", "-1.5020543", "52.3959894", "Stoke Aldermoor Medical Centre", "CV3 1EG" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 2, "School St", "Wolston", "Coventry", "-1.5419026", "52.3740129", "Wolston Surgery", "CV8 3HG" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 3, "42 St Paul's Road", "Coventry", "", "-1.5510533", "52.4042861", "Central Medical Centre", "CV6 5DF" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 4, "41 Westminster Road", "Coventry", "", "-1.5437157", "52.3932425", "Jubilee Health Care", "CV1 3GB" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 5, "201 Wigston Rd", "Coventry", "", "-1.4769648", "52.4126748", "Woodway Medical Centre", "CV2 2RH" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 6, "2 St George's Road", "Coventry", "", "-1.544966", "52.3915094", "Park House Surgery", "CV1 2DL" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 7, "95 Momus Blvd", "Coventry", "", "-1.5753546", "52.3836432", "Copsewood Medical Centre", "CV2 5NB" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 8, "15 Chace Avenue", "Coventry", "", "-1.5431221", "52.3760257", "Kenyon Medical Centre", "CV3 3AD" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 9, "298 Tile Hill Lane", "Coventry", "", "-1.5670089", "52.3966523", "Westwood Medical Centre", "CV4 9DR" });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "Latitude", "Longitude", "Name", "Postcode" },
                values: new object[] { 10, "103 Leamington Road", "Coventry", "", "-1.515459", "52.390024", "Phoenix Family Care", "CV3 6GQ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Practices");
        }
    }
}
