namespace EfCodeFirstDemo.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
