using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris2
{
    internal class StructureArray
    {
        public void Run()
        {
            CompositeBrick[] bricks = new CompositeBrick[2]; //pole se dvěmi tvary (T a Z)

            T(ref bricks[0], 2, 2); //slovo ref je jakobych tam předal pointer - v T nedostaneme kopii dat ale odkaz na ty data

            T(ref bricks[1], 5, 10);
            while(true)
            {
                MainLoop(bricks);
                Thread.Sleep(1000);
            }


        }

        public void MainLoop(CompositeBrick[] bricks)
        {
            Console.Clear();
            //posun
            for(int i = 0; i < bricks.Length; i++)
            {
                bricks[i].y++;
            }



            //vykreslení
            for(int i = 0; i< bricks.Length; i++)
            {
                for(int j = 0; j < bricks[i].bricks.Length; j++)
                {
                    Console.SetCursorPosition(
                        bricks[i].x + bricks[i].bricks[j].x,
                        bricks[i].y + bricks[i].bricks[j].y
                    );
                    Console.Write("\u2588\u2588");
                }

            }
        }

        public void T(ref CompositeBrick compBrick, int x, int y)
        {
            compBrick.x = x;
            compBrick.y = y;

            compBrick.bricks = new Brick[4];

            compBrick.bricks[0].x = x;
            compBrick.bricks[0].y = y;

            compBrick.bricks[1].x = x + 1;
            compBrick.bricks[1].y = y;

            compBrick.bricks[2].x = x + 2;
            compBrick.bricks[2].y = y;

            compBrick.bricks[3].x = x + 1;
            compBrick.bricks[3].y = y + 1;

        }

    }
}
