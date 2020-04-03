using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
    public class LocalBusinessContext : DbContext
    {
        public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Business>()
            .HasData(
                new Business { BusinessId = 6, Name = "Tiki", Manager = "Tom", YearJoined = 2007, CertNumber = 1234,MainAddress = "123 Street", Latitude = 123.123132m, Longitude = 234.34556m, Phone = "123-2345", Email = "sde@asdf.com", ADA = true }, 
                new Business { BusinessId = 7, Name = "Rexie", Manager = "Fred", YearJoined = 2010, CertNumber = 2345, MainAddress = "234 Street",  Longitude = 123.123456m, Latitude = 234.43589m, Phone = "123-1234", Email = "asd@asdf.com", ADA = false },
                new Business { BusinessId = 3, Name = "Matilda", Manager = "Steve", YearJoined = 2002, CertNumber = 3456, 
                MainAddress = "456 Street", Latitude = 123.456767m, Longitude = 345.67878m, Phone = "234-3456", Email = "arc@asdf.com", ADA = true },
                new Business { BusinessId = 4, Name = "Pip", Manager = "Becky", YearJoined = 2004, CertNumber = 4567, MainAddress = "567 Street",  Latitude = 123.123123m, Longitude = 678.23456m, Phone = "123-345-3456", Email = "asd@asd.com", ADA = true },
                new Business { BusinessId = 5, Name = "Annie", Manager = "Dinosaur", YearJoined = 2022, CertNumber = 5678, MainAddress = "876 Street", Latitude = 123.123m, Longitude = 456.23456m, Phone = "234-2345", Email = "ngr@asds.com", ADA = false }
            );
        }

    }
}