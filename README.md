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

