using BlazorAppWebAssembly.Models;

namespace BlazorAppWebAssembly
{
    public static class BookClient
    {
        
        public static Book[] GetBooks()
        {
            return books.ToArray();
        }

        private static readonly List<Book> books = new() //Add on top: @using BookStore.Client.Models;
            {
        new Book()
        {
            ID = 1,
            Name = "Java",
            Genre = "Programming",
            Price = 19.99M,
            PublishDate = new DateTime(2022,2,10)
        },
        new Book()
        {
            ID = 2,
            Name = "Data Science",
            Genre = "AI",
            Price = 39.99M,
            PublishDate = new DateTime(2023, 2, 10)
        },
        new Book()
        {
            ID = 3,
            Name = "Computer Systems",
            Genre = "Hardware",
            Price = 9.99M,
            PublishDate = new DateTime(2021,2,10)
        }
        };



        public static void AddBook(Book book)
        {
            book.ID = books.Max(book => book.ID) + 1;
            books.Add(book);
        }




    }
}
