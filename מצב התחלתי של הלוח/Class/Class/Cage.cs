using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Cage
    {

        //סכום הכלוב
        public int Sum { get; set; }

        //רשימה מסוג משבצת
        public List<Square> Square { get; set; }
        public static int idCage = 0;
        public Cage(int sum)
        {
            Sum = sum;
            Square = new List<Square>();
            idCage++;

        }

    }
}
