internal class Program
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
    }
    private static void Main(string[] args)
    {
        Book[] books = new Book[]
               {
            new Book { Id = 1, Name = "Book 1", Author = "Author 1", Price = 1500, Publisher = "Publisher 1", Year = 2010 },
            new Book { Id = 2, Name = "Book 2", Author = "Author 2", Price = 3000, Publisher = "Publisher 2", Year = 2015 },
            new Book { Id = 3, Name = "Lập trình C#", Author = "Author 3", Price = 4500, Publisher = "Publisher 3", Year = 2015 },
            new Book { Id = 4, Name = "Book 4", Author = "Author 4", Price = 800, Publisher = "Publisher 1", Year = 2012 },
            new Book { Id = 5, Name = "Book 5", Author = "Author 5", Price = 5500, Publisher = "Publisher 4", Year = 2018 },
            new Book { Id = 6, Name = "Lập trình Java", Author = "Author 6", Price = 3500, Publisher = "Publisher 5", Year = 2015 },
            new Book { Id = 7, Name = "Book 7", Author = "Author 7", Price = 2500, Publisher = "Publisher 2", Year = 2020 },
            new Book { Id = 8, Name = "Book 8", Author = "Author 8", Price = 1800, Publisher = "Publisher 1", Year = 2013 },
            new Book { Id = 9, Name = "Lập trình Python", Author = "Author 9", Price = 4800, Publisher = "Publisher 6", Year = 2015 },
            new Book { Id = 10, Name = "Book 10", Author = "Author 10", Price = 6000, Publisher = "Publisher 3", Year = 2017 }
               };

        // Hiển thị tất cả các quyển sách
        Console.WriteLine("All books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Author: {book.Author}, Price: {book.Price}, Publisher: {book.Publisher}, Year: {book.Year}");
        }

        // Hiển thị những quyển sách có giá từ 1000-5000
        var affordableBooks = books.Where(book => book.Price >= 1000 && book.Price <= 5000);
        Console.WriteLine("\nAffordable books:");
        foreach (var book in affordableBooks)
        {
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Price: {book.Price}");
        }

        // Hiển thị những quyển sách xuất bản năm 2015
        var booksPublishedIn2015 = books.Where(book => book.Year == 2015);
        Console.WriteLine("\nBooks published in 2015:");
        foreach (var book in booksPublishedIn2015)
        {
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Year: {book.Year}");
        }

        // Hiển thị những quyển sách có tên "Lập trình"
        var programmingBooks = books.Where(book => book.Name.Contains("Lập trình"));
        Console.WriteLine("\nProgramming books:");
        foreach (var book in programmingBooks)
        {
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}");
        }

        // Đếm các quyển sách của nhà xuất bản "Giáo Dục"
        var publisher = "Giáo Dục";
        var booksFromPublisher = books.Count(book => book.Publisher == publisher);
        Console.WriteLine($"\nNumber of books from publisher '{publisher}': {booksFromPublisher}");
    }
}