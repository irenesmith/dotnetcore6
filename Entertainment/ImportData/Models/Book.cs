namespace ImportBooks.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public List<string> Author { get; set; }
        public string Format { get; set; }
        public int Year { get; set; }
    }
}
