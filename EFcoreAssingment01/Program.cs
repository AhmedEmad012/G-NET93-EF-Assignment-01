using EFcoreAssingment01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFcoreAssingment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BooksDbContext dbContext = new BooksDbContext();

            try
            {
                dbContext.Database.EnsureCreated();

                Console.WriteLine("Database Created Successfully!");

                Console.WriteLine("Books: " + dbContext.Books.Count());
                Console.WriteLine("Authors: " + dbContext.Authors.Count());
                Console.WriteLine("Categories: " + dbContext.Categories.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

