using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZawodnicyCRUD
{
    public enum TrybOkienka
    {
        Dodwanie,
        Edycja,
        Podglad
    }

    public partial class FrmSzczegoly : Form
    {
        private Zawodnik wyswietlany;
        private readonly FrmStartowy frmStartowy;
        private readonly TrybOkienka trybOkienka;
        private readonly ManagerZawodnikow mz;

        public FrmSzczegoly(FrmStartowy frmStartowy, TrybOkienka trybOkienka, ManagerZawodnikow mz)
        {
            InitializeComponent();
            this.frmStartowy = frmStartowy;
            this.trybOkienka = trybOkienka;
            this.mz = mz;
        }

        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy frmStartowy, TrybOkienka trybOkienka, ManagerZawodnikow mz) : this(frmStartowy, trybOkienka,mz)
        {
          
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;

            wyswietlany = zawodnik;
            
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (trybOkienka == TrybOkienka.Edycja)
            {
                zczytajDaneZKontrolek();
                frmStartowy.Zapisz();    
            }
            else if (trybOkienka== TrybOkienka.Dodwanie)
            {
                wyswietlany = new Zawodnik();
                zczytajDaneZKontrolek();
                mz.Dodaj(wyswietlany);
                frmStartowy.Zapisz();
            }


            this.Close();
            frmStartowy.Odswiez();

        }

        private void zczytajDaneZKontrolek()
        {
            wyswietlany.Imie = txtImie.Text;
            wyswietlany.Nazwisko = txtNazwisko.Text;
            wyswietlany.Kraj = txtKraj.Text;
            wyswietlany.DataUrodzenia = dtpDataUr.Value;
            wyswietlany.Waga = Convert.ToInt32(numWaga.Value);
            wyswietlany.Wzrost = Convert.ToInt32(numWaga.Value);
        }
    }
}
