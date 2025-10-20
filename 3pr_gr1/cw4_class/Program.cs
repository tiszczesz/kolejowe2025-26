using cw4_class;
using cw4_class.Models;

Book book = new Book();
book.Title = "    The Great Gatsby";
book.Author = " F. Scott Fitzgerald ";
book.Year = 1925;
Book book2 = new Book("1984", "George Orwell", true, 1949);
Console.WriteLine(book);
Console.WriteLine(book2);
book.ShowInfo();