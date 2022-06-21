using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        bool ruch = false;
        int ruch_ilosc = 0;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ruch) { label2.Text = "O"; }
            else if(!ruch) { label2.Text = "X"; }
            Button przycisk = (Button)sender;
            if (ruch == true)
            {
                przycisk.Text = "X";
            }
            else
            {
                przycisk.Text = "O";
            }
            ruch = !ruch;
            ruch_ilosc++;
            przycisk.Enabled = false;
            sprawdz();
        }

        private void sprawdz()
        {
            bool znalezionoZwyciezce = false;
            if ((a1.Text==b1.Text)&&b1.Text==c1.Text&&a1.Text != "") { znalezionoZwyciezce = true; }
            else if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "") { znalezionoZwyciezce = true; }
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "") { znalezionoZwyciezce = true; }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && a2.Text != "") { znalezionoZwyciezce = true; }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && a3.Text != "") { znalezionoZwyciezce = true; }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && a3.Text != "") { znalezionoZwyciezce = true; }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c3.Text != "") { znalezionoZwyciezce = true; }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b3.Text != "") { znalezionoZwyciezce = true; }

            if(znalezionoZwyciezce == true)
            {
                string zwyciezca;
                if (ruch == true) { zwyciezca = "O"; }
                else { zwyciezca = "X"; }
                MessageBox.Show("Zwycięzcą jest " + zwyciezca + ". Kliknij ok aby wyczyścić planszę.");
            }  
            else if (ruch_ilosc == 9)
            {
                MessageBox.Show("Remis. Kliknij ok aby wyczyścić planszę.");
            }

        }
        private void czysc()
        {
            ruch_ilosc = 0;
            ruch = false;
            a1.Text = ""; a2.Text = ""; a3.Text = ""; 
            b1.Text = ""; b2.Text = ""; b3.Text = ""; 
            c1.Text = ""; c2.Text = ""; c3.Text = "";
            a1.Enabled = true; a2.Enabled = true; a3.Enabled = true; 
            b1.Enabled = true; b2.Enabled = true; b3.Enabled = true;
            c1.Enabled = true; c2.Enabled = true; c3.Enabled = true;
            /*var przyciski = Controls.OfType<Button>();
            foreach (Control przycisk in przyciski)
            {
                przycisk.Enabled = true;
                przycisk.Text = "";
            }
            ruch_ilosc = 0;
            ruch = false;
            wyczysc.Text = "Wyczyść"
            */
        }
        private void wyczysc_Click(object sender, EventArgs e)
        {
            czysc();
        }
    }
}
