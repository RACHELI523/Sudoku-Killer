using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Board
    {
        public Square[,] Squares { get; set; }

        public Board()
        {
            Squares = new Square[9, 9];
            // Initialize the slots
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                 
                    

                }
            }
        }

    }

}
