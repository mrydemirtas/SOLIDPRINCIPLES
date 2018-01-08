using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BestPractice
{
    public class _Rect:AbstractShape
    {
        private int _h;
        private int _w;

        public _Rect(int h,int w)
        {
            _h = h;
            _w = w;
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
            return _h * _w;
        }

        public override double GetPerimetre()
        {
            throw new NotImplementedException();
        }
    }
}
