using Microsoft.EntityFrameworkCore;

namespace BazoWebbApp.Data
{
    public class ApplicatioDbContext : DbContext
    {
        public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext> options) : base(options)
        {

        }
    }
}
