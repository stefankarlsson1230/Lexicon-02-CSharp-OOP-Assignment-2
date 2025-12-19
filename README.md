# C# OOP Assignment 2 - The school application 
**Updated and clarified by ChatGPT**

## 1. Design principles & rules

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

