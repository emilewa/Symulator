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
    

    public partial class Form2 : Form
    {

        public bool[][] tekst;
        public String tekstzcenzura;

        public Form2()
        {
            InitializeComponent();
        }

        private void zamien2_Click(object sender, EventArgs e)
        {
            string buff = metody.binarnenastring(tekst);
            this.tekstzcenzura = metody.cenzuruj(buff);
            binarnenaslowa.Text = buff;
        }
    
        private void cenzura_Click(object sender, EventArgs e)
        {
            binarnenaslowa.Text = tekstzcenzura;
        }
    }
}
