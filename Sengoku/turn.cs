using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    public class turn
    {
        int whoseTurn = 1;

        public turn()
        {
            if (whoseTurn == 1)
            {
                whoseTurn++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 14);
                Console.Write("-->");
                Console.SetCursorPosition(0, 15);
                Console.Write("   ");
                cursorMovement go = new cursorMovement(argh.gameBoard, now.turn);
            }
            if (whoseTurn == 2)
            {
                whoseTurn = whoseTurn - 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 15);
                Console.Write("-->");
                Console.SetCursorPosition(0, 14);
                Console.Write("   ");
                cursorMovement go = new cursorMovement(argh.gameBoard, now.turn);
            }
            //Console.SetCursorPosition(0, 14);
            //Console.Write("-->");
        }

    }
}
