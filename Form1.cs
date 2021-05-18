﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double val = 0;
        String text = "";
        bool oper_press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((output.Text == "0")||(oper_press))
            {
                output.Clear();
            }
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
        }

 

        private void op_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);
            oper_press = true;
        }
    }
}
