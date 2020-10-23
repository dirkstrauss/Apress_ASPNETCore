using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Collections;
using VideoStore.Core;
using VideoStore.Data;

namespace VideoStore.Pages.Videos
{
    public class EditModel : PageModel
    {
        private readonly IVideoData _videoData;
        private readonly IHtmlHelper _helper;

        public Video Video { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }

        public EditModel(IVideoData videoData, IHtmlHelper helper)
        {
            _videoData = videoData;
            _helper = helper;
        }

        public IActionResult OnGet(int videoId)
        {
            Genres = _helper.GetEnumSelectList<MovieGenre>();
            Video = _videoData.GetVideo(videoId);

            return Video == null ? RedirectToPage("./VideoError", new { message = "The video does not exist" }) : (IActionResult)Page();
        }
    }
}