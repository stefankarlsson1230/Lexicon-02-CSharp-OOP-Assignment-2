using C_Sharp_OOP__2.Classes;

Student student = new("Totte", "Bengtsson", new DateTime(1974, 12, 30));

Console.WriteLine(student);
Console.WriteLine(student.GetAge());

Teacher teacher = new("Bliniken", "Orvar", new DateTime(1972, 01, 02));

Console.WriteLine(teacher);
Console.WriteLine(teacher.GetAge());