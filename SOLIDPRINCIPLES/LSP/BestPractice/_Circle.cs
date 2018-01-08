using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BestPractice
{
    public class _Circle : AbstractShape
    {
        double _r;

        public _Circle(double r)
        {
            _r = r;
        }

        public override int Diagonal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }

        public override double GetPerimetre()
        {
            return 2 * Math.PI * _r;
        }
    }
}
