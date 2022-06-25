using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_menu
{
    public partial class Form4 : Form
    {
        int counter=0;
        string count;
        public List<Car> m_list;
        string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\allcars.txt";
        public Form4()
        {
            InitializeComponent();
            m_list = new List<Car>();
            getcar();

        }
        public void getcar()
        {
            List<string> lines = File.ReadAllLines(text).ToList();
            foreach (var line in lines)
            {
                string[] x = line.Split(',');
                Car mycar = new Car();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar._price = x[4];
                mycar.LicensePlate = x[5];
                m_list.Add(mycar);
                counter++;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m_list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            count = counter.ToString();
            MessageBox.Show("the amount of the cars are: " + count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
