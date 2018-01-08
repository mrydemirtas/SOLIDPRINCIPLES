using SOLIDPRINCIPLES.SRP.BadPractice;
using SOLIDPRINCIPLES.SRP.BestPractice.Interfaces;
using SOLIDPRINCIPLES.SRP.BestPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.SRP.BestPractice.Services
{
    public class EmployeeRepo : IRepository<_Employee>
    {
        public void Delete(int id)
        {
            
        }

        public void Insert(_Employee entity)
        {
           
        }
    }
}
