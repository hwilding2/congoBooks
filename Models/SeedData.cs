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
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = 9780451419439,
                        Category = "Fiction, Classic",
                        Price = 9.95
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 9780743270755,
                        Category = "Non-Fiction, Biography",
                        Price = 14.58
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Shroeder",
                        Publisher = "Bantam",
                        ISBN = 9780553384611,
                        Category = "Non-Fiction, Biography",
                        Price = 21.54
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald White",
                        Publisher = "Random House",
                        ISBN = 9780812981254,
                        Category = "Non-Fiction, Biography",
                        Price = 11.61
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 9780812974492,
                        Category = "Non-Fiction, Historical",
                        Price = 13.33
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = 9780804171281,
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 9781455586691,
                        Category = "Non-Fiction, Self-Help",
                        Price = 14.99
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 9781455523023,
                        Category = "Non-Fiction, Self-Help",
                        Price = 21.66
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = 9781591847984,
                        Category = "Non-Fiction, Business",
                        Price = 29.16
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = 9780553393613,
                        Category = "Fiction, Thrillers",
                        Price = 15.03
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
