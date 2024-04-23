﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace datoteke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textToSave = textBox1.Text;
            File.WriteAllText("savedText.txt", textToSave);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
        }
    }
}
