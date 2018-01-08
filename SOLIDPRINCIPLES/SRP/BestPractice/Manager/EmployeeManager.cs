using SOLIDPRINCIPLES.SRP.BadPractice;
using SOLIDPRINCIPLES.SRP.BestPractice.Interfaces;
using SOLIDPRINCIPLES.SRP.BestPractice.Models;
using SOLIDPRINCIPLES.SRP.BestPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.SRP.BestPractice.Manager
{
    public class EmployeeManager
    {
        EmployeeRepo _repo;
        IMessageSender _sender;
        _Employee _emp;


        public EmployeeManager(_Employee emp)
        {
            _emp = emp;
            _repo = new EmployeeRepo();
        }

        public EmployeeManager(IMessageSender sender,_Employee emp):this(emp)
        {
            _emp = emp;
            _sender = sender;
        }

        public void Insert()
        {
            _repo.Insert(_emp);
        }

        public void SendMessage(string message)
        {
            _sender.SendMessage(message);
        }
    }
}
