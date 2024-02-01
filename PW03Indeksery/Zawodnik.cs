using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW03Indeksery
{
    internal class Zawodnik
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }

        public char this[int a]
        {
            get
            {
                return Nazwisko[a];
            }
        }

        public object this[string nazwaWlasciwosci]
        {
            get
            {
                return this.GetType().GetProperty(nazwaWlasciwosci).GetValue(this, null);
            }
            set
            {
                this.GetType().GetProperty(nazwaWlasciwosci).SetValue(this, value, null);
            }
        }
    }
}
