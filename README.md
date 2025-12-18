# C# OOP Assignment 2 - The school application

Make sure to read through the entire document before starting to code!

In assignment, your objective is to create a program that models a school. The school 
contains teachers and students and they can interact in different ways. The assignment 
is rather large so it will be divided into parts where we will create the different 
classes and then gradually combining them into a whole program. We will also modify the 
existing code with improvements as we go along, so remember to make a backup copy after 
each part. Do not however be intimidated to change your existing code, since this is a 
natural process in programming.

The assignment will be quite loose in instructions so you will have to figure out a lot 
of things on your own. Remember, there are always more than one way to do things!

One goal that you should aim towards, is to keep the business logic separate from the 
presentation. In this project, you will create a console program, but you should be 
able to easily grab the logic dealing with the school and put it into a website by 
only changing the way it’s presented. An example is that a student object should not 
know anything about a console, but only the other way around. This means, part 1 to 6 
should not involve any console output. (You are of course free to use console output 
to check your result but make sure to remove them when you are done)

An overview of the classes we will be creating in this exercise: 
- Student 
- Teacher 
- Course 
- Grade 
- School

To keep the project organized, create a new folder called Classes. Then as we go along, 
create all classes inside this folder as separate files.  

## Part 1. Creating the student class 
The student class contains some basic information about a student.

### Properties 
- StudentId
- Firstname
- Lastname
- DateOfBirth

Choose appropriate datatypes!

### Methods 
- Constructor - The constructor should have input parameters for first name, last name, 
date of birth. The student ID should be automatically generated (Tip, look at Guid)!
- ToString() - Override the default ToString-method to return the students full name, 
date of birth and Student ID in a readably format!
- GetAge() - This method should calculate and return the students age based on his date
of birth and return it as an integer! If you choose DateTime as datatype for date of 
birth you can subtract two dates two get a TimeSpan object that represent the time 
between the two dates. The TimeSpan contains TotalDays which contains the number of 
days between the dates. You can use this to calculate the number of years!


## Part 2. Creating the teacher class 
 
### Properties 
Like the student class, implement the properties first name, lastname, year of birth 
and instead of StudentId, create the property TeacherId instead. 

### Methods 
Implement the same methods as the student class, that is a Constructor, a ToString() 
method and a GetAge() method in the same way.


## Part 3 – Creating the Course class 
The Course class contains information about a specific course, information like the 
Teacher responsible for the course, a list of students enrolled to it and a name. 

### Properties 
- CourseId
- Name
- Teacher : (Datatype Teacher)
- Students : (Datatype List\<Student\>)

**(I also created a constructor)**

## Part 4 - Creating the Grade class 
The grade class will hold information about a grade that a student can acquire during
his time in the school!

### Properties 
- GradeId
- Course : (Datatype Course)
- Student : (Datatype Student)
- DateAcquired
- Grade - This should be implemented as an enum-type. The members of the enum should be 
the grades A-F, where A is the highest and F is the lowest. 

### Methods 
- ToString() - Override the default ToString()-method to return the name of the grade 
and a message depending on the Grading! What the message says, is up to you, but keep 
it moderate J Tip: Use a switch-statement to check which grade the user has! 

**(I used the property name GradeAcquired instead of Grade, and I added a Constructor)**

## Part 5 – Refactor common behaviour into a new class  
As you may have notices, the Teacher and Student classes contains a lot of redundant 
(repeating) information. So you are now going to break out the common properties 
and methods into a Person class and then let the Teacher and Student class inherit 
from it. Look through both the Student and Teacher class and see which information 
could be shared and put these into the Person class.


## Part 6 – Creating the School class
This class will serve as the common interface between the Students, Teachers, Course 
and Grades.

### Properties 
- Name
- Students : (Datatype List\<Student\>)
- Courses : (Datatype Dictionary\<String, Course\>)
- Teachers : (Datatype List\<Teacher\>)
- Grades : (Datatype List\<Grade\>)

### Methods 
- HasCourse( CourseId ) - Checks whether a course exists with the given (true/false)
- AddCourse( Course ) - Add a new course to the school, if the course already exist, 
throw an exception (If the course ID exists in the list of courses). If the course 
added does not have a courseId, throw an exception.
- RemoveCourse( CourseId ) - Removes a course with given course ID. If the course 
does not exist, throw an exception.
- IsSchoolEnrolled( StudentId ) - Check if a student is enrolled to the school (true/false)
- IsCourseEnrolled( CourseId, StudentId ) - Checks whether the student is enrolled 
to a given course. (true/false)
- EnrollCourse( CourseId , StudentId) - Enrols a student to a given course. If the 
student is already enrolled, throw an exception. A requirement here is that the student 
is enrolled to the school, and the course exists in the school.
- EnrolSchool(Student) - Enrols the student to the school. If the student is already 
enrolled, throw an exception. The studentId determines whether the student is enrolled 
or not.
- WithdrawFromSchool(StudentId) - Withdraws the student from the school, by removing 
him/her from the schools list of students. If the students is not previously enrolled, 
throw an exception.
- WithdrawFromCourse(CourseId, StudentId) - Removes a student from a given course, 
if the course or the student does not exist in the school, throw an exception.
- SetGrade(Grading, CourseId, StudentId) - Sets the students grade for a specific 
course. If the grade does exist, override the given value of that grade with the 
new one. Note, that you will only provide an enum value. The grade object should be 
created in the method. If the course or student does not exist, throw an exception.
- RemoveGrade(CourseId, StudentId) - Removes the grade for the given user!
- GetGrades(StudentId) - Returns the subset of the grades belonging to the given student 


## Part 7 - The console program

The next part will be to create the console program that the user will use to interact 
with the school application.

### Displaying
Create methods for displaying teachers, students, grades and course (separate) onto the 
console. When for example displaying teachers, you should output one teacher on each 
row in the console with all the properties in a nice format. Make one method for each 
case.

### Adding 
Create methods for adding a student, teacher, course to the school. When invoking a 
method, the method should stepwise ask for each property that is needed. If everything 
is inputted correctly, add the new object to the school.

Example for adding a student is:

1. Ask for a first name
2. Ask for a last name
3. Ask for a date of birth (You can use DateTime.Parse/TryParse to convert a textual date time into a DateTime object like: DateTime.Parse(“1983-08-22”))
4. Let your program generate a new student ID
5. Create a new Student object with the values
6. Add the object to the school

If you look back, we did create methods in the School class to enrol a new student to 
the school. That would be the business logic. The method above is the presentation 
“logic” for adding a new student from a console window. This means, that we could take 
the classes created in previous steps and use them in a Windows application or an 
ASP.NET web application and only have to create the presentation part for each 
application type, but still keep our business logic the same. In a web application we 
would instead add a new student by letting a user input the values into textboxes. 
By not letting the classes we created know anything about the console, we achieve what 
is called loose coupling which is something we want to strive for as programmers. 
This way we can easier reuse components that we create!

### Remove/Withdraw 
Add the functionality to let the user remove a course from the school, or withdrawing 
a student from the school. What could be done here, is to first use one of the methods 
you created for displaying all the students in the school. That should then display 
all students together with their ID numbers. Then let the user input the number to 
withdraw the student from the school.

Example:
1. Show all the students (So that the user knows which students exists)
2. Let the user input a student id 
3. Check if the student id is actually in the list
4. Remove the student with that ID

### Menu
Create a main menu to so that the user can choose what he want to do. Provide a list 
of options he can do.

Example menu:

1. Display all teachers
2. Display all students
3. Display all courses
4. Add a teacher
5. Add a student
6. Add a course
7. Withdraw a student
8. Withdraw a teacher
9. Withdraw a course
10. Show grades
11. Remove grade
12. Set grade

This menu could get kind of long, so here is a good idea to break it down into smaller 
pieces. Example would be:

Main menu:

1. Display teachers/students/courses
2. Add teacher/student/course
3. Withdraw student/teacher/course
4. Show/Remove/Set grades

Choosing number 1 would present the user with a sub menu like:

1. Display teachers
2. Display students
3. Display courses

As of now, our classes contains more methods than we have created presentation for. 
If you want to, feel free to create any menu option that you feel is missing!

Good luck!
