using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// premium car
        {
            new Form3().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)// other
        {
            new Form12().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)// electric car
        {
            new Form13().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Car mycar= new Car();
            // mycar.mylist();
            //string text = @"C:\temp\allcars.txt";
            ElectricCar mycar = new ElectricCar();
            //LuxuryCar mycar1 = new LuxuryCar();
            mycar.mylist();
            //mycar1.mylist();
            // File.WriteAllText(text, String.Empty);
            this.Hide();
            new Form4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
