using Newtonsoft.Json;

namespace ImportBooks.Models
{
    internal static class BookList
    {
        private const string bookFileName = @"C:\Users\irene\source\repos\CSharp10\Entertainment\books2021.json";

        public static List<Book> GetBooks()
        {
            using var sr = new StreamReader(bookFileName);
            string json = sr.ReadToEnd();
            var books = JsonConvert.DeserializeObject<List<Book>>(json);

            return books;
        }
    }
}
