using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public static class SeedData
    {
        public static void Intialize(IServiceProvider seviceProvider)
        {
            using (var context = new WebApplication1Context(
                seviceProvider.GetRequiredService<DbContextOptions<WebApplication1Context>>()))
            {
                if(context == null || context.Movie == null) 
                {
                    throw new ArgumentNullException("Null WebApplication1Context");
                }
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating ="R"
                    }, new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo ",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "NA"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
