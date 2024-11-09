namespace Proxy;

public interface IYouTubeService {
    List<string> ListVideos();
    string GetVideoInfo(string id);
}

public class YouTubeService : IYouTubeService {
    public List<string> ListVideos() {
        Console.WriteLine("Fetching video list from YouTube... (3s)");
        return ["Video1", "Video2", "Video3"];
    }

    public string GetVideoInfo(string id) {
        Console.WriteLine($"Fetching video info for {id} from YouTube... (1s)");
        return $"Info about {id}";
    }
}

public class YouTubeCachedProxy(YouTubeService service) : IYouTubeService {
    private List<string>? listCache;
    private readonly Dictionary<string, string> videoCache = [];
    private readonly YouTubeService service = service;

    public List<string> ListVideos() {
        listCache ??= service.ListVideos();
        return listCache;
    }

    public string GetVideoInfo(string id) {
        if (!videoCache.TryGetValue(id, out var info)) {
            info = service.GetVideoInfo(id);
            videoCache[id] = info;
        }
        return info;
    }
}