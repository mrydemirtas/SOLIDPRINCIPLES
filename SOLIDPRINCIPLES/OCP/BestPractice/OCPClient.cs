using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.OCP.BestPractice
{
    public class OCPClient
    {

        AbstractTicket _ticket;

        public OCPClient(AbstractTicket ticket)
        {
            _ticket = ticket;

        }

        public void Sale(decimal unitPrice)
        {
            _ticket.Sale(unitPrice);
        }
    }
}
