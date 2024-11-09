namespace Proxy;

public class YouTubeManager(IYouTubeService service) {
    protected IYouTubeService _service = service;

    public void RenderVideoPage(string id) {
        string info = _service.GetVideoInfo(id);
        Console.WriteLine($"Rendering video page for {id}: {info}");
    }

    public void RenderListPanel() {
        List<string> list = _service.ListVideos();
        Console.WriteLine("Rendering video list:");
        list.ForEach(Console.WriteLine);
    }
}