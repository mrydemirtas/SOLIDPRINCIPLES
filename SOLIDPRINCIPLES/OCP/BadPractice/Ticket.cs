using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES.OCP.BadPractice
{
    public class Ticket
    {
        ////Öğrenciye indirim
        ////Öğretmen İndirimli
        ////65 yaş üstü %50
        //Tam

            //Her kullanıcı isteğinde sınıf değişiyor. => Modification yapılıyor o zaman değişime açık. OCP uymuyor.
        public void Sale(decimal price,string satisTip)
        {
            //satmak ile ilgili kodlar

            if (satisTip=="Ogrenci")
            {
                //Ogrenci Kodlaro
            }
            else if (satisTip=="TAM")
            {
                //TAM
            }
        }

    }
}
