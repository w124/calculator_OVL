﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_OVL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double F;
            F = Calculator.add((Convert.ToDouble(textBox1.Text)),(Convert.ToDouble(textBox2.Text)));
            
            textBox3.Text = F.ToString();
                }

        public static class Calculator
        {
            public static int add(int a, int b)
            {
                return a + b;
            }
            public static Double add(Double a, Double b)
            {
                return a + b;
            }
            public static int sub(int a, int b)
            {
                return a - b;
            }
            public static Double sub(Double a, Double b)
            {
                return a - b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double F;
            F = Calculator.sub((Convert.ToDouble(textBox1.Text)), (Convert.ToDouble(textBox2.Text)));

            textBox3.Text = F.ToString();
        }
    }
    }

