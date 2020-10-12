using System;
using System.Collections.Generic;
using System.Linq;
using VideoStore.Core;

namespace VideoStore.Data
{
    public class TestData : IVideoData
    {
        List<Video> _videoList;
        public TestData()
        {
            _videoList = new List<Video>()
            {
                new Video { Id = 1, Title = "Sound of the Seven Seas", ReleaseDate = new DateTime(2018, 1, 21), Genre = MovieGenre.Action, Price = 5.99, LentOut = false, LentTo = "" },
                new Video { Id = 2, Title = "A Day in the Sun", ReleaseDate = new DateTime(2019, 7, 2), Genre = MovieGenre.Drama, Price = 4.59, LentOut = false, LentTo = "" },
                new Video { Id = 3, Title = "Wonders of the Universe", ReleaseDate = new DateTime(2020, 2, 14), Genre = MovieGenre.Romance, Price = 12.99, LentOut = true, LentTo = "Joah Sanderson" }
            };
        }
        public IEnumerable<Video> ListVideos(string title = null) => _videoList
            .Where(x => string.IsNullOrEmpty(title) 
            || x.Title.StartsWith(title))
            .OrderBy(x => x.Title);

        public Video GetVideo(int id) => _videoList.SingleOrDefault(x => x.Id == id);
    }
}
