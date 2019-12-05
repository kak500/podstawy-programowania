using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void six_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void one_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void two_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            input.Text += "*";
        }
        
        private void SubstractButton_Click(object sender, EventArgs e)
        {
            input.Text += "-";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            input.Text += "+";
        } 

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //input.Text += "2";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            input.Text += "/";
        } 
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //input.Text += "2";
        }
        
        private void EqualButton_Click(object sender, EventArgs e)
        {
            
        }

        private void three_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }
    }
}
