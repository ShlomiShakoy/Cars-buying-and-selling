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
    public partial class Form11 : Form
    {
        string type , id;
        string color;
        string model;
        string lever;
        string manually;
        string price;
        bool lever1;
        bool manually1;
        int price1;
        //public List<Truck> truck { get; set; }
        
        
        public List<Truck> m_list;
        string text = @"C:\Users\IMOE001\Dropbox\PC\Desktop\carsProject\temp\mytruck.txt";
        public Form11()
        {
            InitializeComponent();
            m_list = new List<Truck>();

            gettrucks();
         }

        public void gettrucks()
        { 
            List<string> lines = File.ReadAllLines(text).ToList();
             foreach (var line in lines)
            {
                string[] x = line.Split(',');
                Truck mytruck = new Truck();
                mytruck._type = x[0];
                mytruck._model = x[1];
                mytruck._color = x[2];
                mytruck._lever = x[3];
                mytruck._manually = x[4];
                mytruck._price = x[5];
                mytruck.LicensePlate = x[6];
                m_list.Add(mytruck);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView2.Columns["LicensePlate"].ReadOnly = true;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //var truck = this.truck;
            dataGridView2.DataSource = m_list;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            type = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            model = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            color = textBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1);
            manually = comboBox2.Text;
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            price = textBox2.Text;
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1);
            lever = comboBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(type==null || model==null || color==null || lever==null || manually==null || price==null || id==null)
            {
                MessageBox.Show("Please fill all the details");
                return;
            }

            foreach (Truck t in m_list)
            {
                if (t.LicensePlate.Contains(id))
                {
                    MessageBox.Show("License plate is already exist, please try again ");
                    return;
                }
            }
            m_list.Add(new Truck(type, model, color, lever, manually, price, id));
            List<string> output = new List<string>();
            foreach (var person in m_list)
            {
                output.Add($"{person._type},{person._model},{person._color},{person._lever},{person._manually},{person._price},{person.LicensePlate}");
                
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
            object id , manually , lever , type , model , color , price;
            string id1 , manually1, lever1, type1, model1, color1, price1;
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            lever = dataGridView2.Rows[rowindex].Cells[0].Value;
            manually = dataGridView2.Rows[rowindex].Cells[1].Value;
            id = dataGridView2.Rows[rowindex].Cells[6].Value;
            type = dataGridView2.Rows[rowindex].Cells[2].Value;
            model = dataGridView2.Rows[rowindex].Cells[3].Value;
            color = dataGridView2.Rows[rowindex].Cells[4].Value;
            price = dataGridView2.Rows[rowindex].Cells[5].Value;
            id1 = id.ToString();
            manually1 = manually.ToString();
            lever1 = lever.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            color1 = color.ToString();
            price1 = price.ToString();
            List<string> output = File.ReadAllLines(text).ToList();

            foreach (var person in m_list)
            {
                String str1 = $"{type1},{model1},{color1},{lever1},{manually1},{price1},{id1}";
                output.Remove(str1);

            }
            File.WriteAllLines(text, output);
             
            foreach (Truck t in m_list)
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
            int flag=0;
            object id, manually, lever, type, model, color, price;
            string id1, manually1, lever1, type1, model1, color1, price1;
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            lever = dataGridView2.Rows[rowindex].Cells[0].Value;
            manually = dataGridView2.Rows[rowindex].Cells[1].Value;
            id = dataGridView2.Rows[rowindex].Cells[6].Value;
            type = dataGridView2.Rows[rowindex].Cells[2].Value;
            model = dataGridView2.Rows[rowindex].Cells[3].Value;
            color = dataGridView2.Rows[rowindex].Cells[4].Value;
            price = dataGridView2.Rows[rowindex].Cells[5].Value;
            id1 = id.ToString();
            manually1 = manually.ToString();
            lever1 = lever.ToString();
            type1 = type.ToString();
            model1 = model.ToString();
            color1 = color.ToString();
            price1 = price.ToString();
            foreach (Truck t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    m_list.Remove(t);
                    break;
                }
            }
            foreach (Truck t in m_list)
            {
                if (t.LicensePlate.Contains(id1))
                {
                    MessageBox.Show("License plate number is already exist, please change the number!");
                    flag = 1;
                    break;
                }
            }
            m_list.Add(new Truck(type1, model1, color1, lever1, manually1, price1, id1));
            List<string> output = new List<string>();
            foreach (var person in m_list)
            {
                output.Add($"{person._type},{person._model},{person._color},{person._lever},{person._manually},{person._price},{person.LicensePlate}");

            }
            File.WriteAllLines(text, output);
            if(flag==0)
                MessageBox.Show("Deatalis have been saved successfully");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            id = textBox5.Text;
           
        }
    }
}
