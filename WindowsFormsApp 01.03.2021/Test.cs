using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp_01._03._2021
{
    public partial class Test : Form
    {
        string name;

        private void select_flag(int n = 0, string color = "White")
        {
            Flag1.BackColor = Color.Transparent;
            Flag2.BackColor = Color.Transparent;
            Flag3.BackColor = Color.Transparent;
            if (n == 1) Flag1.BackColor = Color.FromName(color);
            if (n == 2) Flag2.BackColor = Color.FromName(color);
            if (n == 3) Flag3.BackColor = Color.FromName(color);
        }

        StreamWriter sr = File.AppendText("Result.txt");

        public Test(string user_name)
        {
            InitializeComponent();
            name = user_name;
            name_label.Text = "Пользователь:\n" + name;
            select_flag();
        }
        private void exit()
        {
            sr.Close();
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
            if (comboBox_q3.SelectedIndex == 1)
            {
                rez++;
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Red;
                comboBox_q3.SelectedIndex = 1;
                comboBox_q3.ForeColor = System.Drawing.Color.Green;
            }
         if(flag_seted == 1)
            {
                label4.ForeColor = System.Drawing.Color.Green;
                rez++;
            }
            else
            {
                label4.ForeColor = System.Drawing.Color.Red;
                select_flag(1, "Green");
            }
            MessageBox.Show(rez + " из 4");
            sr.WriteLine(name + " " + rez);
            exit();
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
            exit();
        }

        int flag_seted = 0;
        private void Flag1_Click(object sender, EventArgs e)
        {
            flag_seted = 1;

            select_flag(1);

        }

        private void Flag2_Click(object sender, EventArgs e)
        {
            flag_seted = 2;

            select_flag(2);

        }

        private void Flag3_Click(object sender, EventArgs e)
        {
            flag_seted = 3;

            select_flag(3);

        }
    }
}
