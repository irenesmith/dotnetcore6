using Newtonsoft.Json;

namespace ImportBooks.Models
{
    internal static class VideoList
    {
        private const string videoFileName = @"C:\Users\irene\source\repos\CSharp10\Entertainment\videos.json";

        public static List<Video> GetVideos()
        {
            using var sr = new StreamReader(videoFileName);
            string json = sr.ReadToEnd();
            var videos = JsonConvert.DeserializeObject<List<Video>>(json);

            return videos;
        }
    }
}
