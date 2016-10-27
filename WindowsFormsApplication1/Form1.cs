using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void LoadData_Click(object sender, EventArgs e)
        {
            data = dataHandler.readAllData("poi");
            dataHandler.loadAllDataToTextBox(data, t_dataText);
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
            dataHandler.loadAllDataToTextBox(data, t_dataText);
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
    }
}
