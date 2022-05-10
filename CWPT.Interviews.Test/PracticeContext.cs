using Microsoft.EntityFrameworkCore;

namespace CWPT.Interviews.Test
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Practice> Practices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Practice>().HasData(
                new Practice
                {
                    Id = 1,
                    Name = "Stoke Aldermoor Medical Centre",
                    AddressLine1 = "The Barley Lea",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV3 1EG",
                    Longitude = "52.3959894",
                    Latitude = "-1.5020543",
                },
                new Practice
                {
                    Id = 2,
                    Name = "Wolston Surgery",
                    AddressLine1 = "School St",
                    AddressLine2 = "Wolston",
                    AddressLine3 = "Coventry",
                    Postcode = "CV8 3HG",
                    Longitude = "52.3740129",
                    Latitude = "-1.5419026"
                },
                new Practice
                {
                    Id = 3,
                    Name = "Central Medical Centre",
                    AddressLine1 = "42 St Paul's Road",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV6 5DF",
                    Longitude = "52.4042861",
                    Latitude = "-1.5510533"
                },
                new Practice
                {
                    Id = 4,
                    Name = "Jubilee Health Care",
                    AddressLine1 = "41 Westminster Road",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV1 3GB",
                    Longitude = "52.3932425",
                    Latitude = "-1.5437157"
                },
                new Practice
                {
                    Id = 5,
                    Name = "Woodway Medical Centre",
                    AddressLine1 = "201 Wigston Rd",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV2 2RH",
                    Longitude = "52.4126748",
                    Latitude = "-1.4769648",
                },
                new Practice
                {
                    Id = 6,
                    Name = "Park House Surgery",
                    AddressLine1 = "2 St George's Road",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV1 2DL",
                    Longitude = "52.3915094",
                    Latitude = "-1.544966",
                },
                new Practice
                {
                    Id = 7,
                    Name = "Copsewood Medical Centre",
                    AddressLine1 = "95 Momus Blvd",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV2 5NB",
                    Longitude = "52.3836432",
                    Latitude = "-1.5753546",
                },
                new Practice
                {
                    Id = 8,
                    Name = "Kenyon Medical Centre",
                    AddressLine1 = "15 Chace Avenue",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV3 3AD",
                    Longitude = "52.3760257",
                    Latitude = "-1.5431221",
                },
                new Practice
                {
                    Id = 9,
                    Name = "Westwood Medical Centre",
                    AddressLine1 = "298 Tile Hill Lane",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV4 9DR",
                    Longitude = "52.3966523",
                    Latitude = "-1.5670089",
                },
                new Practice
                {
                    Id = 10,
                    Name = "Phoenix Family Care",
                    AddressLine1 = "103 Leamington Road",
                    AddressLine2 = "Coventry",
                    AddressLine3 = "",
                    Postcode = "CV3 6GQ",
                    Longitude = "52.390024",
                    Latitude = "-1.515459"
                }
            );
        }
    }
}
