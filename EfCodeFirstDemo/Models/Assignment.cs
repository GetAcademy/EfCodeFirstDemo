namespace EfCodeFirstDemo.Models
{
    internal class Assignment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;

        public Course Course { get; set; } = null!;
    }
}
