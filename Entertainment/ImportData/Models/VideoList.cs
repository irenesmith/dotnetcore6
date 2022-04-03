using Newtonsoft.Json;

namespace ImportBooks.Models
{
    internal static class VideoList
    {
        private const string videoFileName = "videos.json";

        public static List<Video> GetVideos()
        {
            using var sr = new StreamReader(videoFileName);
            string json = sr.ReadToEnd();
            var videos = JsonConvert.DeserializeObject<List<Video>>(json);

            return videos;
        }
    }
}
