using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button nappi = sender as Button;

            switch (nappi.Text)
            {
                case "Valinta 1":
                    MessageBox.Show("Valinta 1");
                    break;
                case "Valinta 2":
                    MessageBox.Show("Valinta 2");
                    break;
                case "Valinta 3":
                    MessageBox.Show("Valinta 3");
                    break;
                case "Valinta 4":
                    MessageBox.Show("Valinta 4");
                    break;
                default:
                    MessageBox.Show("Default");
                    break;
            }
        }
    }
}
