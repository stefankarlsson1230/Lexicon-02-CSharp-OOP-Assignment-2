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

// AddCourse(Course ) - Add a new course to the school, if the course already exist, throw an exception(If the course ID exists in the list of courses). If the course added does not have a courseId, throw an exception.
// RemoveCourse(CourseId ) - Removes a course with given course ID.If the course does not exist, throw an exception.
// IsSchoolEnrolled(StudentId ) - Check if a student is enrolled to the school(true/false)
// IsCourseEnrolled(CourseId, StudentId ) - Checks whether the student is enrolled to a given course. (true/false)
// EnrollCourse(CourseId , StudentId) - Enrols a student to a given course.If the student is already enrolled, throw an exception.A requirement here is that the student is enrolled to the school, and the course exists in the school.
// EnrolSchool(Student) - Enrols the student to the school. If the student is already enrolled, throw an exception. The studentId determines whether the student is enrolled or not.
// WithdrawFromSchool(StudentId) - Withdraws the student from the school, by removing him/her from the schools list of students.If the students is not previously enrolled, throw an exception.
// WithdrawFromCourse(CourseId, StudentId) - Removes a student from a given course, if the course or the student does not exist in the school, throw an exception.
// SetGrade(Grading, CourseId, StudentId) - Sets the students grade for a specific course.If the grade does exist, override the given value of that grade with the new one.Note, that you will only provide an enum value. The grade object should be created in the method.If the course or student does not exist, throw an exception.
// RemoveGrade(CourseId, StudentId) - Removes the grade for the given user!
// GetGrades(StudentId) - Returns the subset of the grades belonging to the given student


    }
}
