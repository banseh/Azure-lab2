namespace vc.d1.Models
{
    public record book(
     Guid Id,
     string Title,
     string Author,
     int YearPublished,
     string Publisher,
     double Price)
    {
        public string Name => $"{Title} By {Author}";
        public string ImageMarkup => $"""
        <figure class="figure">
            <figcaption class="figure-caption">{Publisher}</figcaption>
        </figure>
        """;

        private static readonly List<book> _books = new()
    {
        new book(Guid.NewGuid(), "The Great Gatsby", "F. Scott Fitzgerald", 1925, "Scribner", 12.99),
        new book(Guid.NewGuid(), "To Kill a Mockingbird", "Harper Lee", 1960, "J. B. Lippincott & Co.", 10.99),
        new book(Guid.NewGuid(), "1984", "George Orwell", 1949, "Secker & Warburg", 9.99),
        new book(Guid.NewGuid(), "Pride and Prejudice", "Jane Austen", 1813, "T. Egerton, Whitehall", 7.99),
        new book(Guid.NewGuid(), "The Catcher in the Rye", "J. D. Salinger", 1951, "Little, Brown and Company", 11.99),
        new book(Guid.NewGuid(), "Brave New World", "Aldous Huxley", 1932, "Chatto & Windus", 8.99),
        new book(Guid.NewGuid(), "The Hobbit", "J. R. R. Tolkien", 1937, "George Allen & Unwin", 13.99),
        new book(Guid.NewGuid(), "The Lord of the Rings", "J. R. R. Tolkien", 1954, "Allen & Unwin", 29.99),
        new book(Guid.NewGuid(), "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979, "Pan Books", 6.99),
        new book(Guid.NewGuid(), "Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997, "Bloomsbury", 14.99)
    };
        public static List<book> GetBooksList() => _books;
    }

}
