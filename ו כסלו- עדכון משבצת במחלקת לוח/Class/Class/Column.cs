using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Column
    {
        //רשימה מסוג משבצת
        public List<Square> Squares { get; set; }

        public Column()
        {
            Squares = new List<Square>();
        }
    }
}              
