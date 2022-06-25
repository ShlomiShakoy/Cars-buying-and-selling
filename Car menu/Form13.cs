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
    public partial class Form13 : Form
    {
        string amount, type, model, color, self, price, id;
        public List<ElectricCar> m_list;
        string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\electriccar.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == null || model == null || color == null || self == null || price == null || id == null)
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            foreach (ElectricCar t in m_list)
            {
                if (t.LicensePlate.Contains(id))
                {
                    MessageBox.Show("License plate is already exist, please try again ");
                    return;
                }
            }
            m_list.Add(new ElectricCar(amount, type, model, color, self, price, id));
            List<string> output = new List<string>();
            foreach (var car1 in m_list)
            {
                output.Add($"{car1.amountOfSeats},{car1._type},{car1._model},{car1._color},{car1.selfCharging},{car1._price},{car1.LicensePlate}");
            }
            File.WriteAllLines(text, output);
            var source = new BindingSource();
            source.DataSource = m_list;
            dataGridView1.DataSource = source;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox4);
            self = comboBox1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            id = textBox8.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox4);
            amount = comboBox3.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            type = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            model = textBox5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object id, amount, type, model, color, price , self;
            string id1, amount1, type1, model1, color1, price1 , self1;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            amount = dataGridView1.Rows[rowindex].Cells[1].Value;
            type = dataGridView1.Rows[rowindex].Cells[2].Value;
            model = dataGridView1.Rows[rowindex].Cells[3].Value;
            color = dataGridView1.Rows[rowindex].Cells[4].Value;
            self= dataGridView1.Rows[rowindex].Cells[0].Value;
            price = dataGridView1.Rows[rowindex].Cells[5].Value;
            id = dataGridView1.Rows[rowindex].Cells[6].Value;

            id1 = id.ToString();
            amount1 = amount.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            self1 = self.ToString();
            color1 = color.ToString();
            price1 = price.ToString();
            List<string> output = File.ReadAllLines(text).ToList();

            foreach (var person in m_list)
            {
                String str1 = $"{amount1},{type1},{model1},{color1},{self1},{price1},{id1}";
                output.Remove(str1);

            }
            File.WriteAllLines(text, output);
            foreach (ElectricCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    m_list.Remove(t);
                    break;
                }
            }
            var source = new BindingSource();
            source.DataSource = m_list;
            dataGridView1.DataSource = source;
            dataGridView1.Update();
            dataGridView1.Refresh();
            MessageBox.Show("thanks for buying");
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int flag = 0;
            object id, amount, type, model, color, price, self;
            string id1, amount1, type1, model1, color1, price1, self1;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            amount = dataGridView1.Rows[rowindex].Cells[1].Value;
            type = dataGridView1.Rows[rowindex].Cells[2].Value;
            model = dataGridView1.Rows[rowindex].Cells[3].Value;
            color = dataGridView1.Rows[rowindex].Cells[4].Value;
            self = dataGridView1.Rows[rowindex].Cells[0].Value;
            price = dataGridView1.Rows[rowindex].Cells[5].Value;
            id = dataGridView1.Rows[rowindex].Cells[6].Value;

            id1 = id.ToString();
            amount1 = amount.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            self1 = self.ToString();
            color1 = color.ToString();
            price1 = price.ToString();
            foreach (ElectricCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    m_list.Remove(t);
                    break;
                }
            }
            foreach (ElectricCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    MessageBox.Show("License plate number is already exist, please change the number!");
                    flag = 1;
                    break;
                }
            }
            m_list.Add(new ElectricCar(amount1, type1, model1, color1, self1, price1, id1));
            List<string> output = new List<string>();
            foreach (var car1 in m_list)
            {
                output.Add($"{car1.amountOfSeats},{car1._type},{car1._model},{car1._color},{car1.selfCharging},{car1._price},{car1.LicensePlate}");
            }
            File.WriteAllLines(text, output);
           if(flag==0)
                MessageBox.Show("Deatails have been saved");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            color = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            price = textBox7.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        public Form13()
        {
            InitializeComponent();
            m_list = new List<ElectricCar>();
            getcar();
        }
        public void getcar()
        {
            List<string> lines = File.ReadAllLines(text).ToList();
            foreach (var line in lines)
            {
                string[] x = line.Split(',');
                ElectricCar mycar = new ElectricCar();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar.selfCharging = x[4];
                mycar._price = x[5];
                mycar.LicensePlate = x[6];

                m_list.Add(mycar);
            }
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m_list;
        }
    }
}
