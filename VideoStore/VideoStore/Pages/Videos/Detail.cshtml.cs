using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoStore.Core;

namespace VideoStore.Pages.Videos
{
    public class DetailModel : PageModel
    {
        public Video Video { get; set; }

        public void OnGet(int videoId)
        {
            Video = new Video();
            Video.Id = videoId;
        }
    }
}