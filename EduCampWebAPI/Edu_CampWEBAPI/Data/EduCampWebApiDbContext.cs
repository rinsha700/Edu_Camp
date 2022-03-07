using Edu_CampWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Edu_CampWEBAPI.Data
{
    public class EduCampWebApiDbContext:DbContext
    {
        public EduCampWebApiDbContext(DbContextOptions<EduCampWebApiDbContext> options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
    }
}

