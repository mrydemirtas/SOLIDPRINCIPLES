using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BestPractice
{
    public class _Square:AbstractShape
    {
        int _c;

        public _Square(int c)
        {
            _c = c;
        }

        public override int Diagonal
        {
            get
            {
                return 4;
            }
        }

        public override double GetArea()
        {
            return Math.Pow(_c, 2);
        }

        public override double GetPerimetre()
        {
            throw new NotImplementedException();
        }
    }
}
