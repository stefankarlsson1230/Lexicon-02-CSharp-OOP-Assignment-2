namespace C_Sharp_OOP__2.Classes
{
    internal class Teacher
    {
        // Properties
        public Guid TeacherId { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }


        // Constructors
        public Teacher(string firstName, string lastName, DateTime dateOfBirth)
        {
            TeacherId = Guid.NewGuid();
            Firstname = firstName;
            Lastname = lastName;
            DateOfBirth = dateOfBirth;
        }

        // Methods
        public override string ToString()
        {
            return $"Name: {Firstname} {Lastname} \nDate of birth: {DateOfBirth.ToShortDateString()}  \nStudent ID: {TeacherId}";
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.Month > DateOfBirth.Month) return age;
            else if (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day >= DateOfBirth.Day) return age;
            else return age - 1;
        }
    }
}
