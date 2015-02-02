using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshp07bp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonKopieren_Click(object sender, EventArgs e)
        {
            string tempKette;
            tempKette = labelZiel.Text;
            labelZiel.Text = labelQuelle.Text;
            labelQuelle.Text = tempKette;
        }

 
        private void zielList_SelectedValueChanged(object sender, EventArgs e)
        {
            labelZiel.Text = zielList.SelectedItem.ToString();
        }

        private void einblendenBox_CheckedChanged(object sender, EventArgs e)
        {
            if (einblendenBox.Checked == true)
            {
                zielList.Visible = true;
                quelleCombo.Visible = true;
            }
            else
            {
                zielList.Visible = false;
                quelleCombo.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zielList.SelectedIndex = 0;
            quelleCombo.SelectedIndex = 0;
        }

        private void quelleCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            labelQuelle.Text = quelleCombo.SelectedItem.ToString();
        }

    }
}
