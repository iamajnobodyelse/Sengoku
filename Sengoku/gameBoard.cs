using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class gameBoard
    {
        public char[,] board = {{' ',' ',' ',' ',' ',' '},
                                {' ','b','a','a','b',' '},
                                {' ',' ',' ',' ',' ',' '},
                                {' ',' ',' ',' ',' ',' '},
					            {' ','B','A','A','B',' '},
                                {' ',' ',' ',' ',' ',' '}};

        public gameBoard()
        {
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   Player Uppercase: 0");
            Console.SetCursorPosition(3, 9);
            Console.Write("B");
            Console.SetCursorPosition(5, 9);
            Console.Write("A");
            Console.SetCursorPosition(7, 9);
            Console.Write("A");
            Console.SetCursorPosition(9, 9);
            Console.Write("B");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("   Player Lowercase: 0");
            Console.SetCursorPosition(3, 3);
            Console.Write("b");
            Console.SetCursorPosition(5, 3);
            Console.Write("a");
            Console.SetCursorPosition(7, 3);
            Console.Write("a");
            Console.SetCursorPosition(9, 3);
            Console.Write("b");
            Console.ForegroundColor = ConsoleColor.Red;
            cursorMovement movement = new cursorMovement(null, null);


        }
    }

    /*class gameBoard
    {
        public char[,] board = {{' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                                {' ',' ',' ',' ','b','g','g','b',' ',' ',' ',' '},
                                {' ',' ',' ',' ','d','d','d','d',' ',' ',' ',' '},
                                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
					            {' ','S','T',' ',' ',' ',' ',' ',' ','t','s',' '},
					            {' ','U','T',' ',' ',' ',' ',' ',' ','t','u',' '},
 					            {' ','U','T',' ',' ',' ',' ',' ',' ','t','u',' '},
 					            {' ','S','T',' ',' ',' ',' ',' ',' ','t','s',' '},
					            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
					            {' ',' ',' ',' ','D','D','D','D',' ',' ',' ',' '},
					            {' ',' ',' ',' ','B','G','G','B',' ',' ',' ',' '},
                                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}};

        public gameBoard()
        {
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| | | | | | | | | | | | |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   Player Uppercase-low : 0");
            Console.SetCursorPosition(3, 9);
            Console.Write("S");
            Console.SetCursorPosition(5, 9);
            Console.Write("T");
            Console.SetCursorPosition(3, 11);
            Console.Write("U");
            Console.SetCursorPosition(5, 11);
            Console.Write("T");
            Console.SetCursorPosition(3, 13);
            Console.Write("U");
            Console.SetCursorPosition(5, 13);
            Console.Write("T");
            Console.SetCursorPosition(3, 15);
            Console.Write("S");
            Console.SetCursorPosition(5, 15);
            Console.Write("T");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("   Player Lowercase-high: 0");
            Console.SetCursorPosition(9, 3);
            Console.Write("b");
            Console.SetCursorPosition(11, 3);
            Console.Write("g");
            Console.SetCursorPosition(13, 3);
            Console.Write("g");
            Console.SetCursorPosition(15, 3);
            Console.Write("b");
            Console.SetCursorPosition(9, 5);
            Console.Write("d");
            Console.SetCursorPosition(11, 5);
            Console.Write("d");
            Console.SetCursorPosition(13, 5);
            Console.Write("d");
            Console.SetCursorPosition(15, 5);
            Console.Write("d");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("   Player Lowercase-low : 0");
            Console.SetCursorPosition(19, 9);
            Console.Write("t");
            Console.SetCursorPosition(21, 9);
            Console.Write("s");
            Console.SetCursorPosition(19, 11);
            Console.Write("t");
            Console.SetCursorPosition(21, 11);
            Console.Write("u");
            Console.SetCursorPosition(19, 13);
            Console.Write("t");
            Console.SetCursorPosition(21, 13);
            Console.Write("u");
            Console.SetCursorPosition(19, 15);
            Console.Write("t");
            Console.SetCursorPosition(21, 15);
            Console.Write("s");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("   Player Uppercase-high: 0");
            Console.SetCursorPosition(9, 19);
            Console.Write("D");
            Console.SetCursorPosition(11, 19);
            Console.Write("D");
            Console.SetCursorPosition(13, 19);
            Console.Write("D");
            Console.SetCursorPosition(15, 19);
            Console.Write("D");
            Console.SetCursorPosition(9, 21);
            Console.Write("B");
            Console.SetCursorPosition(11, 21);
            Console.Write("G");
            Console.SetCursorPosition(13, 21);
            Console.Write("G");
            Console.SetCursorPosition(15, 21);
            Console.Write("B");
            Console.ForegroundColor = ConsoleColor.White;
            cursorMovement movement = new cursorMovement(null, null);


        }
    }*/

}
