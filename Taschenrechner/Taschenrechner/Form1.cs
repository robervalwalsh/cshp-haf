using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1 = 0, zahl2 = 0, ergebnis = 0;
            bool divDurchNull = false;
            bool ausnahme = false;

            // die beiden Zahle einlesen und konvertieren

            //zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            //zahl2 = Convert.ToSingle(textBoxZahl2.Text);

            // Ausnahme
            try
            {
                zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ihre Eingabe " + textBoxZahl1.Text + " war nicht gültig. ", "Fehler");
                ausnahme = true;
            }
            try
            {
                zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ihre Eingabe " + textBoxZahl2.Text + " war nicht gültig. ", "Fehler");
                ausnahme = true;
            }

            // Ausnahme?
            if (!ausnahme)
            {
                // die Rechenoperation ermitteln und ausführen
                if (radioButtonAddition.Checked == true)
                    ergebnis = zahl1 + zahl2;
                if (radioButtonSubtraktion.Checked == true)
                    ergebnis = zahl1 - zahl2;
                if (radioButtonMultiplikation.Checked == true)
                    ergebnis = zahl1 * zahl2;
                if (radioButtonDivision.Checked == true)
                {
                    // wird eine Division durch Null versucht?
                    if (zahl2 == 0)
                        divDurchNull = true;
                    else
                        ergebnis = zahl1 / zahl2;
                }

                // wurde durch Null dividiert?
                if (divDurchNull == true)
                    labelAnzeige.Text = "Nicht definiert!";
                else
                    labelAnzeige.Text = Convert.ToString(ergebnis);
            }


        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
