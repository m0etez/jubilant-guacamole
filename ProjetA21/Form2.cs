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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string nomPoste
        {
            get { return textBoxForm2.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxForm2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
            //Bannit les Apostrophes
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}
