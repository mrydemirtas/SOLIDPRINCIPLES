using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.OCP.BestPractice
{
    public abstract class AbstractTicket
    {
        public abstract void Sale(decimal unitPrice);
    }
}
