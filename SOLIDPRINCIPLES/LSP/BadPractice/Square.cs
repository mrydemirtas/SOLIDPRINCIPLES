using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BadPractice
{
    class Square : Shape
    {
        private int _corner;

        public Square(int w, int h) : base(w, h)
        {
            _corner = w;
            _corner = h;
        }

        public Square(int corner):base(corner,corner)
        {
            _corner = corner;
        }

        public override double GetArea()
        {
            return this._corner * this._corner;
        }
    }
}
