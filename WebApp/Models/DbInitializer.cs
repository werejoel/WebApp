namespace WebApp.Models
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            var students = new[]
            {
            new Student { Name = "Joel", CourseName = "ComputerScience", EnrollmentDate = DateTime.Now },
            new Student { Name = "Bob",   CourseName = "Engineering", EnrollmentDate = DateTime.Now },
            new Student { Name = "Timothy", CourseName = "InformationTechnology", EnrollmentDate = DateTime.Now },
            new Student { Name = "Alice",   CourseName = "Nursing", EnrollmentDate = DateTime.Now },
        };



            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
