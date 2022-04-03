using ImportBooks.Models;

var books= BookList.GetBooks();
books.ForEach(book =>
{
    Console.WriteLine($"Title: { book.Title}");
    Console.Write("Author(s):");
    book.Author.ForEach(author => Console.WriteLine($"\t{author}"));
    Console.WriteLine($"Format: { book.Format}");
    Console.WriteLine($"Year: { book.Year}\n");
});

var games = GameList.GetGames();
games.ForEach(game =>
{
    Console.WriteLine($"Title: { game.Title}");
    Console.WriteLine($"Console: {game.Console}");
    Console.WriteLine($"ESRB: {game.Esrb}");
    Console.WriteLine($"Players: {game.Players}");
    Console.WriteLine($"Owner: {game.Owner}\n");
});

var videos = VideoList.GetVideos();
Console.WriteLine($"Number of videos: {videos.Count}");
