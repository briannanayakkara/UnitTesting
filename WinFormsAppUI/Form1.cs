using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator_Library;

namespace WinFormsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResultText.Enabled = false;
        }

        public string Result(double x,double y,string s)
        {
            string r;
            switch (s)
            {
                case "Add":
                    r = Cal.Add(x, y).ToString();
                    break;
                case "Subtract":
                    r = Cal.subtract(x, y).ToString();
                    break;
                case "Multiply":
                    r = Cal.Multiply(x, y).ToString();
                    break;
                case "Divide":
                    r = Cal.Divide(x, y).ToString();
                    break;
                default:
                    r = s;
                    break;
            }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            return r;
        }

        private void button_clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            ResultText.Text = Result((double)numericUpDown1.Value, (double)numericUpDown2.Value, s);
        }

    }
}
