using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class cursorMovement
    {

        int x = 1;
        int y = 1;

        int fx = 0;
        int fy = 0;

        int boardy = 0;
        int boardx = 0;

        int bfx = 0;
        int bfy = 0;

        bool move = true;
        bool grabbed = false;
        char grab;

        public cursorMovement(gameBoard argh, turn now)
        {
            Console.SetCursorPosition(1, 1);

            while (move != false)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    ConsoleKey key = info.Key;

                    if (key == ConsoleKey.UpArrow)
                    {
                        fx = 0; fy = -2;
                        bfx = 0; bfy = -1;
                    }

                    if (key == ConsoleKey.DownArrow)
                    {
                        fx = 0; fy = 2;
                        bfx = 0; bfy = 1;
                    }

                    if (key == ConsoleKey.RightArrow)
                    {
                        fx = 2; fy = 0;
                        bfx = 1; bfy = 0;
                    }

                    if (key == ConsoleKey.LeftArrow)
                    {
                        fx = -2; fy = 0;
                        bfx = -1; bfy = 0;
                    }


                    if (fx != 0 || fy != 0)
                    {
                        x = x + fx;
                        y = y + fy;
                        boardx = boardx + bfx;
                        boardy = boardy + bfy;
                    }
                    if (x < 0 || x > 12 || y < 0 || y > 12) //This defines the edges of cursor movement
                    {
                        x = x - fx;
                        y = y - fy;
                    }
                    if (key == ConsoleKey.Spacebar)
                    {
                        if (grabbed == true)
                        {
                            (argh.board[boardy, boardx]) = grab;
                            grabbed = false;
                            move = false;
                        }
                        else if (grabbed != true)
                        {
                            grab = (argh.board[boardy, boardx]);
                            grabbed = true;
                        }
                    }
                    Console.SetCursorPosition(x, y);
                }
            }

        }
    }
}