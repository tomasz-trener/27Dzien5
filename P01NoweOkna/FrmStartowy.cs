using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01NoweOkna
{
    public partial class FrmStartowy : Form
    {
        FrmNoweOkno frmNoweOkno = new FrmNoweOkno();
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnNoweOkno_Click(object sender, EventArgs e)
        {
            
            frmNoweOkno.Show();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            frmNoweOkno.TxtNoweOknoWiadomosc.Text = txtWiadomosc.Text;
         //   TextBox t1 = frmNoweOkno.TxtNoweOknoWiadomosc;
         //   t1.Text = "inna wartosc";

            // to jest niemozliwe poniewaz nie mamy zrobionego set
          //  frmNoweOkno.TxtNoweOknoWiadomosc = new TextBox();

        }
    }
}
