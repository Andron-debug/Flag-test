﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp_01._03._2021
{
    public partial class Test : Form
    {
        string name;
        public Test(string user_name)
        {
            InitializeComponent();
            name = user_name;
            name_label.Text = "Пользователь:\n" + name;
        }
        private void exet()
        {
            Form last = new Start();
            last.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rez = 0;
            if (textBox1.Text == "1991")
            {
                rez++;
                label1.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                textBox1.Text = "1991";
                textBox1.ForeColor = System.Drawing.Color.Green;
            }
            if (true2.Checked)
            {
                rez++;
                label2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                true2.ForeColor = System.Drawing.Color.Green;
            }
            if ((comboBoxUP.SelectedItem == "Белый") & (comboBoxMID.SelectedItem == "Синий") & (comboBoxEND.SelectedItem == "Красный"))
            {
                rez++;
                label3.ForeColor = System.Drawing.Color.Green;
                comboBoxUP.ForeColor = System.Drawing.Color.Gray;
                comboBoxMID.ForeColor = System.Drawing.Color.Blue;
                comboBoxEND.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Red;
                comboBoxUP.SelectedItem = "Белый";
                comboBoxMID.SelectedItem = "Синий";
                comboBoxEND.SelectedItem = "Красный";

                comboBoxUP.ForeColor = System.Drawing.Color.Gray;
                comboBoxMID.ForeColor = System.Drawing.Color.Blue;
                comboBoxEND.ForeColor = System.Drawing.Color.Red;
            }
            MessageBox.Show(rez + " из 3");
            exet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exet();
        }
    }
}
