namespace C_Sharp_OOP__2.Classes
{
    internal class Course
    {
        // Properties
        public Guid CourseId { get; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }


        // Constructor
        public Course (string name, Teacher teacher, List<Student> students)
        {
            CourseId = Guid.NewGuid();
            Name = name;
            Teacher = teacher;
            Students = students;
        }
    }
}
