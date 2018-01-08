using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BadPractice
{
    public abstract class Shape
    {
        private int width;
        private int height;

        public Shape(int w,int h)
        {
            width = w;
            height = h;
        }

        public abstract double GetArea();
 
    }
}
