using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VideoStore.Pages.Videos
{
    public class VideoErrorModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Message { get; set; }
        public void OnGet()
        {
            
        }
    }
}