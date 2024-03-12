using Microsoft.EntityFrameworkCore;

namespace Task2.Models
{
    public class ITIEntities :DbContext
    {
        public ITIEntities() : base()
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Task2DB ;Integrated Security=True");
        }
    }
}
