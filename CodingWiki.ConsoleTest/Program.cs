// See https://aka.ms/new-console-template for more information
using CodingWiki.DataAccess.Data;
using CodingWiki.Models.Models;

Console.WriteLine("Hello, World!");
using var applicationDbCOntext = new ApplicationDbContext();
try
{
    var book = new Book()
    {
        ISBN = "ISBN1",
        Price = 23.5m,
        Title = "Peenugaa"

    };
    applicationDbCOntext.Books.Add(book);
    applicationDbCOntext.SaveChanges();
}catch(Exception ex)
{
    Console.WriteLine($"Error : {ex.Message}");
}

Console.ReadLine();