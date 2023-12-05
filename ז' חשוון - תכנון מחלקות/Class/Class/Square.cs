using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Square
    {
        //ערך
        public int Value { get; set; } 
        
        //פתור או לא פתור
        public bool IsSolved { get; set; }

        //רשימת ערכים אפשריים
        public List<int> PossibleValues { get; set; }

        //בנאי מחלקת משבצת
        public Square()
        {
            Value = 0;
            IsSolved = false;
            PossibleValues = new List<int>();
        }
    }
}
