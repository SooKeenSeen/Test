using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text;
namespace Test3Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CarListSort(List<Car> carList)
        {
            carList.Sort(delegate (Car x, Car y)
            {
                return x.Price.CompareTo(y.Price);
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            string path = @"C:\Users\User\Desktop\Cars.txt";
            StreamReader txtReader = new StreamReader(path);
            string BufferStr = "";
            while (!txtReader.EndOfStream)
            {
                BufferStr = txtReader.ReadLine();
                dataGridView1.Rows.Add(BufferStr.Split(" ")[0], BufferStr.Split()[1], int.Parse(BufferStr.Split()[2]) );
            }
            txtReader.Close();
            dataGridView1.Sort(dataGridView1.Columns[2], 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text));
            dataGridView1.Sort(dataGridView1.Columns[2],0);
        }
    }
}