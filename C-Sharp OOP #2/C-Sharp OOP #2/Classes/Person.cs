namespace C_Sharp_OOP__2.Classes
{
    internal class Person
    {
        // Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }


        // Constructor
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            Firstname = firstName;
            Lastname = lastName;
            DateOfBirth = dateOfBirth;
        }

        // Methods
        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.Month > DateOfBirth.Month) return age;
            else if (DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day >= DateOfBirth.Day) return age;
            else return age - 1;
        }
    }
}
