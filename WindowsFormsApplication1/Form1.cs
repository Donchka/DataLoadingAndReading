using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] data;
        DataManager dataHandler = new DataManager();
        public int startValue;
        public string file;
        public Boolean header = false;

        private void LoadData_Click(object sender, EventArgs e)
        {
            file = textBox1.Text;
           
            Console.WriteLine(header);
            if (header == true)
            {
                data = dataHandler.readAllData(file);
                
            }else
            {
                int count = File.ReadLines(file + ".csv").Count();
                data = dataHandler.readSomeData(file, 2, count);
            }
            dataHandler.loadAllDataToTextBox(data, listBox1);
            listBox2.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void partiLoad_Click(object sender, EventArgs e)
        {
            data = dataHandler.readSomeData("poi", numericUpDown1.Value, numericUpDown2.Value);
            dataHandler.loadAllDataToTextBox(data, listBox1);
        }

        public string search;

        private void button1_Click(object sender, EventArgs e)
        {
            search = searchBox.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataHandler.writeAllDataToFile("test", data);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
           // {
                textBox2.AppendText(listBox1.SelectedItem.ToString());
           // } catch(Exception) { }
           // MessageBox.Show("Break!");
            dataHandler.selectList(listBox1, listBox2);  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string loadHeader;
            loadHeader = checkBox1.CheckState.ToString();

            if (loadHeader.Equals("Checked"))
            {
                header = true;
            }
            else if (loadHeader.Equals("Unchecked"))
            {
                header = false;
            }
        }
    }
}
