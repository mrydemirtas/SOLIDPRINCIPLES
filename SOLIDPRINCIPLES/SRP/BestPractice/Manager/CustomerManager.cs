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
    public class CustomerManager
    {
        Customer _c;
        IMessageSender sender;

        public CustomerManager(Customer c)
        {
            _c = c;
            sender = new MessageService();
        }

        public void SendMessage(string message)
        {
            sender.SendMessage(message);
        }

    }
}
