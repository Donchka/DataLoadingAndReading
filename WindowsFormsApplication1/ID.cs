﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ID
    {
        public List<String> voter = new List<String>();
        DataManager d = new DataManager();

        public void getVoter()
        {
            voter.Add(d.head);
        }
    }
}
