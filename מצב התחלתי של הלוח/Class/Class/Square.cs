using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Square
    {
        // ערך סופי
        public int Value { get; set; }

        //פתור או לא פתור
        public bool IsSolved { get; set; }

        // מאתחל את כל המערך לערכים של 1
         public int[] arrSquare = Enumerable.Repeat(1, 9).ToArray();


        public int idCage { get; set; }

        //בנאי מחלקת משבצת
        public Square()
        {
            Value = 0;
            IsSolved = false;
            
        }

    }
}
