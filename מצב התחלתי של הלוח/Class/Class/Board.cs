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

        //לקבל את המילון
        public Board(int[,] userMat)
        {
            Squares = new Square[9, 9];
            // Initialize the slots
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    Squares[row, column] = new Square();
                    Squares[row, column].idCage = userMat[row,column];
                    

                }
                 
            }
            //
 
            
        }

        //פונקציה שמקבלת ערך ומיקום
        //ומשנה במערך את הערך מ1 ל0 של שורה עמודה וריבוע את הערך שהתקבל
        public void SubUpdate(int value, int i, int j)
        {

            for (int s = 0; s < 9; s++)
            {

                Squares[i, s].arrSquare[value - 1] = 0;
                Squares[s, j].arrSquare[value - 1] = 0;
            }


            for (int s = i / 3 * 3; s < i / 3 * 3 + 3; s++)
            {
                for (int g = j / 3 * 3; g < j / 3 * 3 + 3; g++)
                {
                    Squares[s, g].arrSquare[value - 1] = 0;
                }
            }
        }
    }




}
