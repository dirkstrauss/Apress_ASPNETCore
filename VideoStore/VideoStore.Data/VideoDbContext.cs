using Microsoft.EntityFrameworkCore;
using VideoStore.Core;

namespace VideoStore.Data
{
    public class VideoDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
