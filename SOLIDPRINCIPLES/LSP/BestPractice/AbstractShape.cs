using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.LSP.BestPractice
{
    public abstract class AbstractShape
    {
        public abstract double GetArea();
        public abstract double GetPerimetre();
        //Köşegen sayısı
        public abstract int Diagonal { get; }
    }
}
