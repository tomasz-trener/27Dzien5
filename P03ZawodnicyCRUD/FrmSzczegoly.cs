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
    public partial class FrmSzczegoly : Form
    {
        private Zawodnik wyswietlany;
        private readonly FrmStartowy frmStartowy;
        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy frmStartowy)
        {
            InitializeComponent();

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;

            wyswietlany = zawodnik;
            this.frmStartowy = frmStartowy;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            zczytajDaneZKontrolek();
            frmStartowy.Zapisz();
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
