using System;

namespace _00_ChallengeW1D5_ClassAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FirstName = "David";
            user.LastName = "Gilchrist";
            user.BirthDate = new DateTime(1987, 7, 2);

            user.FullName();
            user.Age();

        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }

        public User()
        {

        }

        public User (string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthday;
        }

        public string FullName()
        {
            return (FirstName + " " + LastName);
        }

        public int Age()
        {
            return (DateTime.Now.Year - BirthDate.Year);

        }         
    }
}
