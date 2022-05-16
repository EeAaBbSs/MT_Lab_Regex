using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MT_Lab_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Enter your birthday date";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "dd.mm.yyyy";
            button1.Text = "Check date for validity";
            textBox1.MouseClick += (s, a) => { textBox1.Clear(); textBox1.ForeColor = Color.Black; };
        }
        private string datePattern = "^(0?[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d$";
        private void button1_Click(object sender, EventArgs e)
        {
            string dateExample = textBox1.Text;
            bool match = Regex.IsMatch(dateExample, datePattern);
            if (!match)
                MessageBox.Show("Invalid format of date, try again");
            else
                MessageBox.Show("Congratulations!");
        }
    }
}
