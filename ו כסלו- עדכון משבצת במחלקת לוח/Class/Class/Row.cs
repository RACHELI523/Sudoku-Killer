using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Row
    {
        //רשימה מסוג משבצת
        public List<Square> Squares { get; set; }

        public Row()
        {
            Squares = new List<Square>();
        }

    }
}
