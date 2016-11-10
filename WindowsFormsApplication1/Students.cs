using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Students
    {
        public List<List<string>> teamMate = new List<List<string>>();
        DataManager dataProvider = new DataManager();
        ID id = new ID();
        
        public int score;

        public void getStudents()
        {
            teamMate.Add(dataProvider.selectedData);
            //Console.WriteLine(IEnumerableLogAll(teamMate[0].ToList<Object>()).ToString());
        }

        public string IEnumerableLogAll (IEnumerable<object> IEN)
        {
            string FinalResult = "";
            foreach(Object Single in IEN)
            {
                FinalResult += Single.ToString() + "wori\r\n";
            }
            return FinalResult;
        }

        public int calScore()
        {
            //MACbeth! Macbeth! beware MAcduff and Macdonal
            foreach (List<string> s in teamMate)
            {
                 
            }

            return 5;
        }
    }
}
