using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotnaFinalPro.Models
{
    public class RobotnaDbContext: DbContext
    {
        public RobotnaDbContext(DbContextOptions<RobotnaDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Venu> Venus { get; set; }
        public DbSet<Instructor> instructors { get; set; }

        

    }
}
