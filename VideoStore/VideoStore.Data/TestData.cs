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
                new Video { Id = 1, Title = "Sound of the Seven Seas", ReleaseDate = new DateTime(2018, 1, 21), Genre = MovieGenre.Action },
                new Video { Id = 2, Title = "A Day in the Sun", ReleaseDate = new DateTime(2019, 7, 2), Genre = MovieGenre.Drama },
                new Video { Id = 3, Title = "Wonders of the Universe", ReleaseDate = new DateTime(2020, 2, 14), Genre = MovieGenre.Romance }
            };
        }
        public IEnumerable<Video> ListVideos(string title = null) => _videoList
            .Where(x => string.IsNullOrEmpty(title) 
            || x.Title.StartsWith(title))
            .OrderBy(x => x.Title);
    }
}
