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

            //Run pending migrations
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //Populate the database with given seed data & additional data
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirstName = "Victor",
                        AuthLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = 9780451419439,
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumPages = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthFirstName = "Doris Kearns",
                        AuthLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 9780743270755,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumPages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthFirstName = "Alice",
                        AuthLastName = "Shroeder",
                        Publisher = "Bantam",
                        ISBN = 9780553384611,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumPages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthFirstName = "Ronald",
                        AuthLastName = "White",
                        Publisher = "Random House",
                        ISBN = 9780812981254,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumPages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthFirstName = "Laura",
                        AuthLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 9780812974492,
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumPages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthFirstName = "Michael",
                        AuthLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = 9780804171281,
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumPages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthFirstName = "Cal",
                        AuthLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 9781455586691,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumPages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthFirstName = "Michael",
                        AuthLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 9781455523023,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumPages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthFirstName = "Richard",
                        AuthLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = 9781591847984,
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumPages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthFirstName = "John",
                        AuthLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = 9780553393613,
                        Classification = "Fiction",
                        Category = "Thriller",
                        Price = 15.03,
                        NumPages = 642
                    },
                    new Book
                    {
                        Title = "Getting To Yes",
                        AuthFirstName = "Roger",
                        AuthLastName = "Fisher",
                        Publisher = "Penguin Books",
                        ISBN = 9780143118756,
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 18.00,
                        NumPages = 194
                    },
                    new Book
                    {
                        Title = "Oathbringer",
                        AuthFirstName = "Brandon",
                        AuthLastName = "Sanderson",
                        Publisher = "Tom Doherty Associates",
                        ISBN = 9780765326379,
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 23.26,
                        NumPages = 1233
                    },
                    new Book
                    {
                        Title = "Mere Christianity",
                        AuthFirstName = "C.S.",
                        AuthLastName = "Lewis",
                        Publisher = "HarperCollins Publishers",
                        ISBN = 9780060652883,
                        Classification = "Non-Fiction",
                        Category = "Theology",
                        Price = 12.99,
                        NumPages = 227
                    }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}
