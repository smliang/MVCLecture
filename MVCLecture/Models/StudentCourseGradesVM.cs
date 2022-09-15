namespace MVCLecture.Models
{
    public class StudentCourseGradesVM
    {
        public Student? Student { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Grade>? Grades { get; set; }

    }
}
