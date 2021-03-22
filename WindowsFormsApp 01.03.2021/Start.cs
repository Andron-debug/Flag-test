using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp_01._03._2021
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        SoundPlayer gimn = new SoundPlayer("Gimn.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
                gimn.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "")
            {
                Form next = new Test(name_textBox.Text);
                next.Show();
                Hide();
                gimn.Stop();
            }
            else
            {
                MessageBox.Show("Введите имя");
            }
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
