using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class gameBoard
    {
        public char[,] board = {{'A','A','B','B','C','C'},
                         {'D','D','E','E','F','F'},
                         {'G','G','H','H','I','I'},
                         {'J','J','K','K','L','L'},
					     {'M','M','N','N','O','O'},
                         {'P','P','Q','Q','R','R'}};

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
            cursorMovement cursorMovement = new cursorMovement();
        }
    }
}
