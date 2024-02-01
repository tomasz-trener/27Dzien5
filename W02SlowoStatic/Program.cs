using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02SlowoStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zawodnik.Nazwisko = "Nowak";

            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
          //  z.Nazwisko = "Kowalski";

            Zawodnik z2 = new Zawodnik();
            z2.Imie = "Adam";
            //  z2.Nazwisko = "Nowak";

            Zawodnik.Nazwisko = "Kowlaski";

            Console.WriteLine(z.PrzedstawSie());

            Zawodnik.PowiedzKimJest();
        }
    }
}
