using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.DIP.BadPractice
{
    //IOService DBIO,ExcelIO,TextIO
    //TextIO bozuldu IOService değişmeli abi :)
    //IOService üst seviye sınıf
    //DBIO,ExcelIO,TextIO alt seviye sınıf
    //Concrete yani instance alınan somut sınıflar.
    //Bu seneryoda IOService değimiz üst sınıf alt sınıflara sıkı sıkıya bağlı.
    //Bağımlılıkları tersine çevirerek aslında alt sınıflar üst sınıfa bağımlı olmalıdır. Bunada bağımlılıkların ters çevrilmesi dependency inversion denir. (Araya Interface eklenerek uygulanır.)
    public class IOService
    {
        private DBIO databaseOperation;
        private ExcelIO excelOperation;
        private TextIO textOperation;

        public IOService(DBIO databaseOp)
        {
            databaseOperation = databaseOp;
        }

        public IOService(ExcelIO excelOp)
        {
            excelOperation = excelOp;
        }

        public IOService(TextIO textOp)
        {
            textOperation = textOp;
        }

        public void Write(string path,string name)
        {
            if (databaseOperation !=null)
            {
                databaseOperation.Write(path, name);
            }
            else if (excelOperation!=null)
            {
                excelOperation.Write(path, name);
            }
            else if (textOperation!=null)
            {
                textOperation.Write(path, name);
            }
        }

        public void Read(string path, string name)
        {
            if (databaseOperation != null)
            {
                databaseOperation.Write(path, name);
            }
            else if (excelOperation != null)
            {
                excelOperation.Write(path, name);
            }
            else if (textOperation != null)
            {
                textOperation.Write(path, name);
            }
        }


    }
}
