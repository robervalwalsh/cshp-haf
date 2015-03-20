using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenRechnerAufgabe3v1
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void Taschenrechner_Load(object sender, EventArgs e)
        {
            comboBoxRechnenoperation.SelectedIndex = 0;
        }

        private void buttonBerechen_Click(object sender, EventArgs e)
        {
            float zahl1 = 0, zahl2 = 0, ergebnis = 0;
            bool divDurchNull = false;
            //die beiden Zahlen einlesen und konvertieren
            try
            {
                zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            }
            catch (FormatException)
            {
                //bitte in einer Zeile eingeben
                MessageBox.Show("Ihre Eingabe " + textBoxZahl1.Text + " war nicht gültig. ", "Fehler");
            }
            try
            {
                zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            }
            catch (FormatException)
            {
                //bitte in einer Zeile eingeben
                MessageBox.Show("Ihre Eingabe " + textBoxZahl2.Text + " war nicht gültig. ", "Fehler");
            }

            //die Rechenoperation ermitteln und ausführen
            if (comboBoxRechnenoperation.SelectedIndex == 0)
                ergebnis = zahl1 + zahl2;
            if (comboBoxRechnenoperation.SelectedIndex == 1)
                ergebnis = zahl1 - zahl2;
            if (comboBoxRechnenoperation.SelectedIndex == 2)
            {
                //wird eine Division durch Null versucht?
                if (zahl2 == 0)
                    divDurchNull = true;
                else
                    ergebnis = zahl1 / zahl2;
            }
            if (comboBoxRechnenoperation.SelectedIndex == 3)
                ergebnis = zahl1 * zahl2;
            //wurde durch Null dividiert?
            if (divDurchNull == true)
                labelAnzeige.Text = "Nicht definiert!";
            else
                labelAnzeige.Text = Convert.ToString(ergebnis);

        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxRechnenoperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
