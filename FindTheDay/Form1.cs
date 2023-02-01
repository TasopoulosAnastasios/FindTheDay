using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string the_day(string day, int num)
        {
            int n = 0;
            int final = 0;
            string d = "";
            var days = new Dictionary<int, string>()
            {
                { 0,"Monday"},
                { 1,"Tuesday"},
                { 2,"Wendesday"},
                { 3,"Thursday"},
                { 4,"Friday"},
                { 5,"Saturday"},
                { 6,"Sunday"}
            };
            foreach (KeyValuePair<int, string> item in days)
            {
                if (item.Value == day)
                {
                    n = num + item.Key;
                }
            }
            final = n % 7;
            foreach (KeyValuePair<int, string> item in days)
            {
                if (item.Key == final)
                {
                    d = item.Value;
                }
            }
            // MessageBox.Show("Ypoloipo: "+ final.ToString());
            // MessageBox.Show("Arithmos: "+ n.ToString());
            //MessageBox.Show("H mera tha einai: "+ d);
            return d;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = "";
            day=the_day(textBox1.Text, int.Parse(textBox2.Text));
            MessageBox.Show("The day after "+textBox2.Text+" days will be " + day);
        }
    }
}
