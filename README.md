# C# OOP Assignment 2 - The school application 
**Updated and clarified by ChatGPT**

## Design principles & rules

Before starting, students must follow these rules:

### Separation of Concerns
- **Domain classes (Parts 1–6)** must not use Console, Console.WriteLine, or any UI logic.
- **All business logic** must be handled by the School class.
- The **console application (Part 7)** is presentation-only.

### IDs
- All IDs must be of type Guid.
- IDs are generated automatically inside constructors.

### Enrollment Rules
- A student must be enrolled in the school before enrolling in any course.
- A student must be enrolled in a course before receiving a grade.
- When a student or course is removed, **related grades must also be removed.**

### Error Handling
- Use standard exceptions:
	- ArgumentException
	- InvalidOperationException
- Custom exceptions are optional (bonus).


## Assignment Specification
In this assignment, you will create a program that models a school system. The school 
contains students, teachers, courses, and grades, and manages how they interact.

The assignment is divided into parts. You are expected to refactor and improve your 
code as you go. This is a natural part of programming.

**Important:**
Parts 1–6 must contain *no console input or output*.
Only Part 7 may use Console.

### Overview of Classes
- Person (base class)
- Student
- Teacher
- Course
- Grade
- School

Create a folder named **Classes**, and place each class in its own file.

## Part 1 – Student Class

### Properties
- Guid StudentId
- string FirstName
- string LastName
- DateTime DateOfBirth

### Methods
- **Constructor**
	- Accepts first name, last name, and date of birth
	- Automatically generates StudentId
- **int GetAge()**
	- Returns the student’s exact age in years
- **override string ToString()**
	- Returns full name, date of birth, and ID in a readable format


## Part 2 – Teacher Class

### Properties
- Guid TeacherId
- string FirstName
- string LastName
- DateTime DateOfBirth

### Methods
- Same as Student:
	- Constructor
	- GetAge()
	- ToString()

## Part 3 – Course Class

### Properties
- Guid CourseId
- string Name
- Teacher Teacher
- List\<Student\> Students (read-only list)

### Constructor
- Accepts course name and teacher
- Automatically generates CourseId
- Initializes student list

⚠️ **Important:**
Students should only be added or removed via the School class.


## Part 4 – Grade Class

### Enum

	enum GradeValue
	{
		A, B, C, D, E, F
	}


### Properties
- Guid GradeId
- Student Student
- Course Course
- GradeValue Value
- DateTime DateAcquired

### Methods
- **Constructor**
	- Accepts student, course, and grade value
- **override string ToString()**
	- Returns grade and a short message depending on the value
	- Use a switch statement


## Part 5 – Refactor into Person Class
Create a base class Person.

### Properties
- string FirstName
- string LastName
- DateTime DateOfBirth

### Methods
- int GetAge()
- override string ToString()

Both Student and Teacher must inherit from Person.


## Part 6 – School Class
This class contains all business logic.

### Properties
- string Name
- List\<Student\> Students
- List\<Teacher\> Teachers
- Dictionary\<Guid, Course\> Courses
- List\<Grade\> Grades

### Methods
**Course Management**
- bool HasCourse(Guid courseId)
- void AddCourse(Course course)
- void RemoveCourse(Guid courseId)

**Student Management**
- void EnrollStudent(Student student)
- void WithdrawStudent(Guid studentId)
- bool IsStudentEnrolled(Guid studentId)

**Course Enrollment**
- bool IsStudentEnrolledInCourse(Guid courseId, Guid studentId)
- void EnrollStudentInCourse(Guid courseId, Guid studentId)
- void WithdrawStudentFromCourse(Guid courseId, Guid studentId)

**Grades**
- void SetGrade(GradeValue value, Guid courseId, Guid studentId)
- void RemoveGrade(Guid courseId, Guid studentId)
- List\<Grade\> GetGradesForStudent(Guid studentId)

**Validation Rules**
- Throw exceptions if:
	- Course or student does not exist
	- Student is not enrolled
	- Duplicate enrollment occurs

 
## Part 7 – Console Application
Create a console program that interacts with the School class.

### Display
- Display students
- Display teachers
- Display courses
- Display grades

### Add
- Add student
- Add teacher
- Add course

### Withdraw / Remove
- Withdraw student
- Remove course
- Withdraw student from course

### Grades
- Set grade
- Remove grade
- Show grades for a student


### Menu Structure (Recommended)
**Main Menu**
1. Display
2. Add
3. Withdraw / Remove
4. Grades
5. Exit

Each option opens a sub-menu.

