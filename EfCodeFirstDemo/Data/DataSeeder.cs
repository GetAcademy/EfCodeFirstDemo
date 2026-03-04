using EfCodeFirstDemo.Models;

namespace EfCodeFirstDemo.Data
{

    internal static class DataSeeder
    {
        public static void Seed(SchoolContext context)
        {
            if (context.Students.Any()) return; // allerede seedet

            var students = new List<Student>
            {
                new() { FullName = "Anna Andersen" },
                new() { FullName = "Bjørn Berg" },
                new() { FullName = "Camilla Christensen" },
                new() { FullName = "Daniel Dahl" },
                new() { FullName = "Ellen Eng" },
                new() { FullName = "Fredrik Fjell" },
                new() { FullName = "Grete Grønn" },
                new() { FullName = "Hans Hansen" },
                new() { FullName = "Ida Iversen" },
                new() { FullName = "Jonas Johansen" },
            };

            var courses = new List<Course>
            {
                new() { Title = "Intro to Programming" },
                new() { Title = "Databases 101" },
                new() { Title = "Web Development" },
                new() { Title = "Backend APIs" },
                new() { Title = "Cloud Basics" },
            };

            // assignments lages etter insert av courses

            context.Students.AddRange(students);
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var assignments = new List<Assignment>
            {
                new() { CourseId = courses[0].Id, Title = "Intro: Variables and Types" },
                new() { CourseId = courses[0].Id, Title = "Loops and Conditions" },
                new() { CourseId = courses[1].Id, Title = "Design a Simple Schema" },
                new() { CourseId = courses[1].Id, Title = "Write Basic SELECT Queries" },
                new() { CourseId = courses[2].Id, Title = "Build a Static Web Page" },
                new() { CourseId = courses[2].Id, Title = "Form Handling Basics" },
                new() { CourseId = courses[3].Id, Title = "Create a CRUD API" },
                new() { CourseId = courses[3].Id, Title = "Add Validation to Endpoints" },
                new() { CourseId = courses[4].Id, Title = "What is the Cloud?" },
                new() { CourseId = courses[4].Id, Title = "Deploying a Simple App" },
            };

            context.Assignments.AddRange(assignments);
            context.SaveChanges();

            var enrollments = new List<Enrollment>();
            var rand = new Random(42);
            var allStudentIds = students.Select(s => s.Id).ToList();
            var allCourseIds = courses.Select(c => c.Id).ToList();

            while (enrollments.Count < 25)
            {
                enrollments.Add(new Enrollment
                {
                    StudentId = allStudentIds[rand.Next(allStudentIds.Count)],
                    CourseId = allCourseIds[rand.Next(allCourseIds.Count)],
                    StartDate = new DateTime(2024, 1, 1).AddDays(rand.Next(0, 90))
                });
            }

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}