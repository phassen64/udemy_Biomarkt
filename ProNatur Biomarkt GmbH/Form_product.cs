using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Produkt Eingabe vornehmen
namespace ProNatur_Biomarkt_GmbH
{
    public partial class Form_product : Form
    {
        public Form_product()
        {
            InitializeComponent();
        }

        private void button_leeren_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel_info.Text = "leeren";
            textBox_produktName.Text = "";
            comboBox_kategorie.Text = "";
            textBox_preis.Text = "";
        }

        private void button_bearbeiten_Click(object sender, EventArgs e)
        {
            string s = textBox_produktName.Text;
            toolStripStatusLabel_info.Text = "bearbeiten :< " + s + " >";
        }
        private void button_loeschen_Click(object sender, EventArgs e)
        {
            string s = textBox_produktName.Text;
            toolStripStatusLabel_info.Text = "loeschen : < " + s + " >";
        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            string s = textBox_produktName.Text;
            toolStripStatusLabel_info.Text = "speichern : < " + s + " >";
        }
    }
}
