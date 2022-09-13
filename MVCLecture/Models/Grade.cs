using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLecture.Models
{
    public class Grade
    {

        public int Id { get; set; }
        public string GradeValue { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; } // always make foreign key relationship nullable

        public int? StudentId { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
        public int? CourseId { get; set; }
    }
}
