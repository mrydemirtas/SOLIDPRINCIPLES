using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.DIP.BestPractice
{
    public interface IWriter
    {
        void Write(string path, string text);
    }
}
