using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            CongoDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CongoDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        //BookID = 1,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 9780451419439,
                        Category = "Fiction, Classic",
                        Price = 9.95
                    },
                    new Book
                    {
                        //BookID = 2,
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 9780743270755,
                        Category = "Non-Fiction, Biography",
                        Price = 14.58
                    },
                    new Book
                    {
                        //BookID = 3,
                        Title = "The Snowball",
                        Author = "Alice Shroeder",
                        Publisher = "Bantam",
                        ISBN = 9780553384611,
                        Category = "Non-Fiction, Biography",
                        Price = 21.54
                    },
                    new Book
                    {
                        //BookID = 4,
                        Title = "American Ulysses",
                        Author = "Ronald White",
                        Publisher = "Random House",
                        ISBN = 9780812981254,
                        Category = "Non-Fiction, Biography",
                        Price = 11.61
                    },
                    new Book
                    {
                        //BookID = 4,
                        Title = "American Ulysses",
                        Author = "Ronald White",
                        Publisher = "Random House",
                        ISBN = 9780812981254,
                        Category = "Non-Fiction, Biography",
                        Price = 11.61
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
