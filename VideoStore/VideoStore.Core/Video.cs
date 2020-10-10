using System;

namespace VideoStore.Core
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieGenre Genre { get; set; }
        public double Price { get; set; }
        public bool LentOut { get; set; }
        public string LentTo { get; set; }
    }
}
