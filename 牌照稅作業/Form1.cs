using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 牌照稅作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                InitializeComponent();
            }


            this.carType.Items.Clear();
            this.carType.Enabled = true;
            this.label10.Visible = false;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                if (this.carType.SelectedIndex == 0)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.carcc.Visible = true;
                }

                else if (this.carcc.SelectedIndex == -1)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.carcc.Visible = true;
                    this.carcc.Visible = false;
                }
            }

        }
    }
}

