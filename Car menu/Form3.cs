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
    public partial class Form3 : Form
    {
        string amount, type, model, color, leather, turbo, price , id;
       
        public List<LuxuryCar> m_list;
        string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\Luxurycar.txt";


        public Form3()
        {
            InitializeComponent();
            m_list = new List<LuxuryCar>();

            getpremiumcar();
        }
        public void getpremiumcar()
        {
            List<string> lines = File.ReadAllLines(text).ToList();
            foreach (var line in lines)
            {
                string[] x = line.Split(',');
                LuxuryCar mycar = new LuxuryCar();
                mycar.amountOfSeats = x[0];
                mycar._type = x[1];
                mycar._model = x[2];
                mycar._color = x[3];
                mycar.leathersSeats = x[4];
                mycar.turboEngine = x[5];
                mycar._price = x[6];
                mycar.LicensePlate = x[7];

                m_list.Add(mycar);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            id = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            price = textBox5.Text;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = m_list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == null || model == null || color == null || turbo == null || amount == null || price == null || id == null || leather==null)
            {
                MessageBox.Show("Please fill all the details");
                return;
            }
            foreach (LuxuryCar t in m_list)
            {
                if (t.LicensePlate.Contains(id))
                {
                    MessageBox.Show("License plate is already exist, please try again ");
                    return;
                }
            }
            m_list.Add(new LuxuryCar(amount, type, model, color, leather, turbo, price, id));
            List<string> output = new List<string>();
            foreach (var car1 in m_list)
            {
                output.Add($"{car1.amountOfSeats},{car1._type},{car1._model},{car1._color},{car1.leathersSeats},{car1.turboEngine},{car1._price},{car1.LicensePlate}");
            }
            File.WriteAllLines(text, output);
            var source = new BindingSource();
            source.DataSource = m_list;
            dataGridView2.DataSource = source;
            dataGridView2.Update();
            dataGridView2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object id, amount, type, model, color, price , leader , turbo;
            string id1, amount1, type1, model1, color1, price1, leader1, turbo1;
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            amount = dataGridView2.Rows[rowindex].Cells[2].Value;
            type = dataGridView2.Rows[rowindex].Cells[3].Value;
            model = dataGridView2.Rows[rowindex].Cells[4].Value;
            color = dataGridView2.Rows[rowindex].Cells[5].Value;
            leader = dataGridView2.Rows[rowindex].Cells[0].Value;
            turbo = dataGridView2.Rows[rowindex].Cells[1].Value;
            price = dataGridView2.Rows[rowindex].Cells[6].Value;
            id = dataGridView2.Rows[rowindex].Cells[7].Value;

            id1 = id.ToString();
            amount1 = amount.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            color1 = color.ToString();
            leader1 = leader.ToString();
            turbo1 = turbo.ToString();
            price1 = price.ToString();
            List<string> output = File.ReadAllLines(text).ToList();

            foreach (var person in m_list)
            {
                String str1 = $"{amount1},{type1},{model1},{color1},{leader1},{turbo1},{price1},{id1}";
                output.Remove(str1);

            }
            File.WriteAllLines(text, output);
            foreach (LuxuryCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    m_list.Remove(t);
                    break;
                }
            }


            var source = new BindingSource();
            source.DataSource = m_list;
            dataGridView2.DataSource = source;
            dataGridView2.Update();
            dataGridView2.Refresh();
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
            object id, amount, type, model, color, price, leader, turbo;
            string id1, amount1, type1, model1, color1, price1, leader1, turbo1;
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            amount = dataGridView2.Rows[rowindex].Cells[2].Value;
            type = dataGridView2.Rows[rowindex].Cells[3].Value;
            model = dataGridView2.Rows[rowindex].Cells[4].Value;
            color = dataGridView2.Rows[rowindex].Cells[5].Value;
            leader = dataGridView2.Rows[rowindex].Cells[0].Value;
            turbo = dataGridView2.Rows[rowindex].Cells[1].Value;
            price = dataGridView2.Rows[rowindex].Cells[6].Value;
            id = dataGridView2.Rows[rowindex].Cells[7].Value;

            id1 = id.ToString();
            amount1 = amount.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            color1 = color.ToString();
            leader1 = leader.ToString();
            turbo1 = turbo.ToString();
            price1 = price.ToString();
            foreach (LuxuryCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    m_list.Remove(t);
                    break;
                }
            }
            foreach (LuxuryCar t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    MessageBox.Show("License plate number is already exist, please change the number!");
                    flag = 1;
                    break;
                }
            }
            m_list.Add(new LuxuryCar(amount1, type1, model1, color1, leader1, turbo1, price1, id1));
            List<string> output = new List<string>();
            foreach (var car1 in m_list)
            {
                output.Add($"{car1.amountOfSeats},{car1._type},{car1._model},{car1._color},{car1.leathersSeats},{car1.turboEngine},{car1._price},{car1.LicensePlate}");
            }
            File.WriteAllLines(text, output);
            if(flag==0)
                MessageBox.Show("Deatails have been saved");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1);
            turbo = comboBox1.Text;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            model = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            color = textBox4.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1);
            leather = comboBox2.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            type = textBox2.Text;
        }

        
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox1);
            amount = comboBox3.Text;
            
        }
    }
}
