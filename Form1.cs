using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class init : Form
    {
        decimal value1 = 0, value2 = 0;
        string operation = "";
        public init()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            value1 = 0;
            value2 = 0;
            lblOperation.Text = "";
        }        
        private void button21_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        } 
        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        } 
        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            value2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);

            if (operation == "PLUS")
            {
                txtResult.Text = Convert.ToString(value1 + value2);
            }
            else if (operation == "MINUS") {
                txtResult.Text = Convert.ToString(value1 - value2);
            }
            else if (operation == "MULT")
            {
                txtResult.Text = Convert.ToString(value1 * value2);
            }
            else if (operation == "PERC")
            {
                txtResult.Text = Convert.ToString(value1 * (value2 / 100));
            }
            else
            {
                txtResult.Text = Convert.ToString(value1 / value2);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setOperation("MINUS", "-");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            setOperation("MULT", "x");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            setOperation("DIV", "÷");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setOperation("PERC", "%");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setOperation("PLUS", "+");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EnzoDaun");
        }

        private void setOperation(string operation, string operationLabel)
        {
            if (txtResult.Text != "")
            {
                value1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                this.operation = operation;
                lblOperation.Text = operationLabel;
            }
            else
            {
                MessageBox.Show("Informe o primeiro valor!");
            }
        }
    }
}
