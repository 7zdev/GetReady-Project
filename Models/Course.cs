namespace GetreadyProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public string CourseLocalimage { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public int CourseNumberOfWeeks { get; set; }
        public string CourseCategory { get; set; }
        public string CourseSkills { get; set; }
        public int TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public Teacher Teacher { get; set; }
    }
}
