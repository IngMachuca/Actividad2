using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
