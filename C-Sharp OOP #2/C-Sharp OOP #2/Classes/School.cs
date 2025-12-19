using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_OOP__2.Classes
{
    internal class School
    {
        // Properties
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Grade> Grades { get; set; }


        // Constructors
        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
            Courses = new List<Course>();
            Teachers = new List<Teacher>();
            Grades = new List<Grade>();
        }


        // Methods
        public bool HasCourse(Guid courseId)
        {
            foreach (Course course in Courses)
            {
                if (course.CourseId == courseId) return true;
            }

            return false;
        }

        public void AddCourse(Course course)
        {

        }




    }
}
