using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetA21
{
    public partial class FormRecapFixModif : Form
    {
        public FormRecapFixModif()
        {
            InitializeComponent();
        }

        private void FormRecapFixModif_Load(object sender, EventArgs e)
        {
            FormBudgestion.ComboBoxFill(comboBox1, "Periodicite", "libPer", "codePer");
        }

        public double montant
        {
            get { return double.Parse(textBox1.Text.ToString()); }
        }

        public int typePeriod
        {
            get { return int.Parse(comboBox1.SelectedValue.ToString()); }
        }

        public int jourMois
        {
            get { return int.Parse(textBox2.Text); }
        }

        public string description
        {
            get { return textBox3.Text.ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (int.Parse(textBox2.Text) > 31 || int.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("Entrer un jour compris entre 1 et 31!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Entrer un montant!");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorise les nombres
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //Autorise backspace
            else if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            //Autorise enter
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
            }
            //Autorise une virgule
            else if (e.KeyChar == ',' && textBox1.Text == "")
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && !textBox1.Text.Contains(','))
            {
                e.Handled = false;
            }
            //Bannit le reste
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}
