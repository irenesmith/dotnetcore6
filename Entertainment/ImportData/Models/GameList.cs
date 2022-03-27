using Newtonsoft.Json;

namespace ImportBooks.Models
{
    internal static class GameList
    {
        private const string gameFileName = @"C:\Users\irene\source\repos\CSharp10\Entertainment\games.json";

        public static List<Game> GetGames()
        {
            using var sr = new StreamReader(gameFileName);
            string json = sr.ReadToEnd();
            var games = JsonConvert.DeserializeObject<List<Game>>(json);

            return games;
        }
    }
}
