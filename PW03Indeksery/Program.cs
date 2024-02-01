using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW03Indeksery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = { "ala", "ma", "kota" };
            string s = tablica[1];

            string napis = "ala ma kota";
            char znak = napis[4]; //m  indekser
                                  
            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
            z.Nazwisko = "Kowalski";

            char c = z[1]; //o 


            string s1 = (string)z["Imie"];
            string s2 = z.Imie;
        }
    }
}
