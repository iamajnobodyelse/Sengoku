using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    public class turn
    {
        int whoseTurn = 1;
        int pos1 = 14;
        int turnNumber;

        public turn()
        {
            if (whoseTurn == 1)
            {
                turnNumber ++;
                whoseTurn++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, pos1);
                Console.Write("-->");
                Console.SetCursorPosition(0, pos1 + 1);//(0, pos1 +3);
                Console.Write("   ");
                cursorMovement go = new cursorMovement(null, null);
            }
            if (whoseTurn == 2)
            {
                turnNumber++;
                whoseTurn = whoseTurn - 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, pos1 +1);
                Console.Write("-->");
                Console.SetCursorPosition(0, pos1);
                Console.Write("   ");
                cursorMovement go = new cursorMovement(null, null);
            }
            /*if (whoseTurn == 3)
            {
                turnNumber ++;
                whoseTurn++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, pos1 +2);
                Console.Write("-->");
                Console.SetCursorPosition(0, pos1 +1);
                Console.Write("   ");
                cursorMovement go = cursorMovement(gameBoard, turn);
            }
            if (whoseTurn == 4)
            {
                turnNumber ++;
                whoseTurn = whoseTurn - 3;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, pos1 +3);
                Console.Write("-->");
                Console.SetCursorPosition(0, pos1 +2);
                Console.Write("   ");
                cursorMovement go = cursorMovement(gameBoard, turn);
            }*/
        }

    }
}
