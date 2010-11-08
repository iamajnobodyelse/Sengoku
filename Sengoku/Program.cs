using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class program
    {
        static void main(string[] args)
        {
            gameBoard gameBoard = new gameBoard();
            players players = new players();
            turn turn = new turn();
            winConditions winConditions = new winConditions();
        }
    }
}
