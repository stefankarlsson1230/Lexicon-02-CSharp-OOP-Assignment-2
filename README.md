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

