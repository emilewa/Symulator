using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt4
{
    
    public partial class Form1 : Form
    {
        private bool[][] tekst;
        Form2 odbiorca = new Form2();

        public Form1()
        {
            InitializeComponent();
            odbiorca.Show();
        }

        private void zamien1_Click(object sender, EventArgs e)
        {
            tekst = metody.lancuchNaSlowaBinarne(slowa.Text);
            slowanabinarny.Text = metody.piszcaloscText(tekst);
        }

        private void wyslij_Click(object sender, EventArgs e)
        {
            odbiorca.tekst = tekst;
            odbiorca.binarne.Text = metody.piszcaloscText(tekst);
        }

        private void slowa_TextChanged(object sender, EventArgs e)
        {
            if (slowa.Text.Equals("")) zamien1.Enabled = false; else zamien1.Enabled = true;
        }

        private void slowanabinarny_TextChanged(object sender, EventArgs e)
        {
            if (slowanabinarny.Text.Equals("")) wyslij.Enabled = false; else wyslij.Enabled = true;
        }
    }
}
