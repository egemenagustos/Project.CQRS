using Microsoft.EntityFrameworkCore;

namespace Project.CQRS.Data
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new()
                {
                    Id = 1,
                    Name = "Egemen",
                    Surname = "Agustos",
                    Age = 21
                },
                new()
                {
                    Id = 2,
                    Name = "Yavuz",
                    Surname = "Selim",
                    Age = 25
                }
            });
        }
    }
}
