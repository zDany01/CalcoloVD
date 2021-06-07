using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace CalcoloVelocitaDownload
{
    public partial class GUIForm : Form
    {
        public GUIForm()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBoxNotNumber;
            textBox2.TextChanged += TextBoxNotNumber;
            comboBox1.SelectedIndex = 1; comboBox2.SelectedIndex = 3; //default
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") { return; } // | e || sono rispettivamente or e orElse, nel caso in cui il primo sia vero allora con ||(orElse) il secondo non verrà neanche valutato. analogamente questo vale anche per & e && (and e ?andElse?)
            BigInteger QuantitaDatiDaScaricare = Convert.ToUInt64(textBox1.Text);
            BigInteger VelocitaDwl = Convert.ToUInt64(textBox2.Text);

            if (!(QuantitaDatiDaScaricare > 0) || !(VelocitaDwl > 0)) { return; }
            //0 TeraByte, 1 Gigabyte, 2 Megabyte
            if (comboBox1.SelectedIndex == 0)
            {
                if (QuantitaDatiDaScaricare > 16777214)
                {
                    MessageBox.Show("Inserire un numero minore di dati.");
                    textBox1.Clear(); textBox2.Clear();
                    return;
                }
                QuantitaDatiDaScaricare *= Convert.ToUInt64(Math.Pow(2, 40));
            }
            else if (comboBox1.SelectedIndex == 1) { QuantitaDatiDaScaricare *= Convert.ToUInt64(Math.Pow(2, 30)); } else { QuantitaDatiDaScaricare *= Convert.ToUInt64(Math.Pow(2, 20)); } //conversione in byte

            //0 Gigabyte, 1 GigaBit, 2 Megabyte, 3 Megabit, 4 KiloByte, 5 Kilobit
            if (comboBox2.SelectedIndex == 0) { VelocitaDwl *= Convert.ToUInt64(Math.Pow(2, 30)); } else if (comboBox2.SelectedIndex == 1) { VelocitaDwl *= 134217728; } else if (comboBox2.SelectedIndex == 2) { VelocitaDwl *= Convert.ToUInt64(Math.Pow(2, 20)); } else if (comboBox2.SelectedIndex == 3) { VelocitaDwl *= 131072; } else if (comboBox2.SelectedIndex == 4) { VelocitaDwl *= Convert.ToUInt64(Math.Pow(2, 10)); } else { VelocitaDwl *= 128; }

            BigInteger tempo = QuantitaDatiDaScaricare / VelocitaDwl;
            textBox3.Text = ElaboraTempo(tempo);
        }

        private void TextBoxNotNumber(object sender, EventArgs e)
        {
            TextBox txbx = (TextBox)sender;
            foreach (Char _KeyChar in txbx.Text)
            {
                if (_KeyChar.ToString() == "1" || _KeyChar.ToString() == "2" || _KeyChar.ToString() == "3" || _KeyChar.ToString() == "4" || _KeyChar.ToString() == "5" || _KeyChar.ToString() == "6" || _KeyChar.ToString() == "7" || _KeyChar.ToString() == "8" || _KeyChar.ToString() == "9" || _KeyChar.ToString() == "0")
                { } else { txbx.Text = txbx.Text.Replace(_KeyChar.ToString(), null); }
            }
        }
        
        private static string ElaboraTempo(BigInteger secondi)
        {
            BigInteger giorni = secondi / 86400; secondi %= 86400; //86400 = (24*3600), pre-calcolato per diminuire i calcoli

            int ore = (int)(secondi / 3600); secondi %= 3600;

            int minuti = (int)(secondi / 60); secondi %= 60;

            return $"{giorni} giorni {ore} ore {minuti} minuti {secondi} secondi.";
        }
    }
}
