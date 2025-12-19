namespace C_Sharp_OOP__2.Classes
{
    internal class Teacher: Person
    {
        // Properties
        public Guid TeacherId { get; }
        

        // Constructors
        public Teacher(string firstName, string lastName, DateTime dateOfBirth): base(firstName, lastName, dateOfBirth)
        {
            TeacherId = Guid.NewGuid();
        }


        // Methods
        public override string ToString()
        {
            return $"Name: {Firstname} {Lastname} \nDate of birth: {DateOfBirth.ToShortDateString()}  \nTeacher ID: {TeacherId}";
        }
    }
}
