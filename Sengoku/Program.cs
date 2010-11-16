using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sengoku";
            Console.SetWindowSize(25, 25);
            //Console.SetWindowSize(35, 35);

            gameBoard gameBoard = new gameBoard();
            players players = new players();
            turn turn = new turn();
            winConditions winConditions = new winConditions();
            Console.ReadKey();
        }
    }
}
