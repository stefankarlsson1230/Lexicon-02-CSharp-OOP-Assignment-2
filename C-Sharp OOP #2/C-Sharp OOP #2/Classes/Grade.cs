namespace C_Sharp_OOP__2.Classes
{
    internal class Grade
    {
        // Properties
        public Guid GradeId { get; }
        public Course Course { get; }
        public Student Student { get; }
        public DateTime DateAcquired { get; set; }
        public GradeValue GradeAcquired { get; set; }  


        // Constructors
        public Grade(Course course, Student student, GradeValue gradeAquired)
        {
            GradeId = Guid.NewGuid();
            Course = course;
            Student = student;
            DateAcquired = DateTime.Now;
            GradeAcquired = gradeAquired;
        }


        // Methods
        public override string ToString()
        {
            return GradeAcquired switch
            {
                GradeValue.A => "A — Excellent: Outstanding performance; exceeds expectations with consistent accuracy and depth.",
                GradeValue.B => "B — Good: Strong performance; meets expectations with minor areas for improvement.",
                GradeValue.C => "C — Satisfactory: Adequate performance; meets basic requirements but lacks consistency or depth.",
                GradeValue.D => "D — Needs Improvement: Below expectations; significant gaps in understanding or execution.",
                GradeValue.E => "E — Poor: Performance is significantly below expectations; demonstrates limited understanding and requires substantial improvement to meet minimum standards.",
                GradeValue.F => "F — Unsatisfactory: Does not meet minimum requirements; major improvement needed.",
                _ => "Unknown grade"
            };
        }
    }

    // Enums
    public enum GradeValue { A, B, C, D, E, F}

}
