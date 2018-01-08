using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.SRP.BestPractice.Models
{
    public class _Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
