namespace ImportBooks.Models
{
    internal class Video
    {
        public string? Collection { get; set; }
        public string Title { get; set; }
        public string? Season { get; set; }
        public List<string>? Director { get; set; }
        public string Format { get;set; }
        public bool HasVudu { get; set; }
        public List<string> Genre { get; set; }
        public string Owner { get; set; }
        public string Year { get; set; }
    }
}
