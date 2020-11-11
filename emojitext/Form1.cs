using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emojitext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string complete = "";

            foreach (char c in textBox1.Text.ToLower())
            {
                if (Char.IsLetter(c) || c == ' ')
                {
                    if (c == ' ')
                    {
                        complete += "  ";
                    }
                    else
                    {
                        complete += ":regional_indicator_" + c + ": ";
                    }
                }
            }
            textBox2.Text = complete + " .";
        }
    }
}
