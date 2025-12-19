namespace C_Sharp_OOP__2.Classes
{
    internal class Student: Person
    {
        // Properties
        public Guid StudentId { get; }


        // Constructors
        public Student(string firstName, string lastName, DateTime dateOfBirth): base(firstName, lastName, dateOfBirth)
        {
            StudentId = Guid.NewGuid();
        }


        // Methods
        public override string ToString()
        {
            return $"Name: {Firstname} {Lastname} \nDate of birth: {DateOfBirth.ToShortDateString()}  \nStudent ID: {StudentId}";
        }
    }
}
