using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.DIP.BestPractice
{
    public class _IOService
    {
        IReader _reader;
        IWriter _writer;

        public _IOService(IReader reader)
        {
            _reader = reader;
        }

        public _IOService(IReadAndIWrite readerAndWriter)
        {
            _writer = readerAndWriter;
            _reader = readerAndWriter;
        }

        public void Write(string path,string text)
        {
            if (_writer!=null)
            {
                _writer.Write(path, text);
            }
        }

        public void Read(string path,string data)
        {
            _reader.Read(path, data);
        }


    }
}
