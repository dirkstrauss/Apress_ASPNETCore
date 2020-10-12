using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoStore.Core;
using VideoStore.Data;

namespace VideoStore.Pages.Videos
{
    public class DetailModel : PageModel
    {
        private readonly IVideoData _videoData;

        public Video Video { get; set; }

        public DetailModel(IVideoData videoData)
        {
            _videoData = videoData;
        }

        public void OnGet(int videoId)
        {
            Video = _videoData.GetVideo(videoId);
        }
    }
}