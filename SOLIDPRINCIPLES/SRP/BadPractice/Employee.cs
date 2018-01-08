using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.SRP.BadPractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        //Infrastructure => SMS veya Email Servis external
        public void SendMessage(string message)
        {

        }

        //Infrastructure => Database  internal
        public void AddToDB(Employee emp)
        {

        }


    }
}
