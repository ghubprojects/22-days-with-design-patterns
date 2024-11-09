using Proxy;

var youTubeService = new YouTubeService();
var youTubeCachedService = new YouTubeCachedProxy(youTubeService);
var youTubeManager = new YouTubeManager(youTubeCachedService);

youTubeManager.RenderListPanel();
youTubeManager.RenderListPanel();
youTubeManager.RenderVideoPage("Video2");
youTubeManager.RenderVideoPage("Video2");
