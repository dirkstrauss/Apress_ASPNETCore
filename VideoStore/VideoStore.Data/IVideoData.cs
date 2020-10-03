using System;
using System.Collections.Generic;
using System.Text;
using VideoStore.Core;

namespace VideoStore.Data
{
    public interface IVideoData
    {
        IEnumerable<Video> ListVideos();
    }
}
