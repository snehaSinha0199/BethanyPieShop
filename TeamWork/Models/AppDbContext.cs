using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeamWork.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed students

            modelBuilder.Entity<Student>().HasData(
                new List<Student> {
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=1,FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=2,FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=3,FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=4,FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=5,FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },                                     
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=6,FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=7,FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=8,FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=9,FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=10,FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },                                      
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=11,FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=12,FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=13,FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=14,FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=15,FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=16,FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=17,FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=18,FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=19,FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=20,FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
                  new Student{EmailId="s.sneha@globallogic.com",StudentID=21,FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
                  });         
            
        }
    }
}
