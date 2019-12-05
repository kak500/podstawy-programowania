using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            output1.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string l1 = liczba1.Text;
            string l2 = liczba2.Text;
            double l1d = double.Parse(l1);
            double l2d = double.Parse(l2);
            double result = l1d + l2d;
            
            output1.Enabled = true;
            output1.Text = result.ToString();
        }
    }
}
