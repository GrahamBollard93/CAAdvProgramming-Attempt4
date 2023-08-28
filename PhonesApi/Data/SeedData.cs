using Microsoft.EntityFrameworkCore;
using PhonesApi.Models;

namespace PhonesApi.Data;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PhonesDbContext(serviceProvider.GetRequiredService<DbContextOptions<PhonesDbContext>>()))
        {
            // Look for any products.
            if (context.Phones.Any())
            {
            return; // DB has been seeded
            }
            // Look for any movies.
            if (context.Phones.Any())
            {
                return; // DB has been seeded
            }
            context.Phones.AddRange(
             new Models.Phones
            {
                Title = "A Space Odyssey",
                ReleaseDate =
            Convert.ToDateTime("1968-10-01"),
                Price =
            Convert.ToDecimal(8.99)
            },
            new Phones
            {
                Title = "Constantine",
                ReleaseDate =
            Convert.ToDateTime("2005-06-18"),
                Price =
            Convert.ToDecimal(9.99)
            },
            new Phones
            {
                Title = "Armageddon",
                ReleaseDate =
            Convert.ToDateTime("1998-01-23"),
                Price =
            Convert.ToDecimal(12.99)
            }
            );
            context.SaveChanges();
        }
    }
}