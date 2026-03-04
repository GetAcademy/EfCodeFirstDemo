namespace EfCodeFirstDemo.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    }
}
