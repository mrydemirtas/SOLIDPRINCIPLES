using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BadPractice
{
    public class Rect : Shape
    {
        private int h;
        private int w;

        public Rect(int w, int h) : base(w, h)
        {
            this.h = h;
            this.w = w;
        }

        public override double GetArea()
        {
            return this.h * this.w;
        }
    }
}
