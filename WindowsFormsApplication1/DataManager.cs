using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DataManager
    {

        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch(Exception e)
            {
                return File.ReadAllLines(fileName + ".csv");
            }
        }


        public string [] readSomeData(string fileName,decimal start,decimal num)
        {
            StreamReader r = new StreamReader(fileName + ".csv");
            string[] data = new string[(int)num];
            int i = 0;
            string temp = "";

            for (i = 0; i < start - 1; i++)
            {
                if (r.ReadLine() != null)
                {
                    temp = r.ReadLine();
                }
            }

            for (int j = 0; j<num/*Math.Min(num+start,data.Length-1)*/;j++)
            {
                temp = r.ReadLine();
                if (temp==null)
                {
                    r.Close();
                    return data;
                }
                data[j] = temp;
                //++i;
            }
            return data;
        }

        public void loadAllDataToTextBox(string[] data,ListBox box)
        {
            box.Items.Clear();
            foreach(string d in data)
            {
                if (d != null)
                {
                    box.Items.Add(d);
                    //box.Items.Add("\r\n");
                }
            }
        }

        public void searchSomeData(string se)
        {
            //se.con
        }

        public void writeAllDataToFile(string fileName,string[] data)
        {
            StreamWriter writer = new StreamWriter(fileName);
            foreach (string d in data)
            {
                writer.WriteLine(d);

            }
            writer.Close();
        }

        public void selectList(ListBox liBox,ListBox liBox2)
        {
            //string curItem = liBox.SelectedItem.ToString();
            if (liBox.SelectedItem != null)
            {
                liBox2.Items.Add(liBox.SelectedItem);
                liBox.Items.Remove(liBox.SelectedItem);
            }
        }
    }
}
