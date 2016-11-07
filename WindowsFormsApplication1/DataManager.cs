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

        public string head = "";
        public List<String> selectedData = new List<String>();

        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch(Exception)
            {
                return File.ReadAllLines(fileName + ".csv");
            }
        }


        public string [] readSomeData(string fileName,decimal start,decimal num)
        {
            StreamReader r = new StreamReader(fileName);
            string[] data = new string[(int)num];
            int i = 0;
            string temp = "";

            for (i = 0; i < start - 1; i++)
            {
                //if (r.ReadLine() != null)
               // {
                    head = r.ReadLine();
               // }
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

        public void writeAllDataToFile(string fileName,Boolean w,ListBox LiBox2)
        {
            StreamWriter writer = new StreamWriter(fileName);

            int x = 0;

            //OR selectedData.AddRange(LiBox2.Items.Cast<string>());

            foreach (string l in LiBox2.Items)
            {
                selectedData.Add(l);
                ++x;
            }

            if (w)
            {
                writer.WriteLine(head);
            }

            foreach (string d in selectedData)
            {
                writer.WriteLine(d);
            }
            writer.Close();
        }

        public void selectList(ListBox liBox,ListBox liBox2,Boolean voter)
        {
            //string curItem = liBox.SelectedItem.ToString();
            if (liBox.SelectedItem != null)
            {
                if (voter == true)
                {
                    liBox2.Items.Add(liBox.SelectedItem);
                }
                liBox.Items.Remove(liBox.SelectedItem);
            }
        }
    }
}
