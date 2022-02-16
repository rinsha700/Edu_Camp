using Edu_Camp.Models;
using Microsoft.EntityFrameworkCore;

namespace Edu_Camp.Data
{
    public class EduCampDbContext:DbContext
    {
        public EduCampDbContext(DbContextOptions<EduCampDbContext> options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
    }
}
